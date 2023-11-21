using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Infrastructure.Configuration
{
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.SkillName)
                .IsRequired()
                .HasMaxLength(256);

            builder.HasMany(s => s.CandidateSkills)
                .WithOne(cs => cs.Skill)
                .HasForeignKey(cs => cs.SkillId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(s => s.RequirementSkills)
                .WithOne(rs => rs.Skill)
                .HasForeignKey(rs => rs.SkillId)
                .OnDelete(DeleteBehavior.Restrict);

            var itSkills = new List<string> {
                "Java", "C#", "Python", "JavaScript", "SQL", "HTML/CSS", "React", "Angular", "Node.js", "AWS", 
                "Docker", "Ruby", "Swift", "PHP", "Kotlin", "C++", "Spring Framework", ".NET", "ASP.NET", "Ruby on Rails", 
                "Git", "Linux", "Android Development", "iOS Development", "Machine Learning", "Data Science", 
                "Cybersecurity", "Networking", "Cloud Computing", "Big Data", "DevOps", "Agile/Scrum", "UI/UX Design", 
                "Blockchain", "IoT (Internet of Things)", "Game Development", "Front-end Development", "Back-end Development", 
                "Full-stack Development", "Database Management", "Cloud Architecture", "React Native", "Flutter", 
                "ASP.NET Core", "Vue.js", "TypeScript", "Ruby on Rails", "Express.js", "GraphQL", "Rust", "Scala", 
                "Objective-C", "Redux", "Node.js", "Nginx", "Apache", "Ruby on Rails", "DevOps", 
                "Continuous Integration/Continuous Deployment (CI/CD)", "Web Security", "Linux System Administration", 
                "Microsoft Azure", "Google Cloud Platform (GCP)", "Amazon Web Services (AWS)", "Unity3D", "WebAssembly", 
                "Embedded Systems", "AR/VR Development", "Natural Language Processing (NLP)", "Robotics", "TensorFlow", 
                "Vue.js", "Electron", "Hadoop", "Spark", "Red Hat Enterprise Linux", "SAS", "MATLAB", 
                "Adobe Creative Suite", "AutoCAD", "Blender", "SolidWorks", "Selenium", "Load Testing", 
                "Windows Server", "Objective-C", "Swift", "WatchOS", "tvOS", "ARKit", "CoreML", "Xamarin", 
                "Reactive Native", "WebAssembly", "SwiftUI", "Angular Material", "Google Material Design", 
                "Responsive Web Design", "Web Accessibility", "Performance Optimization", 
                "Content Management Systems (CMS)", "Joomla", "Drupal", "Adobe Experience Manager (AEM)", 
                "Sitecore", "Umbraco", "ERP Systems", "SAP", "Oracle E-Business Suite", "Microsoft Dynamics", 
                "CRM Systems", "Salesforce", "HubSpot", "Marketo", "Eloqua", "Email Marketing", "Marketing Automation", 
                "Google Analytics", "Google Ads", "Facebook Ads", "LinkedIn Ads", "Twitter Ads", "Social Media Marketing", 
                "Content Marketing", "Search Engine Optimization (SEO)", "Search Engine Marketing (SEM)", 
                "Pay-Per-Click (PPC)", "Affiliate Marketing", "Influencer Marketing", 
                "Conversion Rate Optimization (CRO)", "Copywriting", "Video Production", 
                "Podcast Production", "Public Relations (PR)", "Event Marketing", "Trade Show Management", 
                "Market Research", "Competitive Analysis", "Market Segmentation", "Product Launch", 
                "Brand Strategy", "Brand Management", "Crisis Management", "Customer Relationship Management (CRM)", 
                "Customer Success", "Customer Support", "Customer Feedback Analysis"
            };

            var skillEntities = new List<Skill>();
            int id = 1;

            foreach (var skillName in itSkills)
            {
                skillEntities.Add(new Skill { Id = id, SkillName = skillName, CreateAt = DateTime.Now, UpdateAt = DateTime.Now });
                id++;
            }

            builder.HasData(skillEntities);
        }

    }
}
