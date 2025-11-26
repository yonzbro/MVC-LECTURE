using Microsoft.AspNetCore.Mvc;
using MVCDERSLERİ_BTK_AKADEMİ_SAYFASI_.Models;
using System.ComponentModel.DataAnnotations;


namespace MVCDERSLERİ_BTK_AKADEMİ_SAYFASI_.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index1()
        {
            var model = Repository.Applications;
            return View(model);
        }
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Apply(Candidates model)
        {
            if (Repository.Applications.Any(c => c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("", "there is already application.");
            }
            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("FeedBack", model);
            }
            return View();
        }
    }
}
