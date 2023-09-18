using Example.Domain.Entities;

namespace Example.Domain.Service
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Survey> SurveyRepository { get; }
        IRepository<SurveyDetail> SurveyDetailRepository { get; }
        Task SaveChangesAsync();
    }
}
