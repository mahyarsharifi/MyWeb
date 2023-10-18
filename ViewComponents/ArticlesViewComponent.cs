using Microsoft.AspNetCore.Mvc;
using MyWeb.Models;

namespace MyWeb.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>()
            {
                new Article(1,"اموزش کامل Aap.Net Core","کاملترین اموزش Asp.Net Core","blog-post-thumb-1.jpg"),
                new Article(2,"اموزش کامل Php","کاملترین اموزش Php","blog-post-thumb-2.jpg"),
                new Article(3,"اموزش کامل طراحی سایت","کاملترین اموزش طراحی سایت","blog-post-thumb-3.jpg"),
                new Article(4,"اموزش کامل دیتا بیس","کاملترین اموزش دیتا بیس","blog-post-thumb-4.jpg"),
            };
            return View("_Articles", articles);
        }
    }
}
