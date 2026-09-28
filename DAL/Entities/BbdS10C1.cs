using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[PrimaryKey("ApplicationId", "SchemeId", "IsClean")]
[Table("bbd_s10_c1", Schema = "pension")]
public partial class BbdS10C1
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
    [InverseProperty("BbdS10C1Applications")]
    public virtual UniqueAppBenId Application { get; set; } = null!;

    [ForeignKey("BeneficiaryId")]
    [InverseProperty("BbdS10C1Beneficiaries")]
    public virtual UniqueAppBenId? Beneficiary { get; set; }

    [ForeignKey("Ifscode")]
    [InverseProperty("BbdS10C1s")]
    public virtual Ifsccodemaster? IfscodeNavigation { get; set; }

    [ForeignKey("SchemeId")]
    [InverseProperty("BbdS10C1s")]
    public virtual Scheme Scheme { get; set; } = null!;
}
