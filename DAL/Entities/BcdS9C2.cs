using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[PrimaryKey("ApplicationId", "SchemeId", "IsClean")]
[Table("bcd_s9_c2", Schema = "pension")]
public partial class BcdS9C2
{
    [Key]
    [Column("scheme_id")]
    public long SchemeId { get; set; }

    [Key]
    [Column("application_id")]
    public long ApplicationId { get; set; }

    [Column("beneficiary_id")]
    public long? BeneficiaryId { get; set; }

    [Column("state")]
    public int? State { get; set; }

    [Column("district_id")]
    public int? DistrictId { get; set; }

    [Column("rural_urban")]
    public int? RuralUrban { get; set; }

    [Column("block")]
    public int? Block { get; set; }

    [Column("municipality")]
    public int? Municipality { get; set; }

    [Column("gp")]
    public int? Gp { get; set; }

    [Column("ward")]
    public int? Ward { get; set; }

    [Column("villtowncity")]
    [StringLength(150)]
    public string? Villtowncity { get; set; }

    [Column("postoffice")]
    [StringLength(150)]
    public string? Postoffice { get; set; }

    [Column("policestation")]
    [StringLength(150)]
    public string? Policestation { get; set; }

    [Column("housepremiseno")]
    [StringLength(150)]
    public string? Housepremiseno { get; set; }

    [Column("pincode")]
    [StringLength(6)]
    public string? Pincode { get; set; }

    [Column("created_by_dist_code")]
    public int? CreatedByDistCode { get; set; }

    [Column("created_by_local_body_code")]
    public int? CreatedByLocalBodyCode { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("updated_by")]
    public int? UpdatedBy { get; set; }

    [Column("other_details", TypeName = "jsonb")]
    public string? OtherDetails { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Key]
    [Column("is_clean")]
    public short IsClean { get; set; }

    [ForeignKey("ApplicationId")]
    [InverseProperty("BcdS9C2Applications")]
    public virtual UniqueAppBenId Application { get; set; } = null!;

    [ForeignKey("BeneficiaryId")]
    [InverseProperty("BcdS9C2Beneficiaries")]
    public virtual UniqueAppBenId? Beneficiary { get; set; }

    [ForeignKey("Block")]
    [InverseProperty("BcdS9C2s")]
    public virtual Block? BlockNavigation { get; set; }

    [ForeignKey("DistrictId")]
    [InverseProperty("BcdS9C2s")]
    public virtual District? District { get; set; }

    [ForeignKey("Gp")]
    [InverseProperty("BcdS9C2s")]
    public virtual Panchayat? GpNavigation { get; set; }

    [ForeignKey("Municipality")]
    [InverseProperty("BcdS9C2s")]
    public virtual Municipality? MunicipalityNavigation { get; set; }

    [ForeignKey("SchemeId")]
    [InverseProperty("BcdS9C2s")]
    public virtual Scheme Scheme { get; set; } = null!;

    [ForeignKey("Ward")]
    [InverseProperty("BcdS9C2s")]
    public virtual Ward? WardNavigation { get; set; }
}
