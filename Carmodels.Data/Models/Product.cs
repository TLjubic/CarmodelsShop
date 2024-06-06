using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carmodels.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Sku { get; set; }
        public string? Name { get; set; }
        public int Stock { get; set; }
        public string? ImageUrl { get; set; }
        public double RegularPrice { get; set; }
        public double? SalePrice { get; set; }
        public string? Description { get; set; }

        public IEnumerable<ProductCategory>? ProductCategories { get; set; }
    }
}
