using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Keyless]
[Table("ben_accept_reject_info")]
public partial class BenAcceptRejectInfo
{
    [Column("id")]
    public long Id { get; set; }

    [Column("scheme_id")]
    public int? SchemeId { get; set; }

    [Column("created_by_dist_code")]
    public int? CreatedByDistCode { get; set; }

    [Column("created_by_local_body_code")]
    public int? CreatedByLocalBodyCode { get; set; }

    [Column("rejected_reverted_cause")]
    [StringLength(20)]
    public string? RejectedRevertedCause { get; set; }

    [Column("comment_message")]
    public string? CommentMessage { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("deleted_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? DeletedAt { get; set; }

    [Column("ip_address")]
    [StringLength(20)]
    public string? IpAddress { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("application_id")]
    public int? ApplicationId { get; set; }

    [Column("lb_application_id")]
    public int? LbApplicationId { get; set; }

    [Column("old_data", TypeName = "jsonb")]
    public string? OldData { get; set; }

    [Column("new_data", TypeName = "jsonb")]
    public string? NewData { get; set; }

    [Column("remarks")]
    [StringLength(100)]
    public string? Remarks { get; set; }

    [Column("module_name")]
    [StringLength(100)]
    public string? ModuleName { get; set; }

    [Column("op_type")]
    [StringLength(50)]
    public string? OpType { get; set; }

    [Column("reason")]
    [StringLength(200)]
    public string? Reason { get; set; }

    [Column("update_code")]
    [StringLength(20)]
    public string? UpdateCode { get; set; }

    [Column("next_level_name_failed_id")]
    public int? NextLevelNameFailedId { get; set; }

    [Column("grievance_id")]
    public int? GrievanceId { get; set; }
}
