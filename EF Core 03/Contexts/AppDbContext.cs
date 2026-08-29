using EF_Core_03.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_03.Contexts
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EFCoreDemo04;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().ToTable("Employees").HasKey(t => t.EmployeeId);
            modelBuilder.Entity<Car>().HasOne(c => c.Employee).WithOne(e => e.Car).HasForeignKey<Car>(c => c.EmployeeId);

            //modelBuilder.Entity<Customer>()
            //            .HasMany(c => c.Services)
            //            .WithMany(s => s.Customers)
            //            .UsingEntity(ETP =>
            //            {
            //                ETP.ToTable("CustomerService");
            //                ETP.Property<DateTime>("CreatedAdd").HasDefaultValueSql("GETDATE()");
            //            });

            modelBuilder.Entity<CustomerService>()
                        .HasOne(cs => cs.Customer)
                        .WithMany(c => c.CustomerServices)
                        .HasForeignKey(cs => cs.CustomerId);

            modelBuilder.Entity<CustomerService>()
                       .HasOne(cs => cs.Service)
                       .WithMany(c => c.ServiceCustomers)
                       .HasForeignKey(cs => cs.ServiceId);

            modelBuilder.Entity<CustomerService>().HasKey(cs => new { cs.ServiceId, cs.CustomerId });

            modelBuilder.Entity<Employee>()
                        .HasOne(e => e.Manager)
                        .WithMany()
                        .HasForeignKey(e => e.ManagerId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Customer>(E =>
            {
                E.Property<DateTime>("CreatedAt").HasDefaultValueSql("GETDATE()");
                E.Property<DateTime>("UpdatedAt").HasDefaultValueSql("GETDATE()");
                E.Property<DateTime>("CreatedBy");
                E.Property<DateTime>("LastModifiedBy");
            });

            modelBuilder.Entity<Customer>().OwnsOne(c => c.Address, AB =>
            {
                AB.Property(a => a.City).HasColumnName("City").HasColumnType("varchar").HasMaxLength(50);
                AB.Property(a => a.Street).HasColumnName("Street").HasColumnType("varchar").HasMaxLength(50);
                AB.Property(a => a.Country).HasColumnName("Country").HasColumnType("varchar").HasMaxLength(50);
            });


        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
