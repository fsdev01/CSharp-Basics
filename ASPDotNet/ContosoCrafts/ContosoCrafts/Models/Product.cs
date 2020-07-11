using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContosoCrafts.Models
{
    public class Product
    {
        public string Id { get; set; }

        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        public string URL { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int[] Ratings { get; set; }

        public Product()
        {
            

        }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Product>(this);
        }
    }
}
