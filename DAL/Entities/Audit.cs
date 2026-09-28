using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("audits")]
[Index("AuditableType", "AuditableId", Name = "audits_auditable_type_auditable_id_index")]
[Index("UserId", "UserType", Name = "audits_user_id_user_type_index")]
[Index("UserPageVisitLogId", Name = "audits_user_page_visit_log_id_index")]
public partial class Audit
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("user_type")]
    [StringLength(255)]
    public string? UserType { get; set; }

    [Column("user_id")]
    public long? UserId { get; set; }

    [Column("event")]
    [StringLength(255)]
    public string Event { get; set; } = null!;

    [Column("auditable_type")]
    [StringLength(255)]
    public string AuditableType { get; set; } = null!;

    [Column("auditable_id")]
    public long AuditableId { get; set; }

    [Column("old_values")]
    public string? OldValues { get; set; }

    [Column("new_values")]
    public string? NewValues { get; set; }

    [Column("url")]
    public string? Url { get; set; }

    [Column("ip_address")]
    public IPAddress? IpAddress { get; set; }

    [Column("user_agent")]
    [StringLength(1023)]
    public string? UserAgent { get; set; }

    [Column("tags")]
    [StringLength(255)]
    public string? Tags { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("session_id")]
    [StringLength(255)]
    public string? SessionId { get; set; }

    [Column("other_details", TypeName = "jsonb")]
    public string? OtherDetails { get; set; }

    [Column("livewire_action_log_id")]
    [StringLength(255)]
    public string? LivewireActionLogId { get; set; }

    [Column("user_page_visit_log_id")]
    [StringLength(255)]
    public string? UserPageVisitLogId { get; set; }
}
