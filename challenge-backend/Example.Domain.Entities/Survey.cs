namespace Example.Domain.Entities
{
    public class Survey
    {
        public int Id { get; set; }
        public string? SurveyTitle { get; set; }
        public int SurveyStatus{ get; set; }
        public DateTime SurveyDate { get; set; }
        public ICollection<SurveyDetail> SurveyDetails { get; set; }
    }
}
