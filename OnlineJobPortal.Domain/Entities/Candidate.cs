﻿using OnlineJobPortal.Domain.Common;
using OnlineJobPortal.Domain.Enums;

namespace OnlineJobPortal.Domain.Entities
{
    public class Candidate : BaseEntity
    {
        public string FullName { get; set; }
        public string NationalId { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string AvatarUrl { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int ResumeId { get; set; }
        public Resume? Resume { get; set; }
        public ICollection<Apply>? Applies { get; set; }
        public ICollection<JobFavorite>? JobFavorites { get; set; }
        public ICollection<Message>? Messages { get; set; }
        public ICollection<SaveCandidate>? SaveCandidates { get; set; }
    }
}
