namespace OnlineStore.Data.Models
{
    public class CategoryDto
    {
        public CategoryDto()
        {
            this.ProductIds = new HashSet<int>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<int> ProductIds { get; set; }
    }
}
