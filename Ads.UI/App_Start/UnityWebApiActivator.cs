using Ads.UI.Infrastructure;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace Ads.UI.App_Start
{
    public static class UnityWebApiActivator
    {
        public static  void Start()
        {
            var container = UnityConfig.GetConfiguredContainer();
            ConfigureDepencyResolver(container);
        }

        private static void ConfigureDepencyResolver(IUnityContainer container)
        {
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}

