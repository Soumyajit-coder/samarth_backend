using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("ds_phases")]
[Index("PhaseCode", Name = "ds_phases_phase_code_unique", IsUnique = true)]
public partial class DsPhase
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("phase_code")]
    public int PhaseCode { get; set; }

    [Column("phase_desc")]
    public string PhaseDesc { get; set; } = null!;

    [Column("is_current")]
    public bool IsCurrent { get; set; }

    [Column("base_dob")]
    public DateOnly BaseDob { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }
}
