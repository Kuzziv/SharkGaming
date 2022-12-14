using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.RAM;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class RamPage2Model : PageModel
    {
        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public RamPage2Model(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }
        public List<RAM>? rams { get; private set; }

        public void OnGet()
        {
            rams = _productService.GetRAM();
        }

        public IActionResult OnPostAddToCart()
        {

            _orderService.AddToCart(25, 1, 1177);
            return RedirectToPage("RamPage2");

        }
    }
}
