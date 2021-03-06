﻿using System;
using System.Collections;
using System.Linq;
using System.Data;
using System.Text;
using System.Reflection;
using System.IO;
using SRGMFormsApplication.DAL;
using SRGMFormsApplication.Entity;
using System.Collections.Generic;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using Matlab;
using System.Windows.Forms;

namespace SRGMFormsApplication.BLL
{
    public class DisplayController
    {
        static DisplayDB dDB = new DisplayDB();
        static ModelController mc = new ModelController();
        static MnDSn t1 = new MnDSn();
        static MWMCR mcr;

        String CurrentPath = System.Environment.CurrentDirectory;//当前路径
        /// <summary>
        /// 返回与模型相匹配的数据集集合   --dataset 用于显示
        /// </summary>
        /// <param name="p_models"></param>
        /// <returns></returns>
        public DataTable chooseModels(List<Model> p_models)
        {
            if (1 == p_models.Count)
            {
                return dDB.getDataSetMatchingModel(p_models[0]).Tables[0];
            }
            else
            {
                DataTable result = dDB.getDataSetMatchingModel(p_models[0]).Tables[0];
                foreach (Model model in p_models)
                {
                    DataTable temp = dDB.getDataSetMatchingModel(model).Tables[0];
                    var query = result.AsEnumerable().Intersect(temp.AsEnumerable(), DataRowComparer.Default);//求交集
                    if (query.Count() > 0)
                    {
                        result = query.CopyToDataTable();
                    }
                    else//如果交集为空
                    {
                        result = null;
                        break;
                    }
                }
                return result;
            }
        }

        /// <summary>
        /// 返回与数据集相匹配的模型集合   --dataset 用于显示
        /// </summary>
        /// <param name="p_dataSets"></param>
        /// <returns></returns>
        public DataTable chooseDataSets(List<FDataSet> p_dataSets)
        {
            if (1 == p_dataSets.Count)
            {
                return dDB.getModelMatchingDataSet(p_dataSets[0]).Tables[0];
            }
            else
            {
                DataTable result = dDB.getModelMatchingDataSet(p_dataSets[0]).Tables[0];
                foreach (FDataSet dataSet in p_dataSets)
                {
                    DataTable temp = new DataTable();
                    temp = dDB.getModelMatchingDataSet(dataSet).Tables[0];
                    var query = result.AsEnumerable().Intersect(temp.AsEnumerable(), DataRowComparer.Default);//求交集
                    if (query.Count() > 0)
                    {
                        result = query.CopyToDataTable();
                    }
                    else//如果交集为空
                    {
                        result = null;
                        break;
                    }
                }
                return result;
            }
        }

