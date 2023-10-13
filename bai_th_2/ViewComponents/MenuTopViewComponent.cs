using bai_th_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace bai_th_2.Components
{
    public class MenuTopViewComponent : ViewComponent
    {
        
            private readonly HarmicContext _context;

            public MenuTopViewComponent(HarmicContext context)
            {
                _context = context;
            }

            public async Task<IViewComponentResult> InvokeAsync()
            {
                var items = _context.TbMenus.Where(m => (bool)m.IsActive).OrderBy(m => m.Position).ToList();
                return await Task.FromResult<IViewComponentResult>(View(items));
            }
    }
}
