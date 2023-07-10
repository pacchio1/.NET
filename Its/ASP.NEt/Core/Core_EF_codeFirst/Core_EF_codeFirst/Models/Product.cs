namespace Core_EF_codeFirst.Models
{
    public class product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string Description{ get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public virtual Category Category { get; set; }
    }
}
