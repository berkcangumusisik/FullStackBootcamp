using Microsoft.AspNetCore.Mvc;

namespace MVC.Web.Controllers
{
    public class RouterController : Controller
    {
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("{page}/{pageSize}")]
        public IActionResult Paging(int page, int pageSize)
        {
            ViewBag.page = page;
            ViewBag.pageSize = pageSize;

            return View();
        }
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            ViewBag.id = id;

            return View();
        }

        [Route("{productId}")]
        public IActionResult Get2(int productId)
        {
            ViewBag.id = productId;

            return View();
        }
    }
}
