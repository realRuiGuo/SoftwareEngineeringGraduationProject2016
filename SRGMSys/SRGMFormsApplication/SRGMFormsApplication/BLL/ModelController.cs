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
        /// ����ϵͳ�Դ�ģ��
        /// </summary>
        /// <returns></returns>
        public DataSet getModelsforSystem()
        {
            return modelDB.getModelsforSystem();
        }
        /// <summary>
        /// ���ص�ǰ�û�ӵ�е�ģ��
        /// </summary>
        /// <param name="p_account"></param>
        /// <param name="p_userType"></param>
        /// <returns></returns>
        public DataSet getModelsforUser(Account p_account, int p_userType)
        {
            return modelDB.getModelsforUser(p_account, p_userType);
        }
        /// <summary>
        /// ���ϵͳģ��
        /// </summary>
        /// <param name="p_model"></param>
        /// <returns></returns>
        public int addModelstoSystem(Model p_model,String p_filePath)
        {
            //���õ����ģ�͵�·��
            p_model.Path = "\\Model\\" + p_model.Name + ".m";
            //�����ļ���ָ��Ŀ¼
            FileHelper.Copy(p_filePath,
                System.Environment.CurrentDirectory + p_model.Path);
            return modelDB.addDataSetsforSystem(p_model);
        }
        /// <summary>
        /// ��ǰ�û�����ģ��
        /// </summary>
        /// <param name="p_model"></param>
        /// <param name="p_account"></param>
        /// <param name="p_userType"></param>
        /// <returns></returns>
        public int addModelsforUser(Model p_model, Account p_account, int p_userType, String p_filePath)
        {
            //���õ����ģ�͵�·��
            p_model.Path = "\\Model\\" + p_account.UserName + p_userType.ToString() + "\\" + p_model.Name + ".m";
            //�����ļ���ָ��Ŀ¼
            FileHelper.Copy(p_filePath,
                System.Environment.CurrentDirectory + p_model.Path);
            return modelDB.addModelsforUser(p_model, p_account, p_userType);
        }
        /// <summary>
        /// ɾ��ϵͳģ��
        /// </summary>
        /// <param name="p_model"></param>
        /// <returns></returns>
        public int deleteModelsfromSystem(Model p_model)
        {
            //ɾ����ӦĿ¼�µ�m�ļ�
            FileHelper.DeleteFile(System.Environment.CurrentDirectory + p_model.Path);
            return modelDB.deleteModelsforSystem(p_model);
        }
        /// <summary>
        /// ��ǰ�û�ɾ��ģ��
        /// </summary>
        /// <param name="p_model"></param>
        /// <param name="p_account"></param>
        /// <param name="p_userType"></param>
        /// <returns></returns>
        public int deleteModelsforUser(Model p_model, Account p_account, int p_userType)
        {
            //ɾ����ӦĿ¼�µ�m�ļ�
            FileHelper.DeleteFile(System.Environment.CurrentDirectory + p_model.Path);
            return modelDB.deleteModelsforUser(p_model, p_account, p_userType);
        }

        public void changeModels(List<Model> models)
        {
        }
    }

}
