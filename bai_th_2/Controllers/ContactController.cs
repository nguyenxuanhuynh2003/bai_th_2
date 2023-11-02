using Microsoft.AspNetCore.Mvc;

namespace bai_th_2.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
