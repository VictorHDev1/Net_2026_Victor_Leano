using Net_2026_Victor_Leano.Models;

namespace Net_2026_Victor_Leano.Services.Interfaces
{
    public interface IApiService
    {
        Task<string> Login(LoginRequest request);

        Task<Company> GetCompany(string token);
    }
}
