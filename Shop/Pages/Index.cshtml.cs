using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.ProductsAdmin;
using Shop.Database;
using Shop.Application.Products;
using System.Threading.Tasks;
using static Shop.Application.Products.CreateProduct;

namespace Shop.Pages
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _ctx;
        public IndexModel(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [BindProperty]
        public ProductViewModel Product { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            await new CreateProduct(_ctx).Do(Product);

            return RedirectToPage("Index");
        }

    }
}
