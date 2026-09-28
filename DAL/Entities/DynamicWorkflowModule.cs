using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("dynamic_workflow_modules")]
[Index("ModuleCode", Name = "dynamic_workflow_modules_module_code_unique", IsUnique = true)]
public partial class DynamicWorkflowModule
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("module_code")]
    [StringLength(60)]
    public string ModuleCode { get; set; } = null!;

    [Column("module_name")]
    [StringLength(150)]
    public string ModuleName { get; set; } = null!;

    [Column("allowed_fields", TypeName = "jsonb")]
    public string? AllowedFields { get; set; }

    [Column("is_active")]
    public bool IsActive { get; set; }

    [Column("created_by")]
    public long CreatedBy { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [InverseProperty("Module")]
    public virtual ICollection<DynamicWorkflowSchemeModule> DynamicWorkflowSchemeModules { get; set; } = new List<DynamicWorkflowSchemeModule>();
}
