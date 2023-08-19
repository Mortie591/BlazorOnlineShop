using System.Text.Json.Serialization;

namespace OnlineStore.Data.Models
{
    public class Product
    {
        private bool isAvailable;
        private int unitsInStock;

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("categoryId")]
        public int CategoryId { get; set; }

        [JsonPropertyName("image")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("unitInStock")]
        public int UnitInStock
        {
            get { return unitsInStock; }
            set
            {
                unitsInStock = value;
                isAvailable = value > 0 ? true : false;
            }
        }

        public bool Available
        {
            get
            {
                return isAvailable;
            }
        }
    }
}
