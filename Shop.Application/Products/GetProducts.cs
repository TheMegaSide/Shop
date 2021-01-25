using Shop.Database;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Application.GetProducts
{
    public class GetProducts
    {
        private ApplicationDbContext _ctx;

        public GetProducts(ApplicationDbContext ctx)
        {
            _ctx = ctx; 
        }

        public IEnumerable<ProductViewModel> Do()
        {
            return _ctx.Products.ToList().Select(x => new ProductViewModel
            {
                Name=x.Name,
                Description = x.Description,
                Value = x.Value,
            });
        }
    }
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
    }
}
