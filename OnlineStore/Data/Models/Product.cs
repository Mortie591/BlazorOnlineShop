using System.Text.Json.Serialization;

namespace OnlineStore.Data.Models
{
    public class Product
    {
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
        public int UnitInStock { get; set; }

        public bool Available
        {
            get
            {
                return this.Available;
            }
            private set
            {
                if (this.UnitInStock > 0)
                {
                    this.Available = true;
                }
                else
                {
                    this.Available = false;
                }
            }
        }

    

    }
}
