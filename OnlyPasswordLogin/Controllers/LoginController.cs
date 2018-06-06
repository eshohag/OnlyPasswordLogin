using OnlyPasswordLogin.Models;
using System.Linq;
using System.Web.Mvc;

namespace OnlyPasswordLogin.Controllers
{
    public class LoginController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginModel aLoginModel)
        {
            var encryptPassword = CryptoEngine.Encrypt(aLoginModel.Password);
            var success = db.Registers.FirstOrDefault(a => a.Password.Equals(encryptPassword));
            if (success != null)
            {
                TempData.Clear();
                TempData["Password"] = encryptPassword;
                return RedirectToAction("Index", "Success");
            }

            ViewBag.Message = "Doesn't Match your Password!";
            return View();
        }
    }
}