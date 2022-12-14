using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Cooling;
using SharkGaming.Products;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CaseFanPage3Model : PageModel
    {
        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public CaseFanPage3Model(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }
        public List<CaseFan> caseFans { get; set; }
        public List<ProductsClass> orderItemList { get; set; }

        public void OnGet()
        {
            caseFans = _productService.GetCaseFan();
        }

        public IActionResult OnPostAddToCart()
        {
            _orderService.AddToCart(5, 1, 159);
            return RedirectToPage("CaseFanPage3");
        }
    }
}
