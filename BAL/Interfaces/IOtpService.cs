namespace samarth_backend.BAL.Interfaces
{
    public interface IOtpService
    {
        Task<string> GenerateAndStoreOtpAsync(string mobileNo);
        Task<bool> ValidateOtpAsync(string mobileNo, string otpInput);
    }
}
