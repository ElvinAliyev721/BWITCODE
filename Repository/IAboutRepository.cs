using BWITCODE.Models.Domain;

namespace BWITCODE.Repository
{
    public interface IAboutRepository
    {
        public Task<About> GetFirst();
    }
}
