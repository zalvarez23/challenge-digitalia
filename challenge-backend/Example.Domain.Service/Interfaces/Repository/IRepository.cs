using Example.Domain.Entities;

namespace Example.Domain.Service
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<SurveyDetail>> GetAllByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
    }
}