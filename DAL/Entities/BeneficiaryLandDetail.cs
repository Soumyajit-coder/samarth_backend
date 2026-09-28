using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("beneficiary_land_details", Schema = "pension")]
[Index("ApplicationId", Name = "pension_beneficiary_land_details_application_id_unique", IsUnique = true)]
[Index("BeneficiaryId", Name = "pension_beneficiary_land_details_beneficiary_id_unique", IsUnique = true)]
public partial class BeneficiaryLandDetail
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("scheme_id")]
    public long SchemeId { get; set; }

    [Column("application_id")]
    public long ApplicationId { get; set; }

    [Column("beneficiary_id")]
    public long BeneficiaryId { get; set; }

    [Column("land")]
    public int? Land { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string? Name { get; set; }

    [Column("mobile")]
    [StringLength(255)]
    public string? Mobile { get; set; }

    [Column("ccc")]
    [StringLength(10)]
    public string? Ccc { get; set; }

    [Column("other_details", TypeName = "jsonb")]
    public string? OtherDetails { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("ApplicationId")]
    [InverseProperty("BeneficiaryLandDetailApplication")]
    public virtual UniqueAppBenId Application { get; set; } = null!;

    [ForeignKey("BeneficiaryId")]
    [InverseProperty("BeneficiaryLandDetailBeneficiary")]
    public virtual UniqueAppBenId Beneficiary { get; set; } = null!;

    [ForeignKey("SchemeId")]
    [InverseProperty("BeneficiaryLandDetails")]
    public virtual Scheme Scheme { get; set; } = null!;
}