        /// <summary>
        /// 通过调用dll文件，在失效数据集上验证模型
        /// </summary>
        /// <param name="p_model"></param>
        /// <param name="p_dataSet"></param>
        public void choose(List<Model> p_model, List<FDataSet> p_dataSet)
        {
            foreach (FDataSet dataSet in p_dataSet)
            {
                foreach (Model model in p_model)
                {
                    if(model.Owner == 0)//系统模型的处理方法
                    {
                        //调用dll文件（传入数据集名）
                        MWCharArray modelName = model.Name.Trim();
                        MWCharArray dataSetName = dataSet.Name.Trim();

                        //取初值字符串
                        string value0 = mc.getValue0(dataSet, model);
                        if (value0 == null)
                        {
                            MessageBox.Show("未设置模型" + model.Name + "在数据集" + dataSet.Name + "上的初值！", "提示",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            continue;
                        }
                        else
                        {
                            //判断匹配（数据集）类型，调用相应的方法                
                            if (1 == model.Type.TypeID || 2 == model.Type.TypeID)//完美和ID模型
                            {
                                if (1 == dataSet.Type.TypeID)
                                {
                                    MWCharArray xmd0 = value0;
                                    //Test.other(modelName, dataSetName, xmd0);

                                    t1.T1MnDSn(modelName, dataSetName, xmd0);
                                }
                            }
                            else if (3 == model.Type.TypeID || 4 == model.Type.TypeID || 5 == model.Type.TypeID)
                            {
                                string[] name = model.Name.Split(';');
                                string wt = null;
                                string mt = null;
                                foreach (string item in name)
                                {
                                    if (item.IndexOf("wt") > -1)
                                    {
                                        wt = item;
                                    }
                                    if (item.IndexOf("mt") > -1)
                                    {
                                        mt = item;
                                    }
                                }
                                MWCharArray modelwtName = wt.Trim();
                                MWCharArray modelmtName = mt.Trim();
                                string[] xmd = value0.Split(';');
                                MWCharArray xmd0wtString = xmd[0];
                                MWCharArray xmd0mtString = xmd[1];
                                MWArray paraNum = model.ParaNum;
                                if (2 == dataSet.Type.TypeID)
                                {
                                    t1.T2MnDSn(modelwtName, modelmtName, dataSetName, xmd0wtString, xmd0mtString, paraNum);
                                }
                                else if (3 == dataSet.Type.TypeID)
                                {
                                    MWArray cp = dataSet.Cp;
                                    t1.T3MnDSn(modelwtName, modelmtName, dataSetName, xmd0wtString, xmd0mtString, paraNum, cp);
                                }
                            }
                        }
                    }
                    else//用户模型
                    {
                        extraDLLchoose(model, dataSet);                       
                    }

                }
            }
        }

        /// <summary>
        /// 混合绘图
        /// </summary>
        /// <param name="p_model"></param>
        /// <param name="p_dataSet"></param>
        /// <returns></returns>
        public List<string> mixDraw(List<Model> p_model, FDataSet p_dataSet)
        {
            List<string> fullmodelName = new List<string>();
            string dataSetName = p_dataSet.Name.Trim();
            MWCharArray dataSetName_MW = dataSetName.Trim();
            if (p_dataSet.Type.TypeID == 1)//通过T1MnDSnMixD处理
            {
                string modelNames = "";
                string ymdpaths = "";
                foreach (Model model in p_model)//获得modelNames和ymdpaths
                {
                    modelNames += model.Name + " ";
                    //设置ymdpath
                    string ymdpath = System.Environment.CurrentDirectory +
                    "\\Result\\" + dataSetName + "_" + model.Name + "_ymd"; //设置ymmtdpath
                    ymdpaths += ymdpath + " ";
                }
                if (modelNames != string.Empty && ymdpaths != string.Empty)
                {
                    MWCharArray modelNames_MW = modelNames.Trim();
                    MWCharArray ymdpaths_MW = ymdpaths.Trim();
                    t1.T1MnDSnMixD(modelNames_MW, ymdpaths_MW, dataSetName_MW);
                    fullmodelName.Add(modelNames);
                }
            }
            if (p_dataSet.Type.TypeID == 2 || p_dataSet.Type.TypeID == 3)//通过T2MnDSnMixD处理
            {
                string modelwtNames = "";
                string modelmtNames = "";
                string ymwtdpaths = "";
                string ymmtdpaths = "";
                foreach (Model model in p_model)//获得modelwtNames、modelmtNames和ymwtdpaths、ymmtdpaths
                {
                    string[] name = model.Name.Split(';');
                    string wt = null;
                    string mt = null;
                    foreach (string item in name)
                    {
                        if (item.IndexOf("wt") > -1)
                        {
                            wt = item;
                        }
                        if (item.IndexOf("mt") > -1)
                        {
                            mt = item;
                        }
                    }
                    string modelwtName = wt.Trim();
                    string ymwtdpath = System.Environment.CurrentDirectory +
                    "\\Result\\" + dataSetName + "_" + modelwtName + "_ymwtd"; //设置ymwtdpath                       
                    modelwtNames += modelwtName + " ";
                    ymwtdpaths += ymwtdpath + " ";

                    string modelmtName = mt.Trim();
                    string ymmtdpath = System.Environment.CurrentDirectory +
                    "\\Result\\" + dataSetName + "_" + modelmtName + "_ymmtd"; //设置ymmtdpath
                    modelmtNames += modelmtName + " ";
                    ymmtdpaths += ymmtdpath + " ";
                }
                //
                if (modelwtNames != string.Empty && modelmtNames != string.Empty
                    && ymwtdpaths != string.Empty && ymmtdpaths != string.Empty)
                {
                    MWCharArray modelwtNames_MW = modelwtNames.Trim();
                    MWCharArray modelmtNames_MW = modelmtNames.Trim();
                    MWCharArray ymwtdpaths_MW = ymwtdpaths.Trim();
                    MWCharArray ymmtdpaths_MW = ymmtdpaths.Trim();
                    t1.T2MnDSnMixD(modelwtNames_MW, modelmtNames_MW, ymwtdpaths_MW, ymmtdpaths_MW, dataSetName_MW);
                    fullmodelName.Add(modelwtNames);
                    fullmodelName.Add(modelmtNames);
                }
            }
            return fullmodelName;
        }

        /// <summary>
        /// 通过添加的DLL处理用户模型
        /// </summary>
        /// <param name="p_model"></param>
        /// <param name="p_dataSet"></param>
        /// <param name="p_DLLName"></param>
        public void extraDLLchoose(Model p_model, FDataSet p_dataSet)
        {
            string p_DLLName = p_model.Name;
            #region 首先使用.dll来初始化mcr,因为这个dll是混编“合法”产生的，只有这样才能顺利启动mcr
            if (MWMCR.MCRAppInitialized)
            {
                string path = Path.Combine(System.Environment.CurrentDirectory, p_DLLName + ".dll");
                Assembly assembly = Assembly.LoadFile(path);
                string ctfFilePath = assembly.Location;
                int lastDelimiter = ctfFilePath.LastIndexOf(@"\");
                ctfFilePath = ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));
                string ctfFileName = p_DLLName + ".ctf";
                Stream embeddedCtfStream = null;
                String[] resourceStrings = assembly.GetManifestResourceNames();

                foreach (String name in resourceStrings)
                {
                    if (name.Contains(ctfFileName))
                    {
                        embeddedCtfStream = assembly.GetManifestResourceStream(name);
                        break;
                    }
                }
                mcr = new MWMCR("", ctfFilePath, embeddedCtfStream, true);
            }
            else
            {
                throw new ApplicationException("MWArray assembly could not be initialized");
            }
            #endregion

            //调用dll文件（传入数据集名）
            MWCharArray modelName = p_model.Name.Trim();
            MWCharArray dataSetName = p_dataSet.Name.Trim();

            //取初值字符串
            string value0 = mc.getValue0(p_dataSet, p_model);
            if (value0 == null)
            {
                MessageBox.Show("未设置模型" + p_model.Name + "在数据集" + p_dataSet.Name + "上的初值！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //判断匹配（数据集）类型，调用相应的方法                
                if (1 == p_model.Type.TypeID || 2 == p_model.Type.TypeID)//完美和ID模型
                {
                    if (1 == p_dataSet.Type.TypeID)
                    {
                        MWCharArray xmd0 = value0;
                        
                        //调用混编dll中的封装函数
                        MWArray[] shuru = { modelName, dataSetName, xmd0 };
                        mcr.EvaluateFunction(0, "T1MnDSn", shuru);
                        
                        //Test.other(modelName, dataSetName, xmd0);
                        //t1.T1MnDSn(modelName, dataSetName, xmd0);
                    }
                }
                else if (3 == p_model.Type.TypeID || 4 == p_model.Type.TypeID || 5 == p_model.Type.TypeID)
                {
                    string[] name = p_model.Name.Split(';');
                    string wt = null;
                    string mt = null;
                    foreach (string item in name)
                    {
                        if (item.IndexOf("wt") > -1)
                        {
                            wt = item;
                        }
                        if (item.IndexOf("mt") > -1)
                        {
                            mt = item;
                        }
                    }
                    MWCharArray modelwtName = wt.Trim();
                    MWCharArray modelmtName = mt.Trim();
                    string[] xmd = value0.Split(';');
                    MWCharArray xmd0wtString = xmd[0];
                    MWCharArray xmd0mtString = xmd[1];
                    MWArray paraNum = p_model.ParaNum;
                    if (2 == p_dataSet.Type.TypeID)
                    {
                        //调用混编dll中的封装函数
                        MWArray[] shuru = { modelwtName, modelmtName, dataSetName, xmd0wtString, xmd0mtString, paraNum };
                        mcr.EvaluateFunction(0, "T2MnDSn", shuru);
                        //t1.T2MnDSn(modelwtName, modelmtName, dataSetName, xmd0wtString, xmd0mtString, paraNum);
                    }
                    else if (3 == p_dataSet.Type.TypeID)
                    {
                        MWArray cp = p_dataSet.Cp;
                        //调用混编dll中的封装函数
                        MWArray[] shuru = { modelwtName, modelmtName, dataSetName, xmd0wtString, xmd0mtString, paraNum, cp };
                        mcr.EvaluateFunction(0, "T3MnDSn", shuru);
                        //t1.T3MnDSn(modelwtName, modelmtName, dataSetName, xmd0wtString, xmd0mtString, paraNum, cp);
                    }
                }
            }
        }

    }
}
