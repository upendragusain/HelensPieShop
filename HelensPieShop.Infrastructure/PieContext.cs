using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Principal;

namespace HelensPieShop.Infrastructure
{
    public class PieContext: IdentityDbContext<IdentityUser>
    {
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        public PieContext(DbContextOptions<PieContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PiesDb.db");
    }
}
