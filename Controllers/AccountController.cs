using Microsoft.AspNetCore.Mvc;
using Net_2026_Victor_Leano.Models;
using Net_2026_Victor_Leano.Services.Interfaces;


namespace Net_2026_Victor_Leano.Controllers
{
    public class AccountController : Controller
    {
        private readonly IApiService _apiService;

        public AccountController(IApiService apiService)
        {
            _apiService = apiService;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {
             
            request.companyName = "SCI TEST";
            request.appTypeDescription = "Web";
            request.reCaptchaToken = null;
            try
            {
                var token = await _apiService.Login(request);

                HttpContext.Session.SetString("token", token);

                return RedirectToAction("Index", "Company");
            }
            catch (Exception)
            {

                ViewBag.Error = "Invalid credentials";
                return View();
            }
            
        }
    }
}
