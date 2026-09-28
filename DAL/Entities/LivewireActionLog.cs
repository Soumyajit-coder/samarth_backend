using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("livewire_action_logs")]
[Index("UserPageVisitLogId", Name = "livewire_action_logs_user_page_visit_log_id_index")]
public partial class LivewireActionLog
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("user_id")]
    public long? UserId { get; set; }

    [Column("session_id")]
    [StringLength(255)]
    public string? SessionId { get; set; }

    [Column("url")]
    [StringLength(255)]
    public string? Url { get; set; }

    [Column("ip")]
    [StringLength(255)]
    public string? Ip { get; set; }

    [Column("component_name")]
    [StringLength(255)]
    public string? ComponentName { get; set; }

    [Column("method_name")]
    [StringLength(255)]
    public string? MethodName { get; set; }

    [Column("request_payload")]
    public string? RequestPayload { get; set; }

    [Column("response_payload")]
    public string? ResponsePayload { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("log_level")]
    [StringLength(255)]
    public string LogLevel { get; set; } = null!;

    [Column("log_nickname")]
    [StringLength(255)]
    public string? LogNickname { get; set; }

    [Column("user_page_visit_log_id")]
    [StringLength(255)]
    public string? UserPageVisitLogId { get; set; }
}
