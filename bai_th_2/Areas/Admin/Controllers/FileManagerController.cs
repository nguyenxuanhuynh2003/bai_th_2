﻿using Microsoft.AspNetCore.Mvc;

namespace bai_th_2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("/Admin/file-manager")]
    public class FileManagerController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
