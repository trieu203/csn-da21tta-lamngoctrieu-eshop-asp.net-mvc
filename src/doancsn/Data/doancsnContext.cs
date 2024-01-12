using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using doancsn.Models;

namespace doancsn.Data
{
    public class doancsnContext : DbContext
    {
        public doancsnContext (DbContextOptions<doancsnContext> options)
            : base(options)
        {
        }

        public DbSet<doancsn.Models.Category> Category { get; set; } = default!;

        public DbSet<doancsn.Models.Product>? Product { get; set; }

        public DbSet<doancsn.Models.User>? User { get; set; }

        public DbSet<doancsn.Models.Discount>? Discount { get; set; }
    }
}
