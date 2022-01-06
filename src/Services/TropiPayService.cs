using System.Net.Http.Headers;
using System.Collections;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using Microsoft.Net.Http.Headers;
using deno_tpp_dotnet.Models;

namespace deno_tpp_dotnet.Services
{
    public class TropiPayService
    {
        private readonly HttpClient _httpClient;
        private string _clientId;
        private string _clientSecret;

        public TropiPayService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://tropipay-dev.herokuapp.com/");
            _httpClient.DefaultRequestHeaders.Add(HeaderNames.Accept, "application/json");
            _httpClient.DefaultRequestHeaders.Add(HeaderNames.UserAgent, "HttpRequestsSample");

            _clientId = configuration.GetValue<string>("ClientId");
            _clientSecret = configuration.GetValue<string>("ClientSecret");
        }

        public async Task<Profile?> GetProfileAsync() {
            var token = await this.loginAsync();
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.access_token);
            return await _httpClient.GetFromJsonAsync<Profile>("api/users/profile");
        }

        public async Task<TokenResponse?> loginAsync()
        {
            var tokenRequest = new TokenRequest
            {
                grant_type = "client_credentials",
                client_id = _clientId,
                client_secret = _clientSecret
            };

            var payload = JsonSerializer.Serialize(tokenRequest);
            var requestContent = new StringContent(payload, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/v2/access/token", requestContent);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var token = JsonSerializer.Deserialize<TokenResponse>(content);
            return token;
        }
    }
}