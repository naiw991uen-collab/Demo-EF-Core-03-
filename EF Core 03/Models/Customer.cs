namespace EF_Core_03.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Address Address { get; set; } = default!;
        public ICollection<CustomerService> CustomerServices { get; set; } = new HashSet<CustomerService>();



    }
}
