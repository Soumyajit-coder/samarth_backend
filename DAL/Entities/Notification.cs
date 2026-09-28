using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("notifications")]
[Index("NotifiedAt", Name = "notifications_notified_at_index")]
[Index("Status", Name = "notifications_status_index")]
[Index("Type", Name = "notifications_type_index")]
public partial class Notification
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("title")]
    [StringLength(255)]
    public string Title { get; set; } = null!;

    [Column("message")]
    public string Message { get; set; } = null!;

    [Column("scheme_name")]
    [StringLength(255)]
    public string? SchemeName { get; set; }

    [Column("type")]
    [StringLength(255)]
    public string Type { get; set; } = null!;

    [Column("status")]
    [StringLength(255)]
    public string Status { get; set; } = null!;

    [Column("meta", TypeName = "json")]
    public string? Meta { get; set; }

    [Column("notified_at", TypeName = "timestamp(0) without time zone")]
    public DateTime NotifiedAt { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }
}
