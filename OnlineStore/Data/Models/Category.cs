using System.Text.Json.Serialization;

namespace OnlineStore.Data.Models
{
    public class Category
    {
        public Category()
        {
            this.CategoryProducts = new HashSet<Product>();
        }

        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("categoryName")]
        public string Name { get; set; }
        public IEnumerable<Product> CategoryProducts { get; set; }
    }
}
