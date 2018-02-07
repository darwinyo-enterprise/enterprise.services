using Enterprise.Constants.NetStandard;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise.Services.Interfaces
{
    public interface IAuthorizationService
    {
        Task<string> CreateAccessTokenAsync(string client, string secret, string apiScope);
    }
}
