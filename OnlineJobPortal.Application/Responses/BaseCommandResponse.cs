using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Responses
{
    public class BaseCommandResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

    }
}
