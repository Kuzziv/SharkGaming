using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharkGaming.Order;
using SharkGaming.OrderFile;
using SharkGaming.Products;
using SharkGaming.Services.CustomerServiceFile;
using SharkGaming.Services.OrderRepositoryServiceFile;
using SharkGaming.Services.ProductServiceFile;
using SharkGaming.Users.Customer;
using System.Collections.Generic;

namespace SharkGaming.Pages.OrderInfoPages
{
    public class CustomerDetailsPageModel : PageModel
    {

        private CustomerService _customerService;
        private OrderRepositoryService _orderRepositoryService;
        private ProductService _productService;

        [BindProperty]
        public int Phone { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Address { get; set; }

        [BindProperty]
        public int Postcode { get; set; }

        [BindProperty]
        public string Country { get; set; }

        public List<OrderItemsClass> _orderItems { get; set; }
        public List<ProductsClass> _allProducts { get; set; }


        public CustomerDetailsPageModel(CustomerService customerService, OrderRepositoryService orderRepositoryService, ProductService productService)
        {
            _customerService = customerService;
            _orderRepositoryService = orderRepositoryService;
            _productService = productService;

        }


        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _orderRepositoryService.CreateOrder(new CustomerClass(Phone, Email, Address, Postcode, Country));
            
            return RedirectToPage("");
        }
    }
}

