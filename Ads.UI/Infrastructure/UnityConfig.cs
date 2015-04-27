using Microsoft.Practices.Unity;
using Ads.DataAcces.Repositories;
using Ads.DataAcces;
using Ads.EntityFrameWork;
using Ads.Model;
using Ads.Service.Contracts;
using Ads.Service.Implementations;
using Ads.Business.Abstracts;
using Ads.Business;
using System.Data.Entity;
using Unity.WebApi;
using System.Web.Http;

namespace Ads.UI.Infrastructure
{
    public static class UnityConfig 
    {
        private static IUnityContainer unityContainer;

        //public static IUnityContainer GetConfiguredContainer()
        //{
        //    if (unityContainer != null)
        //        return unityContainer;

        //    unityContainer = new UnityContainer();
        //    RegisterTypes();

        //    return unityContainer;
        //}

        public static void RegisterComponents()
        {
            unityContainer = new UnityContainer();

            RegisterTypes();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(unityContainer);
        }

        private static void RegisterTypes() {
            RegisterContext();
            RegisterRepositories();
            RegisterServices();
            RegisterBusiness();
        }

        private static void RegisterContext()
        {
            unityContainer.RegisterType<IContext, MySQLEntityContext>();
        }

        private static void RegisterRepositories() {
            unityContainer.RegisterType<IRepository<AdBase> ,RepositoryBase<AdBase>>(new InjectionConstructor(unityContainer.Resolve<IContext>()));

        }

        private static void RegisterServices() { 
            unityContainer.RegisterType<IAdBaseService, AdBaseService>();
        }

        private static void RegisterBusiness() {
            unityContainer.RegisterType<IAdBaseBusiness, AdBaseBusiness>(new InjectionConstructor(unityContainer.Resolve<IAdBaseService>()));
        }


    }
}