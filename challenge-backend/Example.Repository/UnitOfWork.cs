using Example.Domain.Entities;
using Example.Domain.Service;

namespace Example.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RegistrationSurveyContext _context;
        private readonly Domain.Service.IRepository<Survey> _surveyRepository;
        private readonly Domain.Service.IRepository<SurveyDetail> _surveyDetailRepository;

        public UnitOfWork(RegistrationSurveyContext context)
        {
            _context = context;
        }

        public Domain.Service.IRepository<Survey> SurveyRepository =>
            _surveyRepository ?? new BaseRepository<Survey>(_context);

        public Domain.Service.IRepository<SurveyDetail> SurveyDetailRepository =>
            _surveyDetailRepository ?? new BaseRepository<SurveyDetail>(_context);

        public void Dispose()
        {
            if (_context != null)
                _context.Dispose();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}