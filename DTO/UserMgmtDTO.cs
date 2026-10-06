namespace samarth_backend.DTO
{
    public class UserMgmtDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public short IsActive { get; set; }
        public string? Designation { get; set; }
    }
}
