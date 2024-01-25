using System.Web.Mvc;
using ElevatedWebRole.Models;

namespace ElevatedWebRole.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() => View(new ViewModel());
    }
}