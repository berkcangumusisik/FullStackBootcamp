using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor.Web.Pages.DataTransfer
{
    public class IndexModel : PageModel
    {
        public int Number { get; set; }
        public List<int> Numbers { get; set; } =default!;
        public void OnGet()
        {
            Numbers = new List<int>() { 1, 2, 3, 4, 5 };
            Number = 10;
        }
        public void OnPost(){}
    }
}

//OnGet metodu, sayfa yüklendiðinde çalýþan metoddur. Bu metot içerisinde veri taþýma iþlemleri yapýlabilir.
// OnPost metodu, sayfada bir form submit edildiðinde çalýþan metoddur. Bu metot içerisinde formdan gelen verileri alabilir ve iþleyebiliriz.