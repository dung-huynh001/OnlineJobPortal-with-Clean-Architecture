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
                .IsRequired(false)
                .HasMaxLength(256);

            builder.Property(p => p.CvUrl)
                .IsRequired(false)
                .HasMaxLength(256);

            builder.Property(p => p.YearOfExperiences)
                .IsRequired(false)
                .HasMaxLength(256);

            builder.Property(p => p.CareerGoal)
                .HasColumnType("ntext")
                .IsRequired(false);

            builder.Property(p => p.Position)
                .HasMaxLength(256)
                .IsRequired(false);


            builder.HasOne(r => r.Candidate)
                .WithOne(c => c.Resume)
                .HasForeignKey<Resume>(r => r.CandidateId)
                .OnDelete(DeleteBehavior.Cascade);


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
