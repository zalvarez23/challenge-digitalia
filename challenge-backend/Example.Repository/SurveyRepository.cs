using Example.Domain.Entities;
using Example.Domain.Service;

namespace Example.Repository
{
    public class SurveyRepository : BaseRepository<Survey>, ISurveyRepository
    {
        public SurveyRepository(RegistrationSurveyContext context ) : base(context
            )
        {
        }
    }
}