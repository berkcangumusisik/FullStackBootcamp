using System.ComponentModel.DataAnnotations;

namespace MVC.Web.Models
{
    public record ProductCreateViewModel
    {

        [Display(Name = "Ürün Adı")]
        public string Name { get; set; } =default!;
        [DataType(DataType.Currency)]
        [Display(Name = "Ürün Fiyatı")]
        public decimal Price { get; set; }
        [Display(Name = "Ürün Açıklaması")]
        public string? Description { get; set; }
        [Display(Name = "Stok Sayısı")]
        public int StockCount { get; set; }
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Resim Url")]
        public string PictureUrl { get; set; } 

        
    }
}
