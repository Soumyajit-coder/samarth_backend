using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("user_page_visit_logs")]
[Index("SessionId", Name = "user_page_visit_logs_session_id_index")]
[Index("UserId", Name = "user_page_visit_logs_user_id_index")]
[Index("VisitTime", Name = "user_page_visit_logs_visit_time_index")]
public partial class UserPageVisitLog
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("user_id")]
    public long? UserId { get; set; }

    [Column("user_role_id")]
    public long? UserRoleId { get; set; }

    [Column("visit_time", TypeName = "timestamp(0) without time zone")]
    public DateTime? VisitTime { get; set; }

    [Column("ip")]
    [StringLength(45)]
    public string? Ip { get; set; }

    [Column("user_agent")]
    [StringLength(255)]
    public string? UserAgent { get; set; }

    [Column("platform")]
    [StringLength(50)]
    public string? Platform { get; set; }

    [Column("browser")]
    [StringLength(30)]
    public string? Browser { get; set; }

    [Column("browser_version")]
    [StringLength(20)]
    public string? BrowserVersion { get; set; }

    [Column("url")]
    public string? Url { get; set; }

    [Column("method")]
    [StringLength(10)]
    public string? Method { get; set; }

    [Column("referrer")]
    [StringLength(255)]
    public string? Referrer { get; set; }

    [Column("description", TypeName = "jsonb")]
    public string? Description { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("session_id")]
    [StringLength(255)]
    public string? SessionId { get; set; }

    [Column("log_level")]
    [StringLength(255)]
    public string LogLevel { get; set; } = null!;

    [Column("log_nickname")]
    [StringLength(255)]
    public string? LogNickname { get; set; }

    [Column("request_payload", TypeName = "jsonb")]
    public string? RequestPayload { get; set; }

    [Column("response_payload", TypeName = "jsonb")]
    public string? ResponsePayload { get; set; }

    [Column("status_code")]
    public int? StatusCode { get; set; }
}
