using Enterprise.ConfigurationServer.DataLayers.ConfigurationDB;
using Enterprise.ConfigurationServer.DTO;
using Enterprise.Constants.NetStandard;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Services.Interfaces
{
    public interface IConfigurationService
    {
        Task<IEnumerable<AppsConfigurationDTO>> GetAllConfigurationDTOAsync(string accessToken, string mediaType = "application/json");

        Task<HttpResponseMessage> UpdateConfigurationAsync(string id, string value, string accessToken, string mediaType = "application/json");

        Task<IEnumerable<IntegratedApp>> GetAllURLConfigurationAsync(string accessToken, string mediaType = "application/json");

        Task<HttpResponseMessage> UpdateURLConfigurationAsync(string id, IntegratedApp integratedApp, string accessToken, string mediaType = "application/json");
    }
}
