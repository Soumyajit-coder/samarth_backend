using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("scheme_attached_doc_mappings")]
[Index("SchemeId", Name = "scheme_attached_doc_mappings_scheme_id_index")]
public partial class SchemeAttachedDocMapping
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("scheme_id")]
    public long SchemeId { get; set; }

    [Column("doc_type_id")]
    public int DocTypeId { get; set; }

    [Column("is_required")]
    public bool IsRequired { get; set; }

    [Column("max_file_size")]
    [StringLength(255)]
    public string MaxFileSize { get; set; } = null!;

    [Column("extension_type")]
    [StringLength(255)]
    public string ExtensionType { get; set; } = null!;

    [ForeignKey("DocTypeId")]
    [InverseProperty("SchemeAttachedDocMappings")]
    public virtual Codemaster DocType { get; set; } = null!;

    [ForeignKey("SchemeId")]
    [InverseProperty("SchemeAttachedDocMappings")]
    public virtual Scheme Scheme { get; set; } = null!;
}
