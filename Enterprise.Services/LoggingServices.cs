using Enterprise.Interfaces.NetStandard.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Enterprise.Models.NetStandard;
using Enterprise.Extension.NetStandard;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Enterprise.LoggingServer.DataLayers.Mongo;
using Enterprise.Helpers.NetStandard;
using Enterprise.Constants.NetStandard.LoggingServer;

namespace Enterprise.Services
{
    public class LoggingServices : ILoggingServices
    {
        private HttpClient httpClient;

        public async Task<HttpResponseMessage> DeleteAuditLogByIDAsync(string Id, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            return await httpClient.DeleteLoggingByIDAsync(Id, ControllerUrls.AuditLog_URL, accessToken, mediaType);
        }
        public async Task<HttpResponseMessage> DeleteDebugLogByIDAsync(string Id, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            return await httpClient.DeleteLoggingByIDAsync(Id, ControllerUrls.DebugLog_URL, accessToken, mediaType);
        }
        public async Task<HttpResponseMessage> DeleteErrorLogByIDAsync(string Id, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            return await httpClient.DeleteLoggingByIDAsync(Id, ControllerUrls.ErrorLog_URL, accessToken, mediaType);
        }

        public async Task<HttpResponseMessage> DeleteAllAuditLogAsync(string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            return await httpClient.DeleteLoggingAllAsync(ControllerUrls.AuditLog_URL, accessToken, mediaType);
        }
        public async Task<HttpResponseMessage> DeleteAllDebugLogAsync(string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            return await httpClient.DeleteLoggingAllAsync(ControllerUrls.DebugLog_URL, accessToken, mediaType);
        }
        public async Task<HttpResponseMessage> DeleteAllErrorLogAsync(string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            return await httpClient.DeleteLoggingAllAsync(ControllerUrls.ErrorLog_URL, accessToken, mediaType);
        }

        public async Task<IEnumerable<AuditLog>> GetAllAuditLogAsync(string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.GetAllLoggingAsync(ControllerUrls.AuditLog_URL, accessToken, mediaType).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<AuditLog>>(response);
        }
        public async Task<IEnumerable<AuditLog>> GetAllAuditLogByDateAsync(DateTime dateTime, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var xyz = await httpClient.GetListLoggingByDateAsync(dateTime, ControllerUrls.AuditLog_URL, accessToken, mediaType);
            var response = await xyz.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<AuditLog>>(response);
        }
        public async Task<IEnumerable<DebugLog>> GetAllDebugLogAsync(string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.GetAllLoggingAsync(ControllerUrls.DebugLog_URL, accessToken, mediaType).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<DebugLog>>(response);
        }

        public async Task<IEnumerable<DebugLog>> GetAllDebugLogByDateAsync(DateTime dateTime, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.GetListLoggingByDateAsync(dateTime, ControllerUrls.DebugLog_URL, accessToken, mediaType).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<DebugLog>>(response);
        }
        public async Task<IEnumerable<ErrorLog>> GetAllErrorLogAsync(string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.GetAllLoggingAsync(ControllerUrls.ErrorLog_URL, accessToken, mediaType).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<ErrorLog>>(response);
        }
        public async Task<IEnumerable<ErrorLog>> GetAllErrorLogByDateAsync(DateTime dateTime, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.GetListLoggingByDateAsync(dateTime, ControllerUrls.ErrorLog_URL, accessToken, mediaType).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<IEnumerable<ErrorLog>>(response);
        }

        public async Task<AuditLog> GetAuditLogByIDAsync(string Id, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.GetLoggingByIdAsync(Id, ControllerUrls.AuditLog_URL, accessToken, mediaType).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<AuditLog>(response);
        }
        public async Task<DebugLog> GetDebugLogByIDAsync(string Id, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.GetLoggingByIdAsync(Id, ControllerUrls.DebugLog_URL, accessToken, mediaType).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DebugLog>(response);
        }
        public async Task<ErrorLog> GetErrorLogByIDAsync(string Id, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.GetLoggingByIdAsync(Id, ControllerUrls.ErrorLog_URL, accessToken, mediaType).Result.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<ErrorLog>(response);
        }
        
        public async Task LogAsync(LogModel logModel, string mediaType = "application/json", bool? IsDevMode = null)
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            await httpClient.PostLoggingAsync(logModel, mediaType, IsDevMode);
        }
    }
}
