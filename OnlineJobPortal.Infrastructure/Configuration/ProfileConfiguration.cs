using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineJobPortal.Domain.Entities;


namespace OnlineJobPortal.Infrastructure.Configuration
{
    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
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
                .WithMany(c => c.Profiles)
                .HasForeignKey(p => p.CandidateId)
                .IsRequired();

            builder.HasMany(p => p.CandidateSkills)
                .WithOne(cs => cs.Profile)
                .HasForeignKey(cs => cs.ProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.Educations)
                .WithOne(e => e.Profile)
                .HasForeignKey(e => e.ProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.Experiences)
                .WithOne(ex => ex.Profile)
                .HasForeignKey(ex => ex.ProfileId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(p => p.ForeignLanguages)
                .WithOne(fl => fl.Profile)
                .HasForeignKey(fl => fl.ProfileId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
