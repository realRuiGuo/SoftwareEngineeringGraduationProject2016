using System;
using System.Collections;
using System.Linq;
using System.Data;
using SRGMFormsApplication.DAL;
using SRGMFormsApplication.Entity;
using System.Collections.Generic;

namespace SRGMFormsApplication.BLL
{
    public class ModelController
    {
        static ModelDB modelDB = new ModelDB();
        public DataSet getModelType()
        {
            return modelDB.getModelType();
        }

        public Model getModelByid(string p_id)
        {
            return modelDB.getModelByid(p_id);
        }
        /// <summary>
        /// 返回系统自带模型
        /// </summary>
        /// <returns></returns>
        public DataSet getModelsforSystem()
        {
            return modelDB.getModelsforSystem();
        }

        public List<Model> getModelsforSystemL()
        {
            return modelDB.getModelsforSystemL();
        }

        /// <summary>
        /// 返回当前用户拥有的模型
        /// </summary>
        /// <param name="p_account"></param>
        /// <param name="p_userType"></param>
        /// <returns></returns>
        public DataSet getModelsforUser(Account p_account, int p_userType)
        {
            return modelDB.getModelsforUser(p_account, p_userType);
        }
        /// <summary>
        /// 添加系统模型
        /// </summary>
        /// <param name="p_model"></param>
        /// <returns></returns>
        public int addModelstoSystem(Model p_model,List<string> p_filePath)
        {
            //设置导入后模型的路径
            if (p_model.Name.IndexOf(";") > -1)//多文件模型
            {
                string[] name = p_model.Name.Split(';');
                int i = 0;
                foreach(string modelName in name)
                {                   
                    string pathtemp = "\\Model\\" + modelName + ".m ";
                    p_model.Path += pathtemp;//存入DB的累加路径
                    //复制文件到指定目录
                    FileHelper.Copy(p_filePath[i],
                        System.Environment.CurrentDirectory + pathtemp);
                    i++;
                }
            }
            else
            {
                p_model.Path = "\\Model\\" + p_model.Name + ".m";
                //复制文件到指定目录
                foreach (string path in p_filePath)
                {
                    FileHelper.Copy(path,
                    System.Environment.CurrentDirectory + p_model.Path);
                }
            }
            return modelDB.addDataSetsforSystem(p_model);
        }
        /// <summary>
        /// 当前用户导入模型
        /// </summary>
        /// <param name="p_model"></param>
        /// <param name="p_account"></param>
        /// <param name="p_userType"></param>
        /// <returns></returns>
        public int addModelsforUser(Model p_model, Account p_account, int p_userType, String p_filePath)
        {
            //设置导入后模型的路径
            p_model.Path = "\\Model\\" + p_account.UserName + p_userType.ToString() + "\\" + p_model.Name + ".m";
            //复制文件到指定目录
            FileHelper.Copy(p_filePath,
                System.Environment.CurrentDirectory + p_model.Path);
            return modelDB.addModelsforUser(p_model, p_account, p_userType);
        }
        /// <summary>
        /// 删除系统模型
        /// </summary>
        /// <param name="p_model"></param>
        /// <returns></returns>
        public int deleteModelsfromSystem(Model p_model)
        {
            //删除相应目录下的m文件
            FileHelper.DeleteFile(System.Environment.CurrentDirectory + p_model.Path);
            return modelDB.deleteModelsforSystem(p_model);
        }
        /// <summary>
        /// 当前用户删除模型
        /// </summary>
        /// <param name="p_model"></param>
        /// <param name="p_account"></param>
        /// <param name="p_userType"></param>
        /// <returns></returns>
        public int deleteModelsforUser(Model p_model, Account p_account, int p_userType)
        {
            //删除相应目录下的m文件
            FileHelper.DeleteFile(System.Environment.CurrentDirectory + p_model.Path);
            return modelDB.deleteModelsforUser(p_model, p_account, p_userType);
        }

        public DataSet getAllValue0()
        {
            return modelDB.getAllValue0();
        }

        public int addValue0(Model p_model,FDataSet p_dataSet,string value0)
        {
            return modelDB.addValue0(p_model, p_dataSet, value0);
        }

        /// <summary>
        /// 得到指定的参数初值字符串
        /// </summary>
        /// <param name="p_dataSet"></param>
        /// <param name="p_model"></param>
        /// <returns></returns>
        public string getValue0(FDataSet p_dataSet,Model p_model)
        {
            DataSet ds = modelDB.getValue0(p_dataSet, p_model);
            if (!IfExitData(ds,0))
            {
                return null;
            }
            else
            {
                return ds.Tables[0].Rows[0]["value0"].ToString();
            }
        }

        public int deleteValue0Item(Model p_model,FDataSet p_dataSet,string p_value0)
        {
            return modelDB.deleteValue0Item(p_model, p_dataSet, p_value0);
        }

        /// <summary>
        /// 检查一个DataSet 里面是否含有数据
        /// </summary>
        /// <param name="ds">要检测的DataSet</param>
        /// <param name="tableIndex">DataSet里Table的索引</param>
        /// <returns>True: 里面有数据。 False：里面没有数据</returns>
        public static bool IfExitData(DataSet ds, int tableIndex)
        {
            if (ds != null && ds.Tables[tableIndex].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
