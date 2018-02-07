using Enterprise.Models.NetStandard.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Services.Interfaces
{
    public interface IEmailServices
    {
        Task ConfirmationRegistrationSendEmailAsync(ConfirmationRegistrationEmailModel confirmationRegistrationEmailModel);
        Task SendEmailAsync(string email, string subject, string message);
    }
}
