using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Keyless]
[Table("duty_assignement")]
public partial class DutyAssignement
{
    [Column("id")]
    public int Id { get; set; }

    [Column("district_code")]
    public int? DistrictCode { get; set; }

    [Column("user_id")]
    public int? UserId { get; set; }

    [Column("is_active")]
    public int? IsActive { get; set; }

    [Column("decative_date")]
    public DateOnly? DecativeDate { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("deleted_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? DeletedAt { get; set; }

    [Column("is_urban")]
    public int? IsUrban { get; set; }

    [Column("urban_body_code")]
    public int? UrbanBodyCode { get; set; }

    [Column("taluka_code")]
    public int? TalukaCode { get; set; }

    [Column("ps_code")]
    public int? PsCode { get; set; }

    [Column("mapping_level")]
    [StringLength(15)]
    public string? MappingLevel { get; set; }

    [Column("scheme_id")]
    public int? SchemeId { get; set; }

    [Column("is_state_login")]
    public bool? IsStateLogin { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("updated_by")]
    public int? UpdatedBy { get; set; }
}
