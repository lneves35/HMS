using System.Web.Mvc;
using PandyIT.HMS.Business.Logic.Services;
using PandyIT.HMS.Data.Model.Entities;

namespace PandyIT.HMS.UI.MVCFrontEnd.Controllers
{
    public class UserController : Controller
    {
        public IUserService UserService { get; set; }

        public UserController(IUserService userService)
        {
            this.UserService = userService;
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Details(int userId)
        {
            var user = UserService.GetUserById(userId);
            return View(user);
        }

        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Add()
        {
            return View(new User());
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Add(User user)
        {
            return View();
        }
    }
}
