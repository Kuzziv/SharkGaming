using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CpuAirCoolingPage3Model : PageModel
    {
        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public CpuAirCoolingPage3Model(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }

        public List<CPUAirCooling> cpuAirCoolings { get; set; }
        public List<ProductsClass> orderItemList { get; set; }

        public void OnGet()
        {
            cpuAirCoolings = _productService.GetCPUAirCooling();
        }

        public IActionResult OnPostAddToCart()
        {
            _orderService.AddToCart(8, 1, 619);
            return RedirectToPage("CasePage3");
        }
    }
}
