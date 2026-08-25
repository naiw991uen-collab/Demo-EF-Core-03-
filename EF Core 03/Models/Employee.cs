namespace EF_Core_03.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public Car Car { get; set; } = default!;

        public Employee? Manager { get; set; }
        public int? ManagerId { get; set; }
    }
}
