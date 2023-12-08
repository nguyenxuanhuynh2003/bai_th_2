using bai_th_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bai_th_2.Areas.Admin.Controllers
{
    public class MenuController : Controller
    {
     
        private readonly HarmicContext _context;
        public MenuController(HarmicContext context)
        {
            _context = context;
        }
        [Area("Admin")]

        public IActionResult Index()
        {
            var MNlisst = _context.TbMenus.OrderByDescending(i => i.MenuId).ToList();
         
            return View(MNlisst);
        }
    }
}
