using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[PrimaryKey("ApplicationId", "SchemeId", "IsClean")]
[Table("bbd_s8_default", Schema = "pension")]
public partial class BbdS8Default
{
    [Key]
    [Column("scheme_id")]
    public long SchemeId { get; set; }

    [Key]
    [Column("application_id")]
    public long ApplicationId { get; set; }

    [Column("beneficiary_id")]
    public long? BeneficiaryId { get; set; }

    [Column("ifscode")]
    [StringLength(11)]
    public string? Ifscode { get; set; }

    [Column("bankaccountnumber")]
    [StringLength(20)]
    public string? Bankaccountnumber { get; set; }

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
    [InverseProperty("BbdS8DefaultApplications")]
    public virtual UniqueAppBenId Application { get; set; } = null!;

    [ForeignKey("BeneficiaryId")]
    [InverseProperty("BbdS8DefaultBeneficiaries")]
    public virtual UniqueAppBenId? Beneficiary { get; set; }

    [ForeignKey("Ifscode")]
    [InverseProperty("BbdS8Defaults")]
    public virtual Ifsccodemaster? IfscodeNavigation { get; set; }

    [ForeignKey("SchemeId")]
    [InverseProperty("BbdS8Defaults")]
    public virtual Scheme Scheme { get; set; } = null!;
}
