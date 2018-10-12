namespace AssignmentFirst.Migrations
{
    using AssignmentFirst.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AssignmentFirst.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AssignmentFirst.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Sales.AddOrUpdate(X => X.Id,
                new Models.Sale() { Id = 1, Date = DateTime.Now, Customer = new Models.Customer(), Employee = new Models.Employee() });

            context.Customers.AddOrUpdate(X => X.Id,
                    new Models.Customer() { Id = 1, Name ="Customer", Email ="Customer@email.com"});
            context.StoreLocations.AddOrUpdate(X => X.Id,
                   new Models.StoreLocation() { Id = 1, LocationName ="LocationName"});
            context.Products.AddOrUpdate(X => X.Id,
                   new Models.Product() { Id = 1, Name ="Product", Price = 892.5, Quantity = 2});
            context.SaveChanges();
        }
        }
    }

