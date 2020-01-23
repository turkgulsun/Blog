using Blog.Business.Abstract;
using Blog.WebUI.Areas.Admin.Models.ClassTypeViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.WebUI.Areas.Admin.ViewComponents
{

    public class ClassTypeListViewComponent : ViewComponent
    {
        private readonly IClassTypeService _classTypeService;

        public ClassTypeListViewComponent(IClassTypeService classTypeService)
        {
            _classTypeService = classTypeService;
        }

        public ViewViewComponentResult Invoke()
        {

            var classTypeService = _classTypeService.GetAll();
            var model = (from cT in classTypeService
                         select new ClassTypeListVM
                         {
                             Id = cT.Id,
                             Type = cT.Type
                         }).ToList();

            return View(model);
        }
    }
}
