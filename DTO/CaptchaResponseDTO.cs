namespace samarth_backend.DTO
{
    public class CaptchaResponseDTO
    {
        public string CaptchaId { get; set; }
        public string ImageBase64 { get; set; }
    }

    public class LoginWithCaptchaRequestDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string CaptchaId { get; set; }
        public string CaptchaInput { get; set; }
    }
}
