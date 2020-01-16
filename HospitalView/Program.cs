using HospitalController;
using HospitalModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace HospitalView
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
            Application.Run(container.Resolve<FormAuth>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<DbContext, HospitalDbContext>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<PatientCardController>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<AuthController>(new
           HierarchicalLifetimeManager());

            return currentContainer;
        }
    }
}
