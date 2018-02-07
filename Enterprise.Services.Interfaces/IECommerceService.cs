using Enterprise.E_Commerce.NetStandard.DataLayers.ECommerceDB;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Services.Interfaces
{
    public interface IECommerceService
    {
        Task<IEnumerable<Category>> GetAllCategoryAsync(string accessToken, string mediaType = "application/json");

        Task<Category> GetCategoryByIdAsync(Guid id, string accessToken, string mediaType = "application/json");

        Task<HttpResponseMessage> PostCategoryAsync(Category category, string accessToken, string mediaType = "application/json");

        Task<HttpResponseMessage> DeleteCategoryByIdAsync(Guid id, string accessToken, string mediaType = "application/json");

        Task<HttpResponseMessage> DeleteAllCategoryAsync(string accessToken, string mediaType = "application/json");

        Task<IEnumerable<Category>> GetAllSubCategoryAsync(string accessToken, string mediaType = "application/json");

        Task<Category> GetSubCategoryByIdAsync(Guid id, string accessToken, string mediaType = "application/json");

        Task<HttpResponseMessage> PostSubCategoryAsync(Category category, string accessToken, string mediaType = "application/json");

        Task<HttpResponseMessage> DeleteSubCategoryByIdAsync(Guid id, string accessToken, string mediaType = "application/json");

        Task<HttpResponseMessage> DeleteAllSubCategoryAsync(string accessToken, string mediaType = "application/json");
    }
}
