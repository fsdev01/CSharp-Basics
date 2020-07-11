using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContosoCrafts.Controllers
{
    // Route is /products
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public JsonFileProductService ProductService { get; }

        // Factory will make a controller - Design Pattern
        public ProductsController(JsonFileProductService productService)
        {
            this.ProductService = productService;
        }

        // get method - return list of products
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

        //[HttpPatch] "[FromBody]"
        [Route("Rate")] // subroute - products/rate
        [HttpGet]
        // FromQuery ?ProductId=abc&rating=5
        public ActionResult Get([FromQuery] string ProductId, [FromQuery] int Rating)
        {
            // Call AddRating Service from JsonFileProductService
            ProductService.AddRating(ProductId, Rating);
            return Ok(); // Return HTTP 200 Status Code
        }
    }
}
