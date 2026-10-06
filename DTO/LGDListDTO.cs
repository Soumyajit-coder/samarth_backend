namespace samarth_backend.DTO
{
    public class LGDListDTO
    {
    }

    public class DistrictDTO
    {
        public string LgdCode { get; set; }
        public string Name { get; set; }
    }

    public class BlockDTO
    {
        public string LgdCode { get; set; }
        public string Name { get; set; }
    }

    public class SubDivisionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PanchayatDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class WardDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class MunicipalityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
