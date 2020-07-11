using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using ContosoCrafts.Models;
using Microsoft.AspNetCore.Hosting;

namespace ContosoCrafts.WebSite.Services
{
    public class JsonFileProductService
    {
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            // Web Host service is given the the JSONFileName Service
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            // returns the path of the "products.json" file froom root directory (wwwroot)
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); }
        }

        // Lists are derived from the IEnumerable<> class, which allows foreach-loop to be used
        // Returns a list of Products as a string
        public IEnumerable<Product> GetProducts()
        {
            // Retrieves the products from the JSON file
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                // Deserialize: Convert JSON(text file) to string (extract data)
                return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        // Optional Property - JSON file is read with case insensitive
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        // AddRating
        public void AddRating(string productId, int rating)
        {
            // Get list of products
            var products = GetProducts();

            //LINQ
            // Find first matched product in list
            var query = products.First(x => x.Id == productId);

            // Case 1: Product in Json file doesn't have rating
            if(query.Ratings == null)
            {
                query.Ratings = new int[] { rating };
            }
            // Case 2: Product already has rating list
            else
            {
                // convert ratings to list
                var ratings = query.Ratings.ToList();
                // Add rating to list
                ratings.Add(rating);
                // set new list to the product
                query.Ratings = ratings.ToArray();
            }

            // Serialize the updated ratings (product)
            using (var outputStream = File.Open(JsonFileName, FileMode.Create, FileAccess.Write))
            {
                JsonSerializer.Serialize<IEnumerable<Product>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    products
                );
            }


        }
    }
}