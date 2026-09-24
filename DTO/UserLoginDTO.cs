using System.ComponentModel.DataAnnotations.Schema;

namespace samarth_backend.DTO
{
    public class UserLoginDTO
    {
        public string? MobileNo { get; set; }
        public string CaptchaId { get; set; }
        public string CaptchaInput { get; set; }
        public string? Password { get; set; }
    }

    public class UserForgetPasswordDTO
    {
        public string? MobileNo { get; set; }
        public string? Password { get; set; }
    }

    public class UserDTO
    {
        public string? Name { get; set; }
        public string? MobileNo { get; set; }
        public string? Password { get; set; }
        public string? DesignationId { get; set; }
        public int? DistrictCode { get; set; }
    }
}
