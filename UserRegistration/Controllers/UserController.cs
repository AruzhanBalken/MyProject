using Microsoft.VisualBasic.ApplicationServices;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity.Infrastructure;
namespace UserRegistration.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult AddOrEdit(int id=0)
        {
            User userModel = new User();
            return View(userModel);
        }

        [HttpPost]
        public ActionResult AddOrEdit(User userModel)
        {
/*            using (DBmodel dbModel = new DBmodel())
            {
                if (dbModel.Users.Any(x => x.Name == userModel.Name))
                {
                    ViewBag.DuplicateMessage = "Username already exist.";
                    return View("AddOrEdit", userModel);
                }

                dbModel.Users.Add(userModel);
                dbModel.SaveChanges();
            }*/
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful.";
            return View("AddOrEdit", new User());
        }
	}
}