using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.Components.ComponentTypes.GPU;
using SharkGaming.Products.Components.ComponentTypes.Storage;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.ComponentInfoPages
{
    public class Mdot2Page1Model : PageModel
    {
        private IProductService _productService;

        public Mdot2Page1Model(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<Mdot2>? mdot2 { get; private set; }

        public void OnGet()
        {
            mdot2 = _productService.GetMdot2();
        }
    }
}
