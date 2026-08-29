namespace EF_Core_03.Models;
public class Service
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<CustomerService> ServiceCustomers { get; set; } = new HashSet<CustomerService>();
}
