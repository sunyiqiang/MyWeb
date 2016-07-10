using MyWeb.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MyWeb.Factory
{
    public class DbContextFactory
    {
        static public DbContext GetDbContext()
        {
            DbContext dbContext = HttpContext.Current.Items["DbContext"] as DbContext;
            if (dbContext == null)
            {
                dbContext = new DemoCodeDBEntities();
                HttpContext.Current.Items.Add("DbContext", dbContext);
            }
            return dbContext;
        }
    }
}
