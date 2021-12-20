using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using Form.Models;
using System;
using System.Text;
using System.Linq;
using Form.Data;
using Microsoft.AspNetCore.Localization;
using Form.Extensions;

namespace Form.Controllers
{
    public class HomeController : Controller
    {
        private readonly FormDbContext _db;

        public HomeController(FormDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public FileContentResult Index(FormModel model)
        {
            _db.Forms.Add(model);
            _db.SaveChanges();
            var json = JsonConvert.SerializeObject(model);
            return File(Encoding.UTF8.GetBytes(json), "text/json", "Form.json");
        }
        [HttpGet]
        public IActionResult Report()
        {
            var reportURL = ".\\Files\\GDPR.pdf";
            var fileBytes = System.IO.File.ReadAllBytes(reportURL);
            return File(fileBytes, "application/pdf");
        }
        [HttpPost]
        public IActionResult SetLanguage(ChangeLanguageModel model)
        {
            var lang = model.ToShort();
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName, CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(lang)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(30) });
            return RedirectToAction("Index");
        }
    }
}