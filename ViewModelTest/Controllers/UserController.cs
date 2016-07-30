using System.Web.Mvc;
using ViewModelTest.Models.ViewModels;

namespace ViewModelTest.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModels pageData)
        {
            if (pageData.Account == "cash"
                && pageData.Password == "1234")
            {
                pageData.Msg = $"你使用{pageData.Account}登入成功";
            }
            else
            {
                pageData.Msg = "登入失敗";
            }

            return View(pageData);
        }
    }
}