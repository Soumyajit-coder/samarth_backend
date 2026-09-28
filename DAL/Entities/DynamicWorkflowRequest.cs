using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("dynamic_workflow_requests")]
[Index("ModuleId", "RefId", Name = "dwr_module_ref_idx")]
[Index("CurrentRank", Name = "dynamic_workflow_requests_current_rank_index")]
[Index("RefId", Name = "dynamic_workflow_requests_ref_id_index")]
public partial class DynamicWorkflowRequest
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("module_id")]
    public long ModuleId { get; set; }

    [Column("scheme_id")]
    public long SchemeId { get; set; }

    [Column("ref_id")]
    public long RefId { get; set; }

    [Column("current_rank")]
    public int CurrentRank { get; set; }

    [Column("current_step_id")]
    public long CurrentStepId { get; set; }

    [Column("old_data", TypeName = "jsonb")]
    public string? OldData { get; set; }

    [Column("new_data", TypeName = "jsonb")]
    public string? NewData { get; set; }

    [Column("changed_fields", TypeName = "jsonb")]
    public string? ChangedFields { get; set; }

    [Column("created_by")]
    public long CreatedBy { get; set; }

    [Column("updated_by")]
    public long? UpdatedBy { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("ModuleId")]
    [InverseProperty("DynamicWorkflowRequests")]
    public virtual DynamicWorkflowSchemeModule Module { get; set; } = null!;

    [ForeignKey("SchemeId")]
    [InverseProperty("DynamicWorkflowRequests")]
    public virtual Scheme Scheme { get; set; } = null!;
}
