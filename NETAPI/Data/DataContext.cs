using Microsoft.EntityFrameworkCore;
using NETAPI.Models;

namespace NETAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<Value> Values { get; set; }
    }
}