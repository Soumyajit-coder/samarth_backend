using Microsoft.Extensions.Caching.Memory;
using samarth_backend.BAL.Interfaces;

namespace samarth_backend.BAL.Services
{
    public class OtpService : IOtpService
    {
        private readonly IMemoryCache _memoryCache;
        private Random _random;

        public OtpService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
            _random = new Random();
        }

        public async Task<string> GenerateAndStoreOtpAsync(string mobileNo)
        {
            // Static OTP for local testing
            string otpValue = "123456";
            
            string cacheKey = $"OTP_{mobileNo}";
            
            // Store in cache for 3 minutes
            _memoryCache.Set(cacheKey, otpValue, TimeSpan.FromMinutes(3));
            
            return await Task.FromResult(otpValue);
        }

        public async Task<bool> ValidateOtpAsync(string mobileNo, string otpInput)
        {
            if (string.IsNullOrWhiteSpace(mobileNo) || string.IsNullOrWhiteSpace(otpInput))
                return false;

            string cacheKey = $"OTP_{mobileNo}";

            if (_memoryCache.TryGetValue(cacheKey, out string storedOtp))
            {
                // Remove to prevent replay attacks
                _memoryCache.Remove(cacheKey);
                
                return string.Equals(storedOtp, otpInput.Trim(), StringComparison.OrdinalIgnoreCase);
            }

            return false;
        }
    }
}
