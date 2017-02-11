using System;
using System.Collections;
using System.Linq;
using System.Data;
using SRGMFormsApplication.Entity;
using SRGMFormsApplication.DAL;
using System.Collections.Generic;

namespace SRGMFormsApplication.BLL
{
    public class DataSetController
    {
        static FDataSetDB dsDB = new FDataSetDB();

        public FDataSet getDataSetByid(string p_id)
        {
            return dsDB.getDataSetByid(p_id);
        }
        /// <summary>
        /// 返回系统失效数据集;  DataSet形式
        /// </summary>
        /// <returns></returns>
        public DataSet getDataSetsforSystem()
        {
            return dsDB.getDataSetsforSystem();
        }

        public List<FDataSet> getDataSetsforSystemL()
        {
            return dsDB.getDataSetsforSystemL();
        }

        /// <summary>
        /// 返回当前用户的失效数据集
        /// </summary>
        /// <param name="p_account"></param>
        /// <param name="p_type"></param>
        /// <returns></returns>
        public DataSet getDataSetsforUser(Account p_account, int p_type)
        {
            return dsDB.getDataSetsforUser(p_account, p_type);
        }

        public List<FDataSet> getDataSetsfoUserL(Account p_account, int p_type)
        {
            return dsDB.getDataSetsforUserL(p_account, p_type);
        }

        /// <summary>
        /// 系统管理员为系统添加失效数据集
        /// </summary>
        /// <param name="p_dataSet"></param>
        /// <returns></returns>
        public int addDataSetstoSystem(FDataSet p_dataSet,String p_filePath)
        {
            //设置数据集路径
            p_dataSet.Path = "\\DS\\" + p_dataSet.Name + ".txt";
            //复制文件到指定目录
            FileHelper.Copy(p_filePath, System.Environment.CurrentDirectory + p_dataSet.Path);

            return dsDB.addDataSetsforSystem(p_dataSet);
        }
        /// <summary>
        /// se、sr导入数据集
        /// </summary>
        /// <param name="p_dataSet"></param>
        /// <param name="p_account"></param>
        /// <param name="p_userType"></param>
        /// <returns></returns>
        public int addDataSetsforUser(FDataSet p_dataSet, Account p_account, int p_userType,String p_filePath)
        {
            //设置数据集路径
            p_dataSet.Path = "\\DS\\" + p_account.UserName + p_userType.ToString() + "\\"+
                p_dataSet.Name + ".txt";
            //复制文件到指定目录
            FileHelper.Copy(p_filePath, System.Environment.CurrentDirectory + p_dataSet.Path);
            return dsDB.addDataSetsforUser(p_dataSet, p_account, p_userType);
        }

        /// <summary>
        /// 删除系统自带的失效数据集
        /// </summary>
        /// <param name="p_dataSet"></param>
        /// <returns></returns>
        public int deleteDataSetsfromSystem(FDataSet p_dataSet)
        {
            //删除相应目录下的txt文件
            FileHelper.DeleteFile(System.Environment.CurrentDirectory + p_dataSet.Path);

            return dsDB.deleteDataSetsforSystem(p_dataSet);
        }
        /// <summary>
        /// 删除不同用户的失效数据集
        /// </summary>
        /// <param name="p_dataSet"></param>
        /// <param name="p_account"></param>
        /// <param name="p_userType"></param>
        /// <returns></returns>
        public int deleteDataSetsforUser(FDataSet p_dataSet, Account p_account, int p_userType)
        {
             //删除相应目录下的txt文件
            FileHelper.DeleteFile(System.Environment.CurrentDirectory + p_dataSet.Path);

            return dsDB.deleteDataSetsforUser(p_dataSet, p_account, p_userType);
        }

        public void changeDataSets(List<FDataSet> dataSets)
        {

        }
    }

}