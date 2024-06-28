using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Week3.RazorPage.App.Pages
{
    public class IndexModel : PageModel
    {
        public ProductViewModel Product { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            ViewData["Title"] = "Product List";
            TempData["Message"] = "Welcome to the Product List";
            Product = new ProductViewModel
            {
                ID = 1,
                Name = "Product 1",
                Description = "Description for Product 1",
                Price = 100
            };
        }
    }
}
