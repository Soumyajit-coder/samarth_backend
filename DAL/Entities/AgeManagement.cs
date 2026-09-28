using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("age_managements")]
public partial class AgeManagement
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("scheme_id")]
    public int SchemeId { get; set; }

    [Column("min_age")]
    public int? MinAge { get; set; }

    [Column("max_age")]
    public int? MaxAge { get; set; }

    [Column("is_special")]
    public bool IsSpecial { get; set; }

    [Column("special_case", TypeName = "jsonb")]
    public string? SpecialCase { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }
}
