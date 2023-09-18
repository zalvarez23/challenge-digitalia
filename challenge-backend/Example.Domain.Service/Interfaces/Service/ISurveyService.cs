using Example.Domain.Entities;

namespace Example.Domain.Service
{
    public interface ISurveyService
    {
        Task<IEnumerable<Survey>> GetAllAsync();
        Task<Survey> GetByIdAsync(int id);
        Task CreateAsync(Survey entity);
        Task UpdateAsync(Survey entity);
    }
}
