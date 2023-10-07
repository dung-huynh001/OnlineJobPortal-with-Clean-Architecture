using OnlineJobPortal.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Contracts.Infastructure
{
    public interface IEmailSender
    {
        Task SendEmailAsync(EmailSender email);
    }
}
