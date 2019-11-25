using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Blog.Business.Abstract;
using Blog.Entities.Concrete;
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
        private IClassLanguageService _classLanguageService;
        private GeneralFunctions _generalFunctions;
        private IHostingEnvironment _env;

        public ClassController(IClassService classService, IClassLanguageService classLanguageService,  IHostingEnvironment env)
        {
            _classService = classService;
            _classLanguageService = classLanguageService;
           // _generalFunctions = generalFunctions;
            _env = env;

        }

        //[Route("index/{id?}/{classTypeId?}/{classId?}")]
        public ActionResult Index(int? id, int? classId, int? classTypeId)
        {
            int _classTypeId = 0;

            //Sınıf tipini viewbaga atayalım.
            if (classTypeId != null)
                _classTypeId = Convert.ToInt32(classTypeId);
            else
                _classTypeId = Convert.ToInt32(id);

            if (classId != null)
                ViewBag.ClassId = classId;
            else
                classId = 0;

            ViewBag.ClassTypeID = _classTypeId;

            var classes = _classService.GetAll();
            var classLanguage = _classLanguageService.GetAll();

            var model = (from c in classes
                         join cL in classLanguage on c.Id equals cL.Id
                         where c.ClassTypeId == _classTypeId && c.ParentId == classId
                         //&& (classId == null || c.ParentID == classId)
                         select new ClassListVM
                         {
                             Id = c.Id,
                             Name = cL.Title,
                             Summary = cL.Summary,
                             CreationDate = c.CreationDate,
                             Active = c.Active,
                             ClassTypeID = c.ClassTypeId

                         }).ToList();
            return View(model);
        }

        [Route("create/{id?}/{classId?}")]
        public ActionResult Create(int id, int? classId)
        {
            var model = new ClassVM
            {
                ClassEntity = new ClassEntity(),
                ClassLanguage = new ClassLanguage()
            };

            if (classId != null)
                model.ClassEntity.ParentId = Convert.ToInt32(classId);


            model.ClassEntity.ClassTypeId = id;
            model.ClassEntity.Sort = 1;
            model.ClassEntity.Active = true;

            return View(model);
        }

        [HttpPost]
        [Route("create/{id?}/{classId?}")]
        public async Task<IActionResult> Create(FormCollection collection, ClassEntity classEntity, ClassLanguage classLanguage, List<IFormFile> uploadfile)
        {
            try
            {
                //Validation kontrolü yapalım.
                if (!ModelState.IsValid)
                {
                    var model = new ClassVM
                    {
                        ClassEntity = classEntity,
                        ClassLanguage = classLanguage
                    };

                    return View("Create", model);
                }
                classEntity.CreationDate = DateTime.Now;

                if (uploadfile != null)
                    classEntity.Image = uploadfile.FirstOrDefault().FileName;
                else
                    classEntity.Image = null;

                //Sınıf kayıt edelim.
                _classService.Add(classEntity);

                //Dönen sınıf Id'yi alalım.
                int classID = classEntity.Id;


                //Sınıf resmini kayıt edelim.
                if (classEntity.Image != null && uploadfile != null)
                {

                    var filePath = Path.Combine(_env.ContentRootPath, "Uploads/Class/");
                    _generalFunctions.CreateDirectory(filePath, classID.ToString());
                    //uploadfile.SaveAs(filePath + classID + "/" + uploadfile.FileName);

                    foreach (var formFile in uploadfile)
                    {
                        if (formFile.Length > 0)
                        {
                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                await formFile.CopyToAsync(stream);
                            }
                        }
                    }
                }

                //Sınıf bilgilerini kayıt edelim.
                classLanguage.ClassId = classID;
                classLanguage.LanguageId = 1;
                _classLanguageService.Add(classLanguage);

                TempData.Add("message", "Sınıf başarıyla eklendi.");

                return RedirectToAction("Index", "Classes", new { @id = classEntity.ClassTypeId });
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}