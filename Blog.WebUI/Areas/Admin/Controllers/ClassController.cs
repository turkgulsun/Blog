using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Blog.Business.Abstract;
using Blog.Business.DTOs;
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
        private readonly IClassService _classService;
        private readonly IHostingEnvironment _environment;
        private readonly IMapper _mapper;

        public ClassController(IClassService classService, IMapper mapper, IHostingEnvironment environment)
        {
            _classService = classService;
            _environment = environment;
            _mapper = mapper;

        }

        [Route("class/index/{id}/{classTypeId}")]
        public ActionResult Index(int id,int classTypeId)
        {
            try
            {
                var classService = _classService.GetAll().Where(x => x.ClassTypeId == classTypeId);
                var model = (from c in classService
                             select new ClassListVM
                             {
                                 Id = c.Id,
                                 ClassTypeId = c.ClassTypeId,
                                 Title = c.Title,
                                 Summary = c.Summary,
                                 CreationDate = c.CreationDate,
                                 Active = c.Active

                             }).ToList();
                return View(model);
            }
            catch (Exception ex)
            {

                return View();
            }
        }

        [Route("class/create")]
        public ActionResult Create()
        {
            var model = new ClassCreateVM();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClassCreateVM classVM, IFormFile uploadfile)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var model = new ClassCreateVM();
                    return View(model);
                }

                string combineFileName = null;
                if (uploadfile != null)
                {
                    string fileName = Guid.NewGuid().ToString();
                    string fileType = System.IO.Path.GetExtension(uploadfile.FileName);
                    combineFileName = fileName + fileType;
                    classVM.Image = combineFileName;

                    using (var localFile = System.IO.File.OpenWrite("Uploads/Class/" + combineFileName))
                    using (var uploadedFile = uploadfile.OpenReadStream())
                    {
                        uploadedFile.CopyTo(localFile);
                    }
                }

                ClassDTO classDTO = _mapper.Map<ClassDTO>(classVM);
                _classService.Add(classDTO);

                TempData["Statu"] = "ok";
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        [Route("class/edit/{id}")]
        public ActionResult Edit(int id)
        {
            try
            {
                var query = _classService.GetById(id);
                ClassEditVM classEditVM = _mapper.Map<ClassEditVM>(query);
                return View(classEditVM);
            }
            catch (Exception)
            {

                return View();
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("class/edit/{id}")]
        public ActionResult Edit(ClassEditVM classEditVM, IFormFile uploadfile)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    var model = new ClassEditVM();
                    return View(model);
                }


                //Yeni image var mı?
                string combineFileName = null;
                if (uploadfile != null)
                {
                    //Önceki resmi silelim.
                    if (System.IO.File.Exists("Uploads/Class/" + classEditVM.Image))
                        System.IO.File.Delete("Uploads/Class/" + classEditVM.Image);

                    string fileName = Guid.NewGuid().ToString();
                    string fileType = System.IO.Path.GetExtension(uploadfile.FileName);
                    combineFileName = fileName + fileType;
                    classEditVM.Image = combineFileName;

                    using (var localFile = System.IO.File.OpenWrite("Uploads/Class/" + combineFileName))
                    using (var uploadedFile = uploadfile.OpenReadStream())
                    {
                        uploadedFile.CopyTo(localFile);
                    }
                }

                ClassDTO classDTO = _mapper.Map<ClassDTO>(classEditVM);
                _classService.Update(classDTO);

                TempData["Statu"] = "ok";
                return RedirectToAction("index");
            }
            catch (Exception)
            {
                return View();
                throw;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("class/delete")]
        public ActionResult Delete(List<int> ids)
        {

            try
            {
                foreach (var id in ids)
                {
                    ClassDTO classDTO = new ClassDTO();
                    classDTO.Id = id;
                    _classService.Delete(classDTO);
                }
            }
            catch (Exception)
            {

                throw;
            }

            TempData["Statu"] = "ok";
            return RedirectToAction("index");
        }
    }
}