using bai_th_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace bai_th_2.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly HarmicContext _context;
        public BlogViewComponent(HarmicContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbBlogs.Where(m => (bool)m.IsActive).ToList();
            return await Task.FromResult<IViewComponentResult>(View(items));
        }

    }
}
