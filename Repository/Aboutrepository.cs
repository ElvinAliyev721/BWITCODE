using BWITCODE.DAL;
using BWITCODE.Models.Domain;

namespace BWITCODE.Repository
{
    public class Aboutrepository : IAboutRepository
    {
        private readonly AppDbContext _context;
        public Aboutrepository(AppDbContext context)
        {
            _context= context;
        }
        public About GetFirst()
        {
            return _context.Abouts.FirstOrDefault();
        }
    }
}
