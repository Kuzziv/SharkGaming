using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.CPU;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class GpuPage1Model : PageModel
    {
        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public GpuPage1Model(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }
        public List<GPU>? gpus { get; private set; }

        public void OnGet()
        {
            gpus = _productService.GetGPUs();
        }
        public IActionResult OnPostAddToCart()
        {
            _orderService.AddToCart(15, 1, 13799.45);
            return RedirectToPage("GpuPage1");
        }
    }
}
