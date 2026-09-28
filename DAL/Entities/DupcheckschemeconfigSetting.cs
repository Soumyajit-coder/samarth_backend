using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("dupcheckschemeconfig_settings")]
public partial class DupcheckschemeconfigSetting
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("scheme_id")]
    public long SchemeId { get; set; }

    [Column("is_same")]
    public bool IsSame { get; set; }

    [Column("is_cross")]
    public bool IsCross { get; set; }

    [Column("scheme_lists", TypeName = "jsonb")]
    public string? SchemeLists { get; set; }

    [Column("check_with")]
    [StringLength(20)]
    public string CheckWith { get; set; } = null!;

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }
}
