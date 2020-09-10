using Microsoft.EntityFrameworkCore;
using System;

namespace HelensPieShop.Infrastructure
{
    public class PieContext: DbContext
    {
        public DbSet<Pie> Pies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PiesDb.db");
    }
}
