using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

// Index.cshtml.cs is a friend of the index.cshtml page

namespace ContosoCrafts.Pages
{
    public class IndexModel : PageModel
    {
        // Properties
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService ProductService;
        // Create a list of Products
        public IEnumerable<Product> Products { get; private set; }

        // Constructor
        // Arguments: Expose services to ASP.nET
        // Argument 1: ILogger<IndexModel> - logger service (log to a file or Azure)
        // (e.g you don't create a logger, but pass as argument)
        // Argument 2: Pass JsonFileProduct Service to IndexModel constructor
        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {
            // Assign services to indexmodel properties
            _logger = logger;
            ProductService = productService;
        }


        // onGet corresponds to GET HTTP
        // onPost corresponds to POST HTTP
        public void OnGet()
        {
            // Get List of Products from ProductService
            Products = ProductService.GetProducts();
        }
    }
}
