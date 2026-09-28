using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("master_mime_types")]
[Index("ExtensionType", Name = "master_mime_types_extension_type_unique", IsUnique = true)]
public partial class MasterMimeType
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("extension_type")]
    [StringLength(255)]
    public string ExtensionType { get; set; } = null!;

    [Column("mime_type")]
    [StringLength(255)]
    public string MimeType { get; set; } = null!;

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }
}
