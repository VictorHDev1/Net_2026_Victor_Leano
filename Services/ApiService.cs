using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Net_2026_Victor_Leano.Models;
using Net_2026_Victor_Leano.Services.Interfaces;

namespace Net_2026_Victor_Leano.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // ESTE ES EL MÉTODO QUE REEMPLAZAS
        public async Task<string> Login(LoginRequest request)
        {
            var json = JsonSerializer.Serialize(request);

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(
                "https://fleetsapapiqa2.azurewebsites.net/Api/SignIn",
                content
            );

            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
                throw new Exception(result);

            // Leer el JSON para sacar el token
            using var doc = JsonDocument.Parse(result);

            var token = doc.RootElement
                           .GetProperty("data")
                           .GetProperty("token")
                           .GetString();

            return token;
        }

        public async Task<Company> GetCompany(string token)
        {
            _httpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.GetAsync(
                "https://fleetsapapiqa2.azurewebsites.net/Api/Company?CompanyId=NQAwADIA"
            );

            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();

            using var doc = JsonDocument.Parse(result);

            var companyJson = doc.RootElement
                                 .GetProperty("data")
                                 .GetRawText();

            return JsonSerializer.Deserialize<Company>(companyJson);
        }
    }
}