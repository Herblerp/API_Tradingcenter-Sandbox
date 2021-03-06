using API_Tradingcenter.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Tradingcenter.Database
{
    public class DatabaseContext : DbContext
    {
       public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options){} 

       public DbSet<Value> Values {get; set;}
       public DbSet<User> Users {get; set;}
       public DbSet<Order> Orders {get; set;}
    }
}