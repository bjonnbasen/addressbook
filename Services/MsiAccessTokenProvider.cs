using System.Threading.Tasks;
using Microsoft.Azure.Services.AppAuthentication;

namespace addressBook.Services
{


    public class MsiAccessTokenProvider
    {
        private AzureServiceTokenProvider _tokenProvider;

        public MsiAccessTokenProvider()
        {
            _tokenProvider = new AzureServiceTokenProvider();
        }

        public string getAccessToken() => this.getAccessTokenAsync().Result;

        public async Task<string> getAccessTokenAsync()
        {
            var tp = _tokenProvider;
            string accessToken = await tp.GetAccessTokenAsync("https://database.windows.net/");
            return accessToken;
        }
    }
}