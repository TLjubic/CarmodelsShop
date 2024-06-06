using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carmodels.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int TaxonomyId { get; set; }
        public virtual Taxonomy? Taxonomy { get; set; }

        public IEnumerable<ProductCategory>? ProductCategories { get; set; }
    }
}
