using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("dynamic_workflow_labels")]
[Index("SchemeId", Name = "dynamic_workflow_labels_scheme_id_index")]
public partial class DynamicWorkflowLabel
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("scheme_id")]
    public int SchemeId { get; set; }

    [Column("module_id")]
    public long ModuleId { get; set; }

    [Column("label_name")]
    [StringLength(150)]
    public string LabelName { get; set; } = null!;

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("op_type_id")]
    public long? OpTypeId { get; set; }

    [Column("permissions", TypeName = "json")]
    public string? Permissions { get; set; }

    [ForeignKey("ModuleId")]
    [InverseProperty("DynamicWorkflowLabels")]
    public virtual DynamicWorkflowSchemeModule Module { get; set; } = null!;
}
