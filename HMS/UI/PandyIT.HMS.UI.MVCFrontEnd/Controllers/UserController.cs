using System.Security.AccessControl;
using System.Web.Mvc;
using PandyIT.HMS.Business.Logic.Services;
using PandyIT.HMS.Data.Model.Entities;

namespace PandyIT.HMS.UI.MVCFrontEnd.Controllers
{
    public class UserController : Controller
    {
        public IUserService UserService { get; set; }
        public IGenericDataService GenericDataService { get; set; }

        public UserController(IUserService userService, IGenericDataService genericDataService)
        {
            this.UserService = userService;
            this.GenericDataService = genericDataService;
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Details(int userId)
        {
            var user = UserService.GetUserById(userId);
            
            if (user == null)
            {
                return this.HttpNotFound();
            }

            return View(user);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Edit(int userId)
        {
            var user = UserService.GetUserById(userId);

            if (user == null)
            {
                return this.HttpNotFound();
            }

            ViewBag.UserTypes = new SelectList(GenericDataService.GetUserTypes(), "UserTypeId", "Name", user.UserTypeId);

            return View(user);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Save(User user)
        {
            if (user == null)
            {
                return this.HttpNotFound();
            }

            //Save user
            //UserService.

            return View("Details", user);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
