using BWITCODE.DAL;
using BWITCODE.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BWITCODE.Repository
{
    public class Aboutrepository : IAboutRepository
    {
        private readonly AppDbContext _context;
        public Aboutrepository(AppDbContext context)
        {
            _context= context;
        }
        public async Task<About> GetFirst()
        {
            return await _context.Abouts.FirstOrDefaultAsync();
        }
    }
}