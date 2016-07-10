using MyWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.IService
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        List<UserInfo> GetUserInfos(Expression<Func<UserInfo, bool>> whereLambda);

        [OperationContract]
        bool AddUserInfo(UserInfo uInfo);

        [OperationContract]
        bool DelUserInfo(UserInfo uInfo);
    }
}
