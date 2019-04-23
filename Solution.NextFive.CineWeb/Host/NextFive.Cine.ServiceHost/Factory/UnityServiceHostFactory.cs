using Microsoft.Practices.Unity;
using NextFive.Cine.DependencyResolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using System.Web;

namespace NextFive.Cine.ServiceHost.Factory
{
    public class UnityServiceHostFactory : ServiceHostFactory
    {
        private readonly IUnityContainer oIUnityContainer;

        public UnityServiceHostFactory()
        {
            oIUnityContainer = new UnityContainer();
            RegisterTypes(oIUnityContainer);
        }
        protected override System.ServiceModel.ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return new UnityServiceHost(this.oIUnityContainer, serviceType, baseAddresses);
        }

        private void RegisterTypes(IUnityContainer oIUnityContainer)
        {
            RepositoryModule.RegisterType(oIUnityContainer);
            BusinessLogicModule.RegisterType(oIUnityContainer);
        }
    }
}