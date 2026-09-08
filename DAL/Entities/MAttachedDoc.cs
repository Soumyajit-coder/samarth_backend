using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Keyless]
[Table("m_attached_doc")]
public partial class MAttachedDoc
{
    [Column("id")]
    public int Id { get; set; }

    [Column("doc_name")]
    [StringLength(250)]
    public string? DocName { get; set; }

    [Column("doc_type")]
    [StringLength(100)]
    public string? DocType { get; set; }

    [Column("doc_mime_type")]
    [StringLength(250)]
    public string? DocMimeType { get; set; }

    [Column("doc_size_kb")]
    public int? DocSizeKb { get; set; }

    [Column("is_active")]
    public bool? IsActive { get; set; }

    [Column("is_profile_pic")]
    public bool? IsProfilePic { get; set; }

    [Column("doucument_group1")]
    public int? DoucumentGroup1 { get; set; }

    [Column("doucument_group")]
    public List<int>? DoucumentGroup { get; set; }

    [Column("created_at", TypeName = "time(0) with time zone")]
    public DateTimeOffset? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "time(0) with time zone")]
    public DateTimeOffset? UpdatedAt { get; set; }

    [Column("deleted_at", TypeName = "time(0) with time zone")]
    public DateTimeOffset? DeletedAt { get; set; }
}
