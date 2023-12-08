using bai_th_2.Models;
using Microsoft.AspNetCore.Mvc;
namespace bai_th_2.Areas.Admin.Components

{
    public class MenuViewComponent: ViewComponent

    {
        private readonly HarmicContext _context;
        public MenuViewComponent(HarmicContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.AdminMenus.Where(m => (bool)m.IsaActive).OrderBy(m => m.ItemOrder).ToList();
            return await Task.FromResult<IViewComponentResult>(View(items));
        }
    }
}
