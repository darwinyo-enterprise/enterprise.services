using Enterprise.E_Commerce.NetStandard.DataLayers.ECommerceDB;
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
    public class ECommerceService : IECommerceService
    {
        private HttpClient httpClient;

        public async Task<IEnumerable<Category>> GetAllCategoryAsync(string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.GetAllCategoryAsync(accessToken, mediaType);
            return JsonConvert.DeserializeObject<IEnumerable<Category>>(response.Content.ReadAsStringAsync().Result);
        }

        public async Task<Category> GetCategoryByIdAsync(Guid id, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.GetCategoryByIdAsync(id, accessToken, mediaType);
            return JsonConvert.DeserializeObject<Category>(response.Content.ReadAsStringAsync().Result);
        }

        public async Task<HttpResponseMessage> DeleteAllCategoryAsync(string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            return await httpClient.DeleteAllCategoryAsync(accessToken, mediaType);
        }

        public async Task<HttpResponseMessage> DeleteCategoryByIdAsync(Guid id, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            return await httpClient.DeleteCategoryByIDAsync(id, accessToken, mediaType);
        }

        public async Task<HttpResponseMessage> PostCategoryAsync(Category category, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            return await httpClient.PostCategoryAsync(category, accessToken, mediaType);
        }

        public async Task<IEnumerable<Category>> GetAllSubCategoryAsync(string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.GetAllSubCategoryAsync(accessToken, mediaType);
            return JsonConvert.DeserializeObject<IEnumerable<Category>>(response.Content.ReadAsStringAsync().Result);
        }

        public async Task<Category> GetSubCategoryByIdAsync(Guid id, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            var response = await httpClient.GetSubCategoryByIdAsync(id, accessToken, mediaType);
            return JsonConvert.DeserializeObject<Category>(response.Content.ReadAsStringAsync().Result);
        }

        public async Task<HttpResponseMessage> DeleteAllSubCategoryAsync(string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            return await httpClient.DeleteAllSubCategoryAsync(accessToken, mediaType);
        }

        public async Task<HttpResponseMessage> DeleteSubCategoryByIdAsync(Guid id, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            return await httpClient.DeleteSubCategoryByIDAsync(id, accessToken, mediaType);
        }

        public async Task<HttpResponseMessage> PostSubCategoryAsync(Category category, string accessToken, string mediaType = "application/json")
        {
            httpClient = HttpClientHelper.CreateHttpClient();
            return await httpClient.PostSubCategoryAsync(category, accessToken, mediaType);
        }
    }
}
