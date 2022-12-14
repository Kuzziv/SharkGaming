using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.PreBuilds;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.PrebuildInfoPages
{
    public class Prebuild1InfoPageModel : PageModel
    {
        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public Prebuild1InfoPageModel(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }
        public List<PreBuildsClass>? preBuilds { get; private set; }


        public void OnGet()
        {
            preBuilds = _productService.GetPreBuilds();
        }

        public IActionResult OnPostAddToCart()
        {

            _orderService.AddToCart(33, 1, 25999);
            return RedirectToPage("Prebuild1InfoPage");

        }
    }
}
