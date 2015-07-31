using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using PandyIT.Core.Database.Implementations;
using PandyIT.HMS.Data.Entities;
using PandyIT.HMS.Data.Entities.Entities;

namespace PandyIT.HMS.UI.MVCFrontEnd
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            //Setup DatabaseAccess
            string connectionString = ConfigurationManager.ConnectionStrings["HmsDatabase"].ConnectionString;
            var dbContext = new HmsContext(connectionString, new DropCreateDatabaseAlways<HmsContext>());
            var unitOfWork = new UnitOfWork(dbContext);
            unitOfWork.GetRepository<User>().Create(new User(){ FirstName = "Luis"});
        }
    }
}