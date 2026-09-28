using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("activity_log")]
[Index("LogName", Name = "activity_log_log_name_index")]
[Index("SessionId", Name = "activity_log_session_id_index")]
[Index("CauserType", "CauserId", Name = "causer")]
[Index("SubjectType", "SubjectId", Name = "subject")]
public partial class ActivityLog
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("log_name")]
    [StringLength(255)]
    public string? LogName { get; set; }

    [Column("description")]
    public string Description { get; set; } = null!;

    [Column("subject_type")]
    [StringLength(255)]
    public string? SubjectType { get; set; }

    [Column("subject_id")]
    public long? SubjectId { get; set; }

    [Column("causer_type")]
    [StringLength(255)]
    public string? CauserType { get; set; }

    [Column("causer_id")]
    public long? CauserId { get; set; }

    [Column("properties", TypeName = "json")]
    public string? Properties { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("event")]
    [StringLength(255)]
    public string? Event { get; set; }

    [Column("batch_uuid")]
    public Guid? BatchUuid { get; set; }

    [Column("session_id")]
    [StringLength(255)]
    public string? SessionId { get; set; }

    [Column("attribute_changes", TypeName = "json")]
    public string? AttributeChanges { get; set; }
}
