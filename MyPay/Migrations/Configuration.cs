namespace MyPay.Migrations
{
    using MyPay.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyPay.Context.MyPayContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MyPay.Context.MyPayContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Designation.AddOrUpdate(
                d => d.Code,
                new Designation { Code = "MGR", Name = "Manager", Description = "Manager" },
                new Designation { Code = "SUP", Name = "Supervisor", Description = "Supervisor" },
                new Designation { Code = "STF", Name = "Staff", Description = "Staff" }
                );
            context.Department.AddOrUpdate(
                d => d.Code,
                new Department { Code = "MGMT", Name = "Management", Description = "Management department" },
                new Department { Code = "ACCT", Name = "Accounts", Description = "Accounts department" },
                new Department { Code = "SALES", Name = "Sales", Description = "Sales department" }
                );
        }
    }
}