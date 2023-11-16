using OnlineJobPortal.Application.Interfaces.Repositories;
using OnlineJobPortal.Domain.Entities;
using OnlineJobPortal.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Infrastructure.Implementation.Repositories
{
    public class ConversationsRepository : GenericRepository<Conversations>, IConversationsRepository
    {
        public ConversationsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
