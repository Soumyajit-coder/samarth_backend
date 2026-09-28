namespace samarth_backend.DTO
{
    public class DutyManagementDTO
    {
    }

    public class PermissionListDTO
    {
        public string Name { get; set; }
        public string GuardName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string IsActive { get; set; }
    }
    public class AddPermissionDTO
    {
        public string Name { get; set; }
        public string GuardName { get; set; }
    }
    public class updatePermissionDTO
    {
        public short? IsActive { get; set; }
    }
}
