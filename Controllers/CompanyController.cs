using Microsoft.AspNetCore.Mvc;
using Net_2026_Victor_Leano.Services.Interfaces;
using Net_2026_Victor_Leano.ViewModels;

namespace Net_2026_Victor_Leano.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IApiService _apiService;

        public CompanyController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            var token = HttpContext.Session.GetString("token");

            var company = await _apiService.GetCompany(token);

            var viewModel = new CompanyViewModel
            {
                CompanyName = company.companyName,
                Address = "5 av",
                EmergencyEmail = company.emergencyEmail,
                EmergencyPhone = company.emergencyContactNumber
            };

            return View(viewModel);
        }
    }
}
