using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("accept_reject_infos")]
[Index("ApplicationId", Name = "accept_reject_infos_application_id_index")]
[Index("BeneficiaryId", Name = "accept_reject_infos_beneficiary_id_index")]
public partial class AcceptRejectInfo
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("scheme_id")]
    public int SchemeId { get; set; }

    [Column("application_id")]
    public long? ApplicationId { get; set; }

    [Column("beneficiary_id")]
    public long? BeneficiaryId { get; set; }

    [Column("ip_address")]
    [StringLength(255)]
    public string? IpAddress { get; set; }

    [Column("user_id")]
    public long? UserId { get; set; }

    [Column("browser")]
    [StringLength(255)]
    public string? Browser { get; set; }

    [Column("model_name")]
    [StringLength(255)]
    public string? ModelName { get; set; }

    [Column("op_type")]
    public int? OpType { get; set; }

    [Column("revert_reason_cause_id")]
    public int? RevertReasonCauseId { get; set; }

    [Column("revert_reason_remarks")]
    [StringLength(255)]
    public string? RevertReasonRemarks { get; set; }

    [Column("parent_id")]
    public long? ParentId { get; set; }

    [Column("old_op_type")]
    [StringLength(20)]
    public string? OldOpType { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("critical_changes")]
    public short CriticalChanges { get; set; }

    [Column("old_value", TypeName = "jsonb")]
    public string? OldValue { get; set; }

    [Column("new_value", TypeName = "jsonb")]
    public string? NewValue { get; set; }

    [ForeignKey("OpType")]
    [InverseProperty("AcceptRejectInfoOpTypeNavigations")]
    public virtual Codemaster? OpTypeNavigation { get; set; }

    [ForeignKey("RevertReasonCauseId")]
    [InverseProperty("AcceptRejectInfoRevertReasonCauses")]
    public virtual Codemaster? RevertReasonCause { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("AcceptRejectInfos")]
    public virtual User? User { get; set; }
}
