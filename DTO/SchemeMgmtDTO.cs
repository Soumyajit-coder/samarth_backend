using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace samarth_backend.DTO
{
    public class SchemeMgmtDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public class updateSchemeDTO
    {
        public string Name { get; set; }
    }
}
