using MyWeb.DataAccess;
using MyWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDao uDao = new UserDao();
            List<UserInfo> uinfoList = uDao.Query(u => u.Id > 30).ToList();
            uinfoList.ForEach(u => Console.WriteLine(u.UName + "||" + u.Email));

            Console.ReadKey();
        }
    }
}
