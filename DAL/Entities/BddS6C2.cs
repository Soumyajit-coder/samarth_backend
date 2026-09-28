using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[PrimaryKey("ApplicationId", "SchemeId", "IsClean")]
[Table("bdd_s6_c2", Schema = "pension")]
public partial class BddS6C2
{
    [Key]
    [Column("scheme_id")]
    public long SchemeId { get; set; }

    [Key]
    [Column("application_id")]
    public long ApplicationId { get; set; }

    [Column("beneficiary_id")]
    public long? BeneficiaryId { get; set; }

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
    [InverseProperty("BddS6C2Applications")]
    public virtual UniqueAppBenId Application { get; set; } = null!;

    [ForeignKey("BeneficiaryId")]
    [InverseProperty("BddS6C2Beneficiaries")]
    public virtual UniqueAppBenId? Beneficiary { get; set; }

    [ForeignKey("SchemeId")]
    [InverseProperty("BddS6C2s")]
    public virtual Scheme Scheme { get; set; } = null!;
}
