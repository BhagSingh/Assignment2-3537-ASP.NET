using Assignment2_3534.Models;
using Assignment2_3534.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment2_3534.Pages
{
    public class ProductListModel : PageModel
    {
        //Adding the public property of type"JSonFileProductService":
        public JsonFileProductService ProductService;

        public IEnumerable<Product> Products { get; private set; } =
            default!;

        public ProductListModel(JsonFileProductService productService)
        {
            ProductService = productService;
        }
        public void OnGet()
        {
            //Finally
            Products = ProductService.GetProducts();
        }
    }
}
