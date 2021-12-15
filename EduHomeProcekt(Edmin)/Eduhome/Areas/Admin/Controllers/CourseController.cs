using Eduhome.EduHomeDbContext;
using Eduhome.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly EduHomeDb _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public CourseController(EduHomeDb context,IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.Courses.OrderByDescending(o => o.Id).Include(c => c.CourseCategory).Include(tb => tb.TagToCourses).ThenInclude(t => t.Tag).ToList());
        }
        public IActionResult Create()
        {
            ViewBag.Catagory = _context.CourseCategories.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course model)
        {

            //return Content(model.ImageFile.FileName + "-" + model.ImageFile.ContentType + "-" + model.ImageFile.Length);

            if (ModelState.IsValid)
            {
                if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                {
                    if (model.ImageFile.Length<=2097152)
                    {
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + model.ImageFile.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath,"Uploads",fileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }

                        model.Image = fileName;

                        _context.Courses.Add(model);
                        _context.SaveChanges();



                        if (model.TagToCoursesId !=null && model.TagToCoursesId.Count>0)
                        {
                            foreach (var item in model.TagToCoursesId)
                            {
                                TagToCourse tagToCourse = new TagToCourse();
                                tagToCourse.TagId = item;
                                tagToCourse.CourseId = model.Id;
                                _context.TagToCourses.Add(tagToCourse);
                                _context.SaveChanges();
                            }
                        }
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can  upload only less than 2mb length");
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "You can  upload only .jpeg, .jpg and .png");
                    return View(model);
                }
            }


            //ViewBag.Catagory = _context.CourseCategories.ToList();
            return View(model);
        }
    }
}
