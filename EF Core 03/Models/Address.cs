using Microsoft.EntityFrameworkCore;

namespace EF_Core_03.Models
{
    [Owned]
    public class Address
    {
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}
