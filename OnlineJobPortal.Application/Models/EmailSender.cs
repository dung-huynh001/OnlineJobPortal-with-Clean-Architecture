using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Models
{
    public class EmailSender
    {
        private string smtpServer;
        private int smtpPort;
        private string smtpUsername;
        private string smtpPassword;

        public EmailSender(string smtpServer, int smtpPort, string smtpUsername, string smtpPassword)
        {
            this.smtpPassword = smtpPassword;
            this.smtpServer = smtpServer;
            this.smtpPort = smtpPort;
            this.smtpUsername = smtpUsername;
        }
    }
}
