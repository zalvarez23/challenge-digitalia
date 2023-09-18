using Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Example.Repository
{
    public class SurveyMap : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey> builder)
        {
            builder.ToTable("Survey");
            builder.HasKey(c => c.Id);
            builder.Property(c=>c.Id).ValueGeneratedOnAdd();

            builder.Property(c=>c.SurveyTitle).HasMaxLength(250).IsRequired();
            builder.Property(c => c.SurveyStatus).HasMaxLength(100).IsRequired();
            builder.Property(c=>c.SurveyDate).IsRequired();
        }
    }
}
