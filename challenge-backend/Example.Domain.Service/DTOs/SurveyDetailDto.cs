using Example.Domain.Entities;

namespace Example.Domain.Service
{
    public class SurveyDetailDto
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public string SurveyQuestion { get; set; }
        public int QuestionScore { get; set; }
        public DateTime DateSurveryDetail { get; set; } = DateTime.Now;
    }
}
