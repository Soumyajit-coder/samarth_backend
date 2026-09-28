using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("ds_map_records")]
public partial class DsMapRecord
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("application_id")]
    public long ApplicationId { get; set; }

    [Column("new_ds_phase")]
    public int? NewDsPhase { get; set; }

    [Column("new_ds_date")]
    public DateOnly? NewDsDate { get; set; }

    [Column("new_ds_registration_no")]
    [StringLength(255)]
    public string? NewDsRegistrationNo { get; set; }

    [Column("old_ds_phase")]
    public int? OldDsPhase { get; set; }

    [Column("old_ds_date")]
    public DateOnly? OldDsDate { get; set; }

    [Column("old_ds_registration_no")]
    [StringLength(255)]
    public string? OldDsRegistrationNo { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }
}
