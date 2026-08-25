using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_03.Models;

[Table("Employees")]
public class Car
{
    [Key]
    [ForeignKey(nameof(Employee))]
    public int EmployeeId { get; set; }
    public int CarId { get; set; }
    public string Model { get; set; } = string.Empty;
    public Employee Employee { get; set; } = default!;
}
