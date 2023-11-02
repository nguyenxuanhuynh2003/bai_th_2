using bai_th_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace bai_th_2.Controllers
{
    public class BlogController : Controller
    {

        private readonly HarmicContext _context;
        public BlogController(HarmicContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var blogs = _context.TbBlogs.Where(i => (bool)i.IsActive).OrderByDescending(i => i.BlogId).ToList();
            if (blogs == null)
                return NotFound();
            ViewBag.blogComment = _context.TbBlogComments.Where(m => m.IsActive).ToList();
            return View(blogs);
        }

        [Route("/blog/{alias}-{id}.html")]
        public IActionResult Details(int? id)
        {
            if (id == null)
                return NotFound();
            var blog = _context.TbBlogs.Where(i => i.BlogId == id && (bool)i.IsActive).FirstOrDefault();
            if (blog == null)
                return NotFound();
            ViewBag.blogComment = _context.TbBlogComments.Where(i => i.BlogId == id && i.IsActive).ToList();
            return View(blog);
        }
    }
}
