using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineJobPortal.Application.Interfaces;
using OnlineJobPortal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Futures.ResumeFeatures.Commands
{
    public class UpdateResumeSkillCommand : IRequest<List<Skill>?>
    {
        public int ResumeId { get; set; }
        public List<int> SkillList { get;} = new List<int>();
        public UpdateResumeSkillCommand(int resumeId, List<int> skillList)
        {
            ResumeId = resumeId;
            SkillList = skillList;
        }
    }
    public class UpdateResumeSkillCommandHandler : IRequestHandler<UpdateResumeSkillCommand, List<Skill>?>
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;

        public UpdateResumeSkillCommandHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<Skill>?> Handle(UpdateResumeSkillCommand request, CancellationToken cancellationToken)
        {
            unitOfWork.BeginTransaction();
            try
            {
                var resume = await unitOfWork.Repository<Resume>().GetAll
                    .Include(r => r.CandidateSkills)
                    .FirstOrDefaultAsync(r => r.Id.Equals(request.ResumeId));

                resume!.CandidateSkills.Clear();
                foreach (var skillId in request.SkillList)
                {
                    var candidateSkill = new CandidateSkill();
                    candidateSkill.SkillId = skillId;
                    candidateSkill.ResumeId = request.ResumeId;
                    resume.CandidateSkills.Add(candidateSkill);
                }

                await unitOfWork.Repository<Resume>().UpdateAsync(resume);

                var result = new List<Skill>();
                foreach (var candidatSkill in resume.CandidateSkills)
                {
                    var skill = await unitOfWork.Repository<Skill>().GetByIdAsync(candidatSkill.SkillId);
                    result.Add(skill);
                }
                unitOfWork.Commit();
                return result;
            }
            catch
            {
                unitOfWork.Rollback();
                return null;
            }
            
        }
    }
}
