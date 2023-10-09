using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineJobPortal.Domain.Entities;


namespace OnlineJobPortal.Infrastructure.Configuration
{
    public class ResumeConfiguration : IEntityTypeConfiguration<Resume>
    {
        public void Configure(EntityTypeBuilder<Resume> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.CareerGoal)
                .HasMaxLength(500);

            builder.Property(p => p.Position)
                .HasMaxLength(100);

            builder.HasOne(p => p.Candidate)
                .WithMany(c => c.Resumes)
                .HasForeignKey(p => p.CandidateId)
                .IsRequired();

            builder.HasMany(p => p.CandidateSkills)
                .WithOne(cs => cs.Resume)
                .HasForeignKey(cs => cs.ResumeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.Educations)
                .WithOne(e => e.Resume)
                .HasForeignKey(e => e.ResumeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.Experiences)
                .WithOne(ex => ex.Resume)
                .HasForeignKey(ex => ex.ResumeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.ForeignLanguages)
                .WithOne(fl => fl.Resume)
                .HasForeignKey(fl => fl.ResumeId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
