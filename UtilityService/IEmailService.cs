using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ctrlspec.Data;
using ctrlspec.Models;
using Microsoft.EntityFrameworkCore;

namespace ctrlspec.UtilityService
{
    public interface IEmailService
    {
            void SendEmail(EmailModel emailModel);
            
    }
}