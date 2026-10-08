namespace samarth_backend.DTO
{
    public class OfficeMasterDTO
    {
        public string Name { get; set; }
        public string? Address { get; set; }
        public int OfficeTypeId { get; set; }
        public short StateId { get; set; }
        public string DistrictId { get; set; }
        public string BlockId { get; set; }
        public string SubdivisionId { get; set; }
        public string MunicipalitiyId { get; set; }
        public string WardId { get; set; }
        public string PanchayatId { get; set; }
        public string IsActive { get; set; }
    }

    public class  AddOfficeMasterDTO
    {
        public string Name { get; set; }
        public string? Address { get; set; }
        public short StateId { get; set; }
        public int? DistrictId { get; set; }
        public int? BlockId { get; set; }
        public int? SubdivisionId { get; set; }
        public int? MunicipalitiyId { get; set; }
        public int? WardId { get; set; }
        public int? PanchayatId { get; set; }
        public DateTime? CreatedAt { get; set; }
    }

    public class updateOfficeMasterDTO
    {
        public short? IsActive { get; set; }
    }
}
