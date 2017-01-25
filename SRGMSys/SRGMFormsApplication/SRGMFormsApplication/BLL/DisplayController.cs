using System;
using System.Collections;
using System.Linq;
using System.Data;
using SRGMFormsApplication.DAL;
using System.Collections.Generic;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

using T1fnDSnFit;

namespace SRGMFormsApplication.BLL
{
    public class DisplayController
    {
        static DisplayDB dDB = new DisplayDB();
        static T1 T1fnDSnFit = new T1();
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
        public void choose(Model p_model,FDataSet p_dataSet)
        {
            //step1 将m文件复制到当前目录（dll所在目录），命名为f.m
            FileHelper.Copy(CurrentPath + p_model.Path, CurrentPath + "f.m");
            //step2 调用dll文件（传入数据集名）


        }

    }
}
