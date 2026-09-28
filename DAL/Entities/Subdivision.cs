using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("subdivisions")]
[Index("DistrictId", Name = "subdivisions_district_id_index")]
[Index("Id", Name = "subdivisions_id_index")]
[Index("LgdCode", Name = "subdivisions_lgd_code_index")]
[Index("RefCode", Name = "subdivisions_ref_code_unique", IsUnique = true)]
public partial class Subdivision
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("ref_code")]
    [StringLength(50)]
    public string RefCode { get; set; } = null!;

    [Column("lgd_code")]
    [StringLength(255)]
    public string? LgdCode { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("local_name")]
    [StringLength(255)]
    public string? LocalName { get; set; }

    [Column("district_id")]
    public int DistrictId { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_active")]
    public short IsActive { get; set; }

    [ForeignKey("DistrictId")]
    [InverseProperty("Subdivisions")]
    public virtual District District { get; set; } = null!;

    [InverseProperty("Subdivision")]
    public virtual ICollection<Municipality> Municipalities { get; set; } = new List<Municipality>();

    [InverseProperty("Subdivision")]
    public virtual ICollection<OfficeMaster> OfficeMasters { get; set; } = new List<OfficeMaster>();
}
