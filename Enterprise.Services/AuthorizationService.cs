using Enterprise.Helpers.NetStandard;
using Enterprise.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        /// <summary>
        /// Used For Grant ClientCredential Type.
        /// </summary>
        /// <param name="client">
        /// Client ID Used for Authorization
        /// </param>
        /// <param name="apiScope">
        /// Defined Scopes that Allowed for Client
        /// </param>
        /// <param name="secret">
        /// Client Secrets
        /// </param>
        /// <param name="urls">
        /// URLS Class that for Dynamics URLs
        /// </param>
        public async Task<string> CreateAccessTokenAsync(string client, string secret, string apiScope)
        {
            var httpClientHelper = new HttpClientHelper(client, secret, apiScope);

            string accessToken = await httpClientHelper.GetAccessTokenClientCredentialAsync();

            return accessToken;
        }
    }
}
