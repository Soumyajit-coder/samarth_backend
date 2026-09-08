using Microsoft.Extensions.Caching.Memory;
using samarth_backend.BAL.Interfaces;
using samarth_backend.DTO;
using SixLabors.Fonts;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Drawing.Processing;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace samarth_backend.BAL.Services
{
    public class CaptchaService : ICaptchaService
    {
        private readonly IMemoryCache _memoryCache;
        private Random _random;
        public CaptchaService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
            _random = new();
        }
        public async Task<CaptchaResponseDTO> GenerateCaptchaAsync()
        {
            string captchaId = Guid.NewGuid().ToString();
            string captchaValue = GenerateRandomText(6); // Generate a random 6-character string
            _memoryCache.Set(captchaId, captchaValue, TimeSpan.FromMinutes(5)); // Store in cache for 5 minutes
            string base64Image = GenerateCaptchaImage(captchaValue); // Generate the CAPTCHA image as a base64 string
            return new CaptchaResponseDTO
            {
                CaptchaId = captchaId,
                ImageBase64 = base64Image
            };
        }
        public async Task<bool> ValidateCaptchaAsync(string captchaId, string userInput)
        {
            if (string.IsNullOrWhiteSpace(captchaId) || string.IsNullOrWhiteSpace(userInput))
                return false;
            // Cache থেকে চেক করা
            if (_memoryCache.TryGetValue(captchaId, out string storedText))
            {
                // Security: Replay Attack প্রতিরোধে একবার ব্যবহারের পর Cache থেকে মুছে ফেলা
                _memoryCache.Remove(captchaId);
                return string.Equals(storedText, userInput.Trim(), StringComparison.OrdinalIgnoreCase);
            }
            return false; // Expiry বা Invalid Id হলে false
        }
        private string GenerateRandomText(int length)
        {
            // কনফিউজিং অক্ষর (যেমন: 0, O, 1, I) বাদ দিয়ে টেক্সট জেনারেট
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }

        private string GenerateCaptchaImage(string text)
        {
            int width = 160;
            int height = 55;
            using var image = new Image<Rgba32>(width, height);
            image.Mutate(ctx =>
            {
                // ১. ব্যাকগ্রাউন্ড কালার সেট করা
                //ctx.Fill(Color.GhostWhite);
                ctx.BackgroundColor(Color.GhostWhite);
                // ২. ব্যাকগ্রাউন্ড নয়েজ লাইন যোগ করা (Security এর জন্য)
                for (int i = 0; i < 6; i++)
                {
                    int rx = _random.Next(0, width);
                    int ry = _random.Next(0, height);
                    image[rx, ry] = Color.Gray.ToPixel<Rgba32>(); // সরাসরি ইমেজের পিক্সেল কালার চেঞ্জ
                }
                // ৩. টেক্সট আঁকা (ফন্ট ও পজিশন সামান্য র্যান্ডমাইজ করা)
                SixLabors.Fonts.Font font = SystemFonts.CreateFont("Arial", 24, FontStyle.Bold);
                for (int i = 0; i < text.Length; i++)
                {
                    byte r = (byte)_random.Next(0, 120);
                    byte g = (byte)_random.Next(0, 120);
                    byte b = (byte)_random.Next(0, 120);

                    Color textColor = Color.FromPixel<Rgba32>(new Rgba32(r, g, b));

                    var location = new PointF(15 + (i * 24), 10 + _random.Next(-4, 4));

                    // textColor এর বদলে Brushes.Solid(textColor) ব্যবহার করা হয়েছে:
                    ctx.DrawText(text[i].ToString(), font, Brushes.Solid(Color.Black), location);
                }
            });
            using var ms = new MemoryStream();
            image.SaveAsPng(ms);
            return $"data:image/png;base64,{Convert.ToBase64String(ms.ToArray())}";
        }
    }
}
