using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Products.PreBuilds;
using SharkGaming.Services.ProductServiceFile;

namespace SharkGaming.Pages.ProductInfoPages.PrebuildInfoPages
{
    public class Prebuild3InfoPageModel : PageModel
    {
        private IProductService _productService;

        public Prebuild3InfoPageModel(IProductService iproductervice)
        {
            _productService = iproductervice;
        }
        public List<PreBuildsClass>? components { get; private set; }


        public void OnGet()
        {
            components = _productService.GetPreBuilds();
        }
    }
}