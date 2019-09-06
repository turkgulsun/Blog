using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blog.WebUI.Areas.Admin.Controllers
{
    //[Route("Home")]
    public class HomeController : Controller
    {
        private IClassService _classesService;

        public HomeController(IClassService classesService)
        {   
            _classesService = classesService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}