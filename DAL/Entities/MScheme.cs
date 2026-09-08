using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Keyless]
[Table("m_scheme")]
public partial class MScheme
{
    [Column("id")]
    public int Id { get; set; }

    [Column("scheme_type")]
    public int? SchemeType { get; set; }

    [Column("scheme_name")]
    [StringLength(100)]
    public string? SchemeName { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("short_code_25")]
    [StringLength(100)]
    public string? ShortCode25 { get; set; }

    [Column("is_active")]
    public int? IsActive { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("deleted_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? DeletedAt { get; set; }

    [Column("party_code")]
    [StringLength(5)]
    public string? PartyCode { get; set; }

    [Column("ddo_code")]
    [StringLength(9)]
    public string? DdoCode { get; set; }

    [Column("dept_name")]
    [StringLength(10)]
    public string? DeptName { get; set; }

    [Column("entry_url")]
    [StringLength(100)]
    public string? EntryUrl { get; set; }

    [Column("display_name")]
    [StringLength(100)]
    public string? DisplayName { get; set; }

    [Column("verification_url")]
    [StringLength(50)]
    public string? VerificationUrl { get; set; }

    [Column("approval_url")]
    [StringLength(50)]
    public string? ApprovalUrl { get; set; }

    [Column("pr1_code")]
    [StringLength(20)]
    public string? Pr1Code { get; set; }

    [Column("rank")]
    public short? Rank { get; set; }

    [Column("file_path")]
    [StringLength(50)]
    public string? FilePath { get; set; }

    [Column("file_arc_path")]
    [StringLength(50)]
    public string? FileArcPath { get; set; }

    [Column("file_web_url")]
    [StringLength(50)]
    public string? FileWebUrl { get; set; }

    [Column("allow_ds_entry")]
    public short? AllowDsEntry { get; set; }

    [Column("allow_normal_entry")]
    public short? AllowNormalEntry { get; set; }

    [Column("short_code")]
    [StringLength(100)]
    public string? ShortCode { get; set; }

    [Column("entry_url__")]
    [StringLength(100)]
    public string? EntryUrl1 { get; set; }
}
