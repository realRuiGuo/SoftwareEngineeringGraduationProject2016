using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using SRGMFormsApplication.Entity;

namespace SRGMFormsApplication.DAL
{
    public class DisplayDB
    {

        #region 得到与所选一个模型匹配的失效数据集，返回DataSet(只有name字段)
        /// <summary>
        /// 得到与model匹配的dataset
        /// </summary>
        /// <returns></returns>
        public DataSet getDataSetMatchingModel(Model p_model)
        {
            string sql = "select dsname as 名称 from value0" +
               " where modelname=@modelname";

            SqlParameter sp = new SqlParameter("@modelname", p_model.Name);

            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql, sp);
            return ds;
        }
        #endregion

        #region 得到与所选一个失效数据集匹配的模型，返回DataSet(只有name字段)
        /// <summary>
        /// 得到与dataset匹配的model
        /// </summary>
        /// <returns></returns>
        public DataSet getModelMatchingDataSet(FDataSet p_dataSet)
        {
            string sql = "select modelname as 名称 from value0" +
               " where dsname=@dsname";

            SqlParameter sp = new SqlParameter("@dsname", p_dataSet.Name);

            DataSet ds = SqlHelper.ExecuteReaderDataSet(sql, sp);
            return ds;
        }
        #endregion


    }
}
