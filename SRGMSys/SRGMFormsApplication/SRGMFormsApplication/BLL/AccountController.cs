using System;
using System.Collections;
using System.Linq;
using System.Data;
using SRGMFormsApplication.DAL;
using SRGMFormsApplication.Entity;

/// <summary>
/// �˻�������
/// </summary>
namespace SRGMFormsApplication.BLL
{
    public class AccountController
    {

        static AccountDB aDB = new AccountDB();
        /// <summary>
        /// �����û����� ע���û�
        /// </summary>
        /// <param name="p_account"></param>
        /// <param name="p_type"></param>
        /// <returns></returns>
        public String signin(Account p_account, int p_type)
        {
            if (null != p_account.UserName && "" != p_account.UserName)//�ж��û�����Ϊ��
            {
                Boolean had = false;
                if (1 == p_type)
                {
                    had = aDB.findSEbyUserName(p_account.UserName);
                }
                else if (2 == p_type)
                {
                    had = aDB.findSRbyUserName(p_account.UserName);
                }
                else if (0 == p_type)
                {
                    return "������ע�����Ա";
                }
                if (true != had)//�û�������
                {
                    if (null != p_account.Password && "" != p_account.Password)//�ж����벻Ϊ��
                    {
                        //�����û����뵽���ݿ�
                        if (1 == p_type)//ע���������ʦ
                        {
                            aDB.addSE(p_account);
                        }
                        else if (2 == p_type)//ע��SRGM�о���Ա
                        {
                            aDB.addSR(p_account);
                        }
                        return "ע��ɹ���";
                    }
                    else
                    {
                        return "���������룡";
                    }
                }
                else
                {
                    return "�û����Ѵ��ڣ�";
                }
            }
            else
            {
                return "�������û�����";
            }
        }

        /// <summary>
        /// ��¼
        /// </summary>
        /// <param name="p_account"></param>
        public Account login(Account p_account, int p_type)
        {
            return aDB.Login(p_account, p_type);
        }
        /// <summary>
        /// ϵͳ����Ա�鿴�������ʦ������Ϣ
        /// </summary>
        public DataSet getSoftwareEngineer()
        {
            return aDB.GetAllSEDataSet();
        }
        /// <summary>
        /// ϵͳ����Ա�鿴SRGM�о���Ա������Ϣ
        /// </summary>
        public DataSet getSRGMResearcher()
        {
            return aDB.GetAllSRDataSet();
        }
        /// <summary>
        /// ɾ���������ʦ
        /// </summary>
        /// <param name="p_SE"></param>
        /// <returns></returns>
        public int deleteSE(SoftwareEngineer p_SE)
        {
            return aDB.DeleteSE(p_SE);
        }
        /// <summary>
        /// ɾ��SRGM�о���Ա
        /// </summary>
        /// <param name="p_SR"></param>
        /// <returns></returns>
        public int deleteSR(SRGMResearch p_SR)
        {
            return aDB.DeleteSR(p_SR);
        }
    }
}
