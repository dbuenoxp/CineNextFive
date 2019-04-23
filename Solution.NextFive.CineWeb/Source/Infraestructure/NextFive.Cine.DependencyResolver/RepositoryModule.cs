using Microsoft.Practices.Unity;
using NextFive.Cine.DataAccess.Implementation.Cine;
using NextFive.Cine.DataAccess.Interface.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.DependencyResolver
{
    public class RepositoryModule
    {
        public static void RegisterType(IUnityContainer oIUnityContainer)
        {
            //oIUnityContainer.RegisterType<ICineDataAccess, CineDataAccess>();
        }
    }
}
