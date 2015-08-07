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

        public static IUnityContainer GetConfiguredContainer()
        {
            if (unityContainer != null)
                return unityContainer;

            unityContainer = new UnityContainer();
            RegisterTypes();

            return unityContainer;
        }

        //public static void RegisterComponents()
        //{
        //    unityContainer = new UnityContainer();

        //    RegisterTypes();

        //    GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(unityContainer);
        //}

        private static void RegisterTypes() {
            RegisterContext();
            RegisterRepositories();
            RegisterServices();
            RegisterBusiness();
        }

        private static void RegisterContext()
        {
            unityContainer.RegisterType<IContext, dialisisEntities>();
        }

        private static void RegisterRepositories() {
            unityContainer.RegisterType<IRepository<Base> ,RepositoryBase<Base>>(new InjectionConstructor(unityContainer.Resolve<IContext>()));
            unityContainer.RegisterType<IRepository<Ads.Model.paciente>, RepositoryBase<Ads.Model.paciente>>(new InjectionConstructor(unityContainer.Resolve<IContext>()));
            unityContainer.RegisterType<IRepository<Ads.Model.estudio>, RepositoryBase<Ads.Model.estudio>>(new InjectionConstructor(unityContainer.Resolve<IContext>()));

        }

        private static void RegisterServices() { 
            //unityContainer.RegisterType<IBaseService, BaseService>();
            unityContainer.RegisterType<IPacienteService, PacienteService>();
            unityContainer.RegisterType<IEstudioService, EstudioService>();
        }

        private static void RegisterBusiness() {
            unityContainer.RegisterType<IPacienteBusiness, PacienteBusiness>(new InjectionConstructor(unityContainer.Resolve<IPacienteService>()));
            unityContainer.RegisterType<IEstudioBusiness, EstudioBusiness>(new InjectionConstructor(unityContainer.Resolve<IEstudioService>()));
        }


    }
}