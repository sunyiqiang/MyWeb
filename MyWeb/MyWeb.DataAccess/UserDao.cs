using MyWeb.IDataAccess;
using MyWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.DataAccess
{
    public class UserDao : BaseDao<UserInfo>, IUserDao
    {

    }
}
