using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using MVC.Web.Models;

namespace MVC.Web.Controllers
{
    public class FormController : Controller
    {
        [HttpGet] 
        public IActionResult FormExample()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FormExample1Post()
        {
            //1. Yol 
            string firstName = Request.Form["firstName"]!;
            string lastName = Request.Form["lastName"]!;
            string email = Request.Form["email"]!;
            //2. Yol 
            if (Request.Form.TryGetValue("firstName", out StringValues firstNameValues))
            {

            }
            //3. Yol 
            if (Request.Form.ContainsKey("firstName"))
            {
                string firstName2 = Request.Form["firstName"]!;
            }

            
           
            return View();
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateProduct(ProductCreateViewModel model)
        {
            
            return View();
        }
    }
}
