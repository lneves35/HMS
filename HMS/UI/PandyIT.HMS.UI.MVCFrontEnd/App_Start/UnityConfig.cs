using System.Configuration;
using System.Data.Entity;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using PandyIT.Core.Database.Implementations;
using PandyIT.Core.Database.Interfaces;
using PandyIT.Core.Validation;
using PandyIT.Core.Validation.RecordCase.Core.Validation;
using PandyIT.HMS.Business.Logic;
using PandyIT.HMS.Business.Logic.Services;
using PandyIT.HMS.Data.Model;
using PandyIT.HMS.UI.MVCFrontEnd.DatabaseInitializers;
using Unity.Mvc5;

namespace PandyIT.HMS.UI.MVCFrontEnd
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            string connectionString = ConfigurationManager.ConnectionStrings["HmsDatabase"].ConnectionString;
            //var dbContext = new HmsContext(connectionString, new DropCreateHmsDbAlways());
            container.RegisterType<DbContext, HmsContext>(new PerThreadLifetimeManager(), new InjectionConstructor(connectionString, new DropCreateHmsDbAlways()));
            container.RegisterType<IUnitOfWork, UnitOfWork>(new PerThreadLifetimeManager());
            container.RegisterType<IValidationRulesEngine, ValidationRulesEngine>();
            container.RegisterType<IBusinessContext, BusinessContext>(new PerThreadLifetimeManager());
            container.RegisterType<IUserService, UserService>(new PerThreadLifetimeManager());
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}