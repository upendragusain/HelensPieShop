using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Principal;

namespace HelensPieShop.Infrastructure
{
    public class PieContext: DbContext
    {
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PiesDb.db");
    }
}
