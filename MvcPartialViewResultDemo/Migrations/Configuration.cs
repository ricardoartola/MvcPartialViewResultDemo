namespace MvcPartialViewResultDemo.Migrations
{
    using MvcPartialViewResultDemo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcPartialViewResultDemo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcPartialViewResultDemo.Models.ApplicationDbContext context)
        {
            var permanentAddress1 = new Address() { City = "Montreal", DoorNumber = "1" };
            var presentAddress1 = new Address() { City = "Ottawa", DoorNumber = "2" };
            context.Addresses.AddOrUpdate(permanentAddress1, presentAddress1);

            var customer = new Customer()
            {
                Name = "Customer 1",
                PermanentAdress = permanentAddress1,
                PresentAdress = presentAddress1
            };
            context.Customers.AddOrUpdate(customer);
            context.SaveChanges();
        }
    }
}
