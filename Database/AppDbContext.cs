using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNet_Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_Assignment.Database
{
    public class AppDbContext: DbContext
    {
        public readonly DbContextOptions Options;
        public AppDbContext(DbContextOptions options):base(options)
        {
            Options = options;
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Equipment> Equipments { get; set; }

    }
}