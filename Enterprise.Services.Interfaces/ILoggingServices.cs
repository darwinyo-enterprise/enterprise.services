using Enterprise.LoggingServer.DataLayers.Mongo;
using Enterprise.Models.NetStandard;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Enterprise.Interfaces.NetStandard.Services
{
    public interface ILoggingServices
    {
        Task<HttpResponseMessage> DeleteAuditLogByIDAsync(string Id, string accessToken, string mediaType = "application/json");
        Task<HttpResponseMessage> DeleteDebugLogByIDAsync(string Id, string accessToken, string mediaType = "application/json");
        Task<HttpResponseMessage> DeleteErrorLogByIDAsync(string Id, string accessToken, string mediaType = "application/json");

        Task<HttpResponseMessage> DeleteAllAuditLogAsync(string accessToken, string mediaType = "application/json");
        Task<HttpResponseMessage> DeleteAllDebugLogAsync(string accessToken, string mediaType = "application/json");
        Task<HttpResponseMessage> DeleteAllErrorLogAsync(string accessToken, string mediaType = "application/json");

        Task<IEnumerable<ErrorLog>> GetAllErrorLogByDateAsync(DateTime dateTime, string accessToken, string mediaType = "application/json");
        Task<IEnumerable<AuditLog>> GetAllAuditLogByDateAsync(DateTime dateTime, string accessToken, string mediaType = "application/json");
        Task<IEnumerable<DebugLog>> GetAllDebugLogByDateAsync(DateTime dateTime, string accessToken, string mediaType = "application/json");

        Task<IEnumerable<AuditLog>> GetAllAuditLogAsync(string accessToken, string mediaType = "application/json");
        Task<IEnumerable<DebugLog>> GetAllDebugLogAsync(string accessToken, string mediaType = "application/json");
        Task<IEnumerable<ErrorLog>> GetAllErrorLogAsync(string accessToken, string mediaType = "application/json");

        Task<AuditLog> GetAuditLogByIDAsync(string Id, string accessToken, string mediaType = "application/json");
        Task<DebugLog> GetDebugLogByIDAsync(string Id, string accessToken, string mediaType = "application/json");
        Task<ErrorLog> GetErrorLogByIDAsync(string Id, string accessToken, string mediaType = "application/json");

        Task LogAsync(LogModel logModel, string mediaType = "application/json", bool? IsDevMode = null);
    }
}
