using BWITCODE.Models.Base;
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

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // ChangeTracker : Entityler uzerinde edilen deyisikliklerin yada yeni elave edilen melumatin elde edilmesine imkan veren propertydir. Track edilen melumatlari tutub elde elemeyimize komek edir.

            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.Now,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.Now,
                    _ => DateTime.Now
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
