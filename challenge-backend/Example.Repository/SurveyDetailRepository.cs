using Example.Domain.Entities;
using Example.Domain.Service;

namespace Example.Repository
{
    public class SurveyDetailRepository : BaseRepository<SurveyDetail>, ITSurveyDetailRepository
    {
        public SurveyDetailRepository(RegistrationSurveyContext context) : base(context)
        {
        }
    }
}