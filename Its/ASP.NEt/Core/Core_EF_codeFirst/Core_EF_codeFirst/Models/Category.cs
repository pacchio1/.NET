namespace Core_EF_codeFirst.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<product> Products { get; set; }
        public Category()
        {
            Products = new HashSet<product>();
        }
    }
}
