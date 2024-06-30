using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor.Web.Pages.Routing
{
    public class PagingModel : PageModel
    {
        public int PageCount { get; set; }
        public int PageSize { get; set; }
        public void OnGet(int pageCount, int pageSize  =10)
        {
            PageCount = pageCount;
            PageSize = pageSize;
        }

        //public Task OnGetAsync()
        //{
        //    return Task.CompletedTask;
        //}
        //public async Task<IActionResult> OnGetAsync(int page)
        //{
        //    var httpClient = new HttpClient();
        //    var  result = await httpClient.GetStringAsync("https://www.google.com");
        //    return Page();
        //}
    }
}
