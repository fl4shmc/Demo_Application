using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApplication.Entities.Context
{
    class DemoContextFactory : IDesignTimeDbContextFactory<DemoContext>
    {
        public DemoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DemoContext>();
            var connectionString = "Data Source=DESKTOP-5ANGV4H;initial catalog=DemoDB;Integrated Security=True;MultipleActiveResultSets=True";
            optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("DemoApplication.Entities"));
            return new DemoContext(optionsBuilder.Options);
        }
    }
}
