using Example.Domain.Entities;

namespace Example.Domain.Service
{
    public interface ISurveyDetailService
    {
        Task<IEnumerable<SurveyDetail>> GetAllAsync();
        Task<IEnumerable<SurveyDetail>> GetAllByIdAsync(int id);
        Task CreateAsync(SurveyDetail entity);
        Task UpdateAsync(SurveyDetail entity);
    }
}
