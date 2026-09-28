using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[PrimaryKey("ApplicationId", "SchemeId", "IsClean")]
[Table("bpd_s20_c10", Schema = "pension")]
public partial class BpdS20C10
{
    [Key]
    [Column("scheme_id")]
    public long SchemeId { get; set; }

    [Key]
    [Column("application_id")]
    public long ApplicationId { get; set; }

    [Column("beneficiary_id")]
    public long? BeneficiaryId { get; set; }

    [Column("next_level_role_id")]
    public int? NextLevelRoleId { get; set; }

    [Column("application_date")]
    public DateOnly? ApplicationDate { get; set; }

    [Column("ds_date")]
    public DateOnly? DsDate { get; set; }

    [Column("dob")]
    public DateOnly? Dob { get; set; }

    [Column("beneficiary_name")]
    [StringLength(150)]
    public string? BeneficiaryName { get; set; }

    [Column("ben_mother_name")]
    [StringLength(150)]
    public string? BenMotherName { get; set; }

    [Column("ben_father_name")]
    [StringLength(150)]
    public string? BenFatherName { get; set; }

    [Column("ben_spouse_name")]
    [StringLength(150)]
    public string? BenSpouseName { get; set; }

    [Column("email")]
    [StringLength(150)]
    public string? Email { get; set; }

    [Column("application_type")]
    [StringLength(50)]
    public string? ApplicationType { get; set; }

    [Column("ds_registration_no")]
    [StringLength(100)]
    public string? DsRegistrationNo { get; set; }

    [Column("marital_status")]
    public int? MaritalStatus { get; set; }

    [Column("caste")]
    public int? Caste { get; set; }

    [Column("caste_cer_no")]
    [StringLength(100)]
    public string? CasteCerNo { get; set; }

    [Column("is_final")]
    public short IsFinal { get; set; }

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
    [InverseProperty("BpdS20C10Applications")]
    public virtual UniqueAppBenId Application { get; set; } = null!;

    [ForeignKey("BeneficiaryId")]
    [InverseProperty("BpdS20C10Beneficiaries")]
    public virtual UniqueAppBenId? Beneficiary { get; set; }

    [ForeignKey("Caste")]
    [InverseProperty("BpdS20C10CasteNavigations")]
    public virtual Codemaster? CasteNavigation { get; set; }

    [ForeignKey("MaritalStatus")]
    [InverseProperty("BpdS20C10MaritalStatusNavigations")]
    public virtual Codemaster? MaritalStatusNavigation { get; set; }

    [ForeignKey("NextLevelRoleId")]
    [InverseProperty("BpdS20C10NextLevelRoles")]
    public virtual Codemaster? NextLevelRole { get; set; }

    [ForeignKey("SchemeId")]
    [InverseProperty("BpdS20C10s")]
    public virtual Scheme Scheme { get; set; } = null!;
}
