using Microsoft.EntityFrameworkCore;
using storeroom_web_netcore.Models;

namespace storeroom_web_netcore.Data
{
    public class StoreroomDbContext : DbContext
    {
        public StoreroomDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Storeroom> Storerooms { get; set; }
    }
}