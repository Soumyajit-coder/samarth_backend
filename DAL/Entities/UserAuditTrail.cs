using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("user_audit_trails")]
public partial class UserAuditTrail
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("old_password")]
    [StringLength(255)]
    public string? OldPassword { get; set; }

    [Column("new_password")]
    [StringLength(255)]
    public string? NewPassword { get; set; }

    [Column("operation_type")]
    public short? OperationType { get; set; }

    [Column("operate_by")]
    public short? OperateBy { get; set; }

    [Column("operate_to_user_id")]
    public short? OperateToUserId { get; set; }

    [Column("ip_address")]
    [StringLength(255)]
    public string? IpAddress { get; set; }

    [Column("user_agent")]
    [StringLength(255)]
    public string? UserAgent { get; set; }

    [Column("operation_time", TypeName = "timestamp(0) without time zone")]
    public DateTime? OperationTime { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }
}
