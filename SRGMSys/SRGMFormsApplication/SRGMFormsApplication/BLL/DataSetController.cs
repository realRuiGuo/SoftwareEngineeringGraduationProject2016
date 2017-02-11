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
        /// ����ϵͳʧЧ���ݼ�;  DataSet��ʽ
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
        /// ���ص�ǰ�û���ʧЧ���ݼ�
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
        /// ϵͳ����ԱΪϵͳ���ʧЧ���ݼ�
        /// </summary>
        /// <param name="p_dataSet"></param>
        /// <returns></returns>
        public int addDataSetstoSystem(FDataSet p_dataSet,String p_filePath)
        {
            //�������ݼ�·��
            p_dataSet.Path = "\\DS\\" + p_dataSet.Name + ".txt";
            //�����ļ���ָ��Ŀ¼
            FileHelper.Copy(p_filePath, System.Environment.CurrentDirectory + p_dataSet.Path);

            return dsDB.addDataSetsforSystem(p_dataSet);
        }
        /// <summary>
        /// se��sr�������ݼ�
        /// </summary>
        /// <param name="p_dataSet"></param>
        /// <param name="p_account"></param>
        /// <param name="p_userType"></param>
        /// <returns></returns>
        public int addDataSetsforUser(FDataSet p_dataSet, Account p_account, int p_userType,String p_filePath)
        {
            //�������ݼ�·��
            p_dataSet.Path = "\\DS\\" + p_account.UserName + p_userType.ToString() + "\\"+
                p_dataSet.Name + ".txt";
            //�����ļ���ָ��Ŀ¼
            FileHelper.Copy(p_filePath, System.Environment.CurrentDirectory + p_dataSet.Path);
            return dsDB.addDataSetsforUser(p_dataSet, p_account, p_userType);
        }

        /// <summary>
        /// ɾ��ϵͳ�Դ���ʧЧ���ݼ�
        /// </summary>
        /// <param name="p_dataSet"></param>
        /// <returns></returns>
        public int deleteDataSetsfromSystem(FDataSet p_dataSet)
        {
            //ɾ����ӦĿ¼�µ�txt�ļ�
            FileHelper.DeleteFile(System.Environment.CurrentDirectory + p_dataSet.Path);

            return dsDB.deleteDataSetsforSystem(p_dataSet);
        }
        /// <summary>
        /// ɾ����ͬ�û���ʧЧ���ݼ�
        /// </summary>
        /// <param name="p_dataSet"></param>
        /// <param name="p_account"></param>
        /// <param name="p_userType"></param>
        /// <returns></returns>
        public int deleteDataSetsforUser(FDataSet p_dataSet, Account p_account, int p_userType)
        {
             //ɾ����ӦĿ¼�µ�txt�ļ�
            FileHelper.DeleteFile(System.Environment.CurrentDirectory + p_dataSet.Path);

            return dsDB.deleteDataSetsforUser(p_dataSet, p_account, p_userType);
        }

        public void changeDataSets(List<FDataSet> dataSets)
        {

        }
    }

}