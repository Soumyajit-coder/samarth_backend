using samarth_backend.DTO;

namespace samarth_backend.BAL.Interfaces
{
    public interface ICaptchaService
    {
        Task<CaptchaResponseDTO> GenerateCaptchaAsync();
        Task<bool> ValidateCaptchaAsync(string captchaId, string userInput);
    }
}
