using Carmodels.Data.Models;

namespace Carmodels.Web.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string? Sku { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public IFormFile? ImageUrl { get; set; }
        public double RegularPrice { get; set; }
        public double? SalePrice { get; set; }
        public string? Description { get; set; }

        public IEnumerable<ProductCategory>? ProductCategories { get; set; }
    }
}
