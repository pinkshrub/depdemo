using Microsoft.EntityFrameworkCore;

namespace logdemo.Models{
    public class logdemoContext : DbContext
    {
        public logdemoContext(DbContextOptions<logdemoContext> options) : base(options){ }

        public DbSet<User> Peeps { get; set; }
    }
}