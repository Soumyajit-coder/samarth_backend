using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Keyless]
[Table("m_ds_phase")]
public partial class MDsPhase
{
    [Column("id")]
    public short Id { get; set; }

    [Column("phase_code")]
    public short? PhaseCode { get; set; }

    [Column("phase_des")]
    [StringLength(200)]
    public string? PhaseDes { get; set; }

    [Column("is_current")]
    public bool? IsCurrent { get; set; }

    [Column("base_date")]
    public DateOnly? BaseDate { get; set; }

    [Column("is_samadhan")]
    public bool? IsSamadhan { get; set; }
}
