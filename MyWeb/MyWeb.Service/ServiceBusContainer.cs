using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Service
{
    public class ServiceBusContainer
    {
        private static ServiceBusContainer _instance;
        private static object lockObj = new object();
        private static IUnityContainer _container;
        private ServiceBusContainer() { }
        public static ServiceBusContainer Instance
        {
            get
            {
                lock (lockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new ServiceBusContainer();
                    }
                    return _instance;
                }
            }
        }

        public IUnityContainer Container
        {
            get
            {
                lock (lockObj)
                {
                    if (_container == null)
                    {
                        _container = new UnityContainer();
                        UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
                        section.Configure(_container, "ContainerService");
                    }
                    return _container;
                }
            }
        }
    }
}
