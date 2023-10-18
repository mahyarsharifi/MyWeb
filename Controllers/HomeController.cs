using Microsoft.AspNetCore.Mvc;
using MyWeb.Models;
using System.Diagnostics;

namespace MyWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نمی باشد. لطفا دوباره تلاش کنید";
                return View(model);
            }

            if (ModelState.IsValid)
            {
                ViewBag.saccess = "پیفام شما با موفقیت ارسال شد";
            }

            ModelState.Clear();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}