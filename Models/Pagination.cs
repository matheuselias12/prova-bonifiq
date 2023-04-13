namespace ProvaPub.Models
{
    public class Pagination
    {
        public List<Product> Product { get; set; }
        public List<Customer> Customer { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }
    }
}
