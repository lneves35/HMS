using System.Configuration;
using System.Data.Entity;
using System.Web.Mvc;
using PandyIT.Core.Database.Implementations;
using PandyIT.Core.Validation.RecordCase.Core.Validation;
using PandyIT.HMS.Business.Logic;
using PandyIT.HMS.Data.Entities;

namespace PandyIT.HMS.UI.MVCFrontEnd
{
    public abstract class BaseController : Controller

{
    protected BusinessContext Context { get; set; }

    protected BaseController()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HmsDatabase"].ConnectionString;
        var dbContext = new HmsContext(connectionString, new DropCreateDatabaseAlways<HmsContext>());
        var unitOfWork = new UnitOfWork(dbContext);
        var validationRulesEngine = new ValidationRulesEngine();
        Context = new BusinessContext(unitOfWork, validationRulesEngine);
    }
}
}