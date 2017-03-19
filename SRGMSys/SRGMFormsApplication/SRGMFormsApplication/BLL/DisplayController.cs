using System;
using System.Collections;
using System.Linq;
using System.Data;
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

                    //调用dll文件（传入数据集名）
                    MWCharArray modelName = model.Name.Trim();
                    MWCharArray dataSetName = dataSet.Name.Trim();

                    //取初值字符串
                    string value0 = mc.getValue0(dataSet, model);
                    if (value0 == null)
                    {
                        MessageBox.Show("未设置模型" + model.Name + "在数据集" + dataSet.Name + "上的初值！", "提示",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //判断匹配（数据集）类型，调用相应的方法                
                        if (1 == model.Type.TypeID || 2 == model.Type.TypeID)//完美和ID模型
                        {
                            if (1 == dataSet.Type.TypeID)
                            {
                                MWCharArray xmd0 = value0;
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
            }
        }

    }
}
