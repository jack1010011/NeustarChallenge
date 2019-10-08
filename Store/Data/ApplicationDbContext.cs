using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Store.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        
        public DbSet<ItemsList> ItemsList { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DBTest;Trusted_Connection=True;User ID=sa;Password=3389;MultipleActiveResultSets=true");
        }

    }
}
