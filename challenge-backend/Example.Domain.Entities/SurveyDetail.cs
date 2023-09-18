using System.Text.Json.Serialization;

namespace Example.Domain.Entities
{
    public class SurveyDetail
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public string SurveyQuestion { get; set; }
        public int QuestionScore { get; set; }
        public DateTime DateSurveryDetail { get; set; }

        [JsonIgnore]
        public Survey Survey { get; set; }
    }
}
