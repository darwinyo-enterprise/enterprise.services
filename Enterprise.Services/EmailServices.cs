using System;
using System.Collections.Generic;
using System.Text;
using Enterprise.Models.NetStandard.Email;
using System.Threading.Tasks;
using System.Net.Http;
using Enterprise.Services.Interfaces;
using Enterprise.Helpers.NetStandard;

namespace Enterprise.Services
{
    public class EmailServices : IEmailServices
    {
        HttpClient httpClient;
        public EmailServices()
        {
            httpClient = HttpClientHelper.CreateHttpClient();
        }
        public async Task ConfirmationRegistrationSendEmailAsync(ConfirmationRegistrationEmailModel confirmationRegistrationEmailModel)
        {
            //await httpClient.PostConfirmationRegistrationSendEmailAsync(confirmationRegistrationEmailModel);
        }
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }
    }
}
