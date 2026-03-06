namespace Net_2026_Victor_Leano.Models
{
    public class LoginRequest
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string companyName { get; set; }
        public string appTypeDescription { get; set; }
        public string reCaptchaToken { get; set; }
    }
}
