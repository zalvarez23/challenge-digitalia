using Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Nest;

namespace Example.Repository
{
    public class BaseRepository<T> : Domain.Service.IRepository<T> where T : class
    {
        private readonly RegistrationSurveyContext _context;

        public BaseRepository(RegistrationSurveyContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<SurveyDetail>> GetAllByIdAsync(int id)
        {
            return await _context.SurveyDetail
                .Where(sd => sd.SurveyId == id)
                .ToListAsync();

        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

    }
}