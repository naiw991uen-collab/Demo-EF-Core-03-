using Microsoft.EntityFrameworkCore;

namespace EF_Core_03.Models;

[PrimaryKey(nameof(CustomerId), nameof(ServiceId))]
public class CustomerService
{
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = default!;
    public int ServiceId { get; set; }
    public Service Service { get; set; } = default!;

    public int Rate { get; set; }
}
