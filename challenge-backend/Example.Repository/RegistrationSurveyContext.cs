using Example.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Example.Repository
{
    public class RegistrationSurveyContext : DbContext
    {
        public RegistrationSurveyContext(DbContextOptions<RegistrationSurveyContext> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SurveyMap());
            modelBuilder.ApplyConfiguration(new SurveyDetailMap());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Survey>? Survey { get; set; }
        public DbSet<SurveyDetail>? SurveyDetail { get; set; }

    }
}
