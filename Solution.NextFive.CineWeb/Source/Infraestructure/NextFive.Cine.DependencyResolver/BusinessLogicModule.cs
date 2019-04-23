using Microsoft.Practices.Unity;
using NextFive.Cine.BusinessLogic.Implementation.Cine;
using NextFive.Cine.BusinessLogic.Interface.Cine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextFive.Cine.DependencyResolver
{
    public class BusinessLogicModule
    {
        public static void RegisterType(IUnityContainer oIUnityContainer)
        {
            //oIUnityContainer.RegisterType<ICineBusinessLogic, CineBusinessLogic>();
        }
     }
}
