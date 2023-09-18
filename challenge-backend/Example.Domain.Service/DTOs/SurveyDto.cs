using Example.Domain.Entities;

namespace Example.Domain.Service
{
    public class SurveyDto
    {
        public int Id { get; set; }
        public string? SurveyTitle { get; set; }
        public int SurveyStatus { get; set; }
        public DateTime SurveyDate { get; set; } = DateTime.Now;
        public ICollection<SurveyDetailDto> SurveyDetails { get; set; }
    }
}
