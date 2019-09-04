using AvtoShopServiceDAL.Interfaces;
using AvtoShopServiceImplementDataBase;
using AvtoShopServiceImplementDataBase.Implementations;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace AvtoShopServiceView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormEntry>());

        }

        public static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<DbContext, CarDBContext>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<ICarService, CarServiceDB>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IClientService, ClientServiceDB>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IMainService, MainServiceDB>(new
           HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
