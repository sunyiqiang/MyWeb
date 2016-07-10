//using MyWeb.Demo.MyUserService;
using MyWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyUserService.UserServiceClient userService = new MyUserService.UserServiceClient();
            //List<UserInfo> uList = userService.GetUserInfos().ToList();
            //uList.ForEach(u => Console.WriteLine(u.UName + "||" + u.Email));

            #region 添加用户数据
            //UserInfo u = new UserInfo()
            //    {
            //        UName = "kl",
            //        Pwd = "456",
            //        DelFlag = 1,
            //        Email = "666",
            //        Remark = "shui",
            //        SubTime = DateTime.Now
            //    };
            //if (userService.AddUserInfo(u))
            //{
            //    Console.WriteLine("添加用户成功");
            //}
            //else
            //{
            //    Console.WriteLine("添加用户失败");
            //} 
            #endregion

            #region 删除用户数据
            //userService.GetUserInfos()
            #endregion
            Console.ReadKey();
        }
    }
}
