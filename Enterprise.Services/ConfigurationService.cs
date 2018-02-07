using Enterprise.ConfigurationServer.DataLayers.ConfigurationDB;
using Enterprise.ConfigurationServer.DTO;
using Enterprise.Extension.NetStandard;
using Enterprise.Helpers.NetStandard;
using Enterprise.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Services
{
    public class ConfigurationService : IConfigurationService
    {
        private HttpClient httpClient;

        /// <summary>
        /// Used For Get All Configuration.
        /// </summary>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public async Task<IEnumerable<AppsConfigurationDTO>> GetAllConfigurationDTOAsync(string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.GetAllConfigurationAsync(accessToken, mediaType).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<AppsConfigurationDTO>>(response);
        }
        /// <summary>
        /// Update Single Configuration.
        /// </summary>
        /// <param name="Id">
        /// GUID Key.
        /// </param>
        /// <param name="value">
        /// Value For Update.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public async Task<HttpResponseMessage> UpdateConfigurationAsync(string id, string value, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.UpdateConfigurationAsync(id, value, accessToken, mediaType);
            return response;
        }
        /// <summary>
        /// Used For Get All URL Configuration.
        /// </summary>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public async Task<IEnumerable<IntegratedApp>> GetAllURLConfigurationAsync(string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.GetAllURLConfigurationAsync(accessToken, mediaType).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<IntegratedApp>>(response);
        }

        /// <summary>
        /// Used For Update Single URL Configuration.
        /// </summary>
        /// <param name="Id">
        /// GUID Key.
        /// </param>
        /// <param name="integratedApp">
        /// Object For Update.
        /// </param>
        /// <param name="accessToken">
        /// Access token used for authentication.
        /// </param>
        /// <param name="mediaType">
        /// MIME Type are you going to post/get. => application/json (mostly...)
        /// </param>
        /// <param name="urls">
        /// Target URL => https://www.darwin.com/
        /// </param>
        /// <returns>
        /// Http Response.
        /// </returns>
        public async Task<HttpResponseMessage> UpdateURLConfigurationAsync(string id, IntegratedApp integratedApp, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.UpdateURLConfigurationAsync(id, integratedApp, accessToken, mediaType);
            return response;
        }
    }
}
