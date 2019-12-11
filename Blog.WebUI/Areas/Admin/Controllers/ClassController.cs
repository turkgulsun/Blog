using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Blog.Business.Abstract;
using Blog.WebUI.Areas.Admin.Functions;
using Blog.WebUI.Areas.Admin.Models.ClassViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WebUI.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ClassController : Controller
    {
        private IClassService _classService;
        private IHostingEnvironment _env;

        public ClassController(IClassService classService, IHostingEnvironment env)
        {
            _classService = classService;
            _env = env;

        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(IFormCollection collection, ClassVM classVM, List<IFormFile> uploadfile)
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}