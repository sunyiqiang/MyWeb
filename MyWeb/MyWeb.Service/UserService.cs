using Microsoft.Practices.Unity;
using MyWeb.IDataAccess;
using MyWeb.IService;
using MyWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Service
{
    public class UserService : IUserService
    {
        IUserDao iUserDao = ServiceBusContainer.Instance.Container.Resolve<IUserDao>();
        public List<UserInfo> GetUserInfos(Expression<Func<UserInfo, bool>> whereLambda)
        {
            List<UserInfo> uList = null;
            try
            {
                uList = iUserDao.Query(whereLambda).ToList();
            }
            catch (Exception ex)
            {
                log4net.LogManager.GetLogger("testApplog").Error("获取用户数据异常：" + ex.ToString());
            }
            return uList;
        }

        public bool AddUserInfo(UserInfo uInfo)
        {
            UserInfo newUInfo = null;
            try
            {
                newUInfo = iUserDao.Add(uInfo);
            }
            catch (Exception ex)
            {
                log4net.LogManager.GetLogger("testApplog").Error("添加用户数据异常：" + ex.ToString());
            }
            return newUInfo == null ? false : true;
        }

        public bool DelUserInfo(UserInfo uInfo)
        {
            bool isDelSuccess = false;
            try
            {
                isDelSuccess = iUserDao.Delete(uInfo);
            }
            catch (Exception ex)
            {
                log4net.LogManager.GetLogger("testApplog").Error("删除用户数据异常：" + ex.ToString());
            }
            return isDelSuccess;
        }
    }
}
