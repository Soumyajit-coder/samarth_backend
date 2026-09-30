namespace samarth_backend.DTO
{
    public class RoleMgmtDTO
    {
        public string Name { get; set; }
        public string GuardName { get; set; }
        public DateTime? CreatedAt { get; set; }
    }

    public class RoleMgmtListDTO
    {
        public string Name { get; set; }
        public string GuardName { get; set; }
        public string IsActive { get; set; }
    }

    public class UpdateRoleDetailsDTO
    {
        public short? IsActive { get; set; }
    }
}
