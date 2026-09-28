using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("dynamic_workflow_scheme_modules")]
public partial class DynamicWorkflowSchemeModule
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("scheme_id")]
    public long SchemeId { get; set; }

    [Column("module_id")]
    public long ModuleId { get; set; }

    [Column("main_module_code")]
    [StringLength(150)]
    public string? MainModuleCode { get; set; }

    [Column("step_count")]
    public int StepCount { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [InverseProperty("Module")]
    public virtual ICollection<DynamicWorkflowLabel> DynamicWorkflowLabels { get; set; } = new List<DynamicWorkflowLabel>();

    [InverseProperty("Module")]
    public virtual ICollection<DynamicWorkflowRequest> DynamicWorkflowRequests { get; set; } = new List<DynamicWorkflowRequest>();

    [ForeignKey("ModuleId")]
    [InverseProperty("DynamicWorkflowSchemeModules")]
    public virtual DynamicWorkflowModule Module { get; set; } = null!;

    [ForeignKey("SchemeId")]
    [InverseProperty("DynamicWorkflowSchemeModules")]
    public virtual Scheme Scheme { get; set; } = null!;
}
