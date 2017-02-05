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
        public int addModelstoSystem(Model p_model,String p_filePath)
        {
            //设置导入后模型的路径
            p_model.Path = "\\Model\\" + p_model.Name + ".m";
            //复制文件到指定目录
            FileHelper.Copy(p_filePath,
                System.Environment.CurrentDirectory + p_model.Path);
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

        public void changeModels(List<Model> models)
        {
        }
    }

}
