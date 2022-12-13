using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;
using SharkGaming.Products;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;
using SharkGaming.Products.Components.ComponentTypes.Cooling;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class CaseFanPage1Model : PageModel
    {

        private IProductService _productService;
        private IOrderRepositoryService _orderService;
        [BindProperty] public int productId { get; set; }
        [BindProperty] public int amount { get; set; }
        [BindProperty] public double price { get; set; }

        public CaseFanPage1Model(IProductService productService, IOrderRepositoryService orderService)
        {
            this._productService = productService;
            this._orderService = orderService;

        }
        public List<CaseFan> components { get; set; }
        public List<ProductsClass> orderItemList { get; set; }
        public List<Products.ProductsClass> Items { get; private set; } = new List<Products.ProductsClass>();

        public void OnGet()
        {
            components = _productService.GetCaseFan();
        }

        public void OnPost()
        {
            //_orderService.AddToOrderItems(orderItemList);

        }
        public IActionResult OnPostAddToCart()
        {
            components = _productService.GetCaseFan();
            _orderService.AddToCart(productId, 1,price);
            return Page();
        }
    }
}
