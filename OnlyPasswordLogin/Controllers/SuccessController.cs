using OnlyPasswordLogin.Models;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace OnlyPasswordLogin.Controllers
{
    public class SuccessController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Success
        public ActionResult Index()
        {
            string id = TempData["Password"].ToString();
            TempData.Clear();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Register register = db.Registers.FirstOrDefault(a => a.Password.Equals(id));
            if (register == null)
            {
                return HttpNotFound();
            }
            return View(register);
        }
    }
}