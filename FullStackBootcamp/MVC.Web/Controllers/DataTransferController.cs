using Microsoft.AspNetCore.Mvc;
using MVC.Web.Models;

namespace MVC.Web.Controllers
{
    public class DataTransferController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var name = "ahmet";

            var names = new List<string>() { "ahmet", "mehmet", "hasan", "ayşe" };

            ViewData["name"] = name;
            ViewData["nameList"] = names;


            var number = 10;

            var numbers = new List<int>() { 1, 2, 3, 4, 5 };


            ViewBag.number = number;

            ViewBag.numberList = numbers;
            ;
            //pullModel

            var pageModel = new IndexPageViewModel
            {
                Name = name,
                Names = names,
                Number = number,
                Numbers = numbers
            };

            //ViewData
            //ViewBag
            //TempData
            //Model
            return View(pageModel);
        }
    }
}

/*
ViewData : 
- Key - value ikilileri tutar.
- Controller'dan View'e veri taşımak için kullanılır.
- ViewData["key"] = value şeklinde kullanılır.

ViewBag :
- ViewData'nın dynamic versiyonudur.
- ViewData'dan farkı, ViewData'da key'ler string iken ViewBag'da property'lerdir.
- ViewBag.key = value şeklinde kullanılır.

TempData :
- TempData, Controller'dan View'e ya da View'dan Controller'a veri taşımak için kullanılır.
- TempData, ViewData ve ViewBag'dan farklı olarak bir kere okunduktan sonra silinir.
- TempData["key"] = value şeklinde kullanılır.
- TempData["key"] = value; TempData.Peek("key"); şeklinde kullanılır.

Model :
- Model, Controller'dan View'e veri taşımak için kullanılır.

 */