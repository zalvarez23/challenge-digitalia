using Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Example.Repository
{
    public class SurveyDetailMap : IEntityTypeConfiguration<SurveyDetail>
    {
        public void Configure(EntityTypeBuilder<SurveyDetail> builder)
        {
            builder.ToTable("SurveyDetail");
            builder.HasKey(c=>c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c=>c.SurveyId).HasMaxLength(10).IsRequired();
            builder.Property(c => c.SurveyQuestion).HasMaxLength(250).IsRequired();
            builder.Property(c => c.QuestionScore).HasMaxLength(10).IsRequired();
            builder.Property(c => c.DateSurveryDetail).IsRequired();

            builder.HasOne(d => d.Survey)
                .WithMany(p => p.SurveyDetails)
                .HasForeignKey(d => d.SurveyId);
        }
    }
}
