using EF_Core_03.Contexts;
using EF_Core_03.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_03
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            // AppDbContext dbContext = new AppDbContext();
            //var customer = dbContext.Customers.FirstOrDefault();

            //dbContext.Entry(customer).Property("UpdatedAt").CurrentValue = DateTime.Now;

            //var value = dbContext.Entry(customer).Property("UpdatedAt").CurrentValue;

            #region CRUD Operations
            //using AppDbContext dbContext = new AppDbContext();

            //var customer = new Customer()
            //{
            //    Name = "Nasr",
            //    Address = new Address()
            //    {
            //        City = "Giza",
            //        Country = "Egypt",
            //        Street = "Street 1"
            //    }
            //};

            //Console.WriteLine(dbContext.Entry(customer).State);

            //dbContext.Customers.AddRange(customer); // Add Local
            //dbContext.Add(customer); // Add Local
            //dbContext.Set<Customer>().Add(customer); // Add Local
            //dbContext.Entry(customer).State = EntityState.Added; // Add Local

            //Console.WriteLine(dbContext.Entry(customer).State);

            //dbContext.SaveChanges();

            //Console.WriteLine(dbContext.Entry(customer).State);

            //var customers = dbContext.Customers.ToList();
            //var customers = dbContext.Customers.Where(c => c.Id == 1);
            //var customers = dbContext.Customers.FirstOrDefault(c => c.Id == 1);
            //var customers = dbContext.Customers.Find(1);
            //var customers = dbContext.Customers.Load;
            //var customers = dbContext.Customers.AsNoTracking().FirstOrDefault(c => c.Id == 1);


            //Console.WriteLine(customers.Id);

            //foreach (var customer in customers) 
            //{
            //    Console.WriteLine(customer.Id);
            //    Console.WriteLine(customer.Name);
            //}

            //var customers = dbContext.Customers.FirstOrDefault(c => c.Id == 1);
            //Console.WriteLine(dbContext.Entry(customers).State);
            //Console.WriteLine(customers.Id);
            //Console.WriteLine(dbContext.Entry(customers).State);
            //customers.Name = "Zead";
            //dbContext.Update(customers);
            //Console.WriteLine(dbContext.Entry(customers).State);
            //dbContext.SaveChanges();
            //Console.WriteLine(dbContext.Entry(customers).State);

            //dbContext.Remove(customers);
            //dbContext.SaveChanges();

            //var result = await dbContext.Customers.Where(x => x.Id >= 1)
                                            //.ExecuteUpdateAsync(c => c.SetProperty(c => c.Name, "Malek"));

            //Console.WriteLine(result);

            #endregion


        }
    }
}
