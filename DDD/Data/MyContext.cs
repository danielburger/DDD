using DutchTreat.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DDD.Data
{
    public class MyContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
