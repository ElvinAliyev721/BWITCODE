using BWITCODE.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BWITCODE.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Work> Works { get; set; }
    }
}
