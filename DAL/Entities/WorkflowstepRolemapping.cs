using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("workflowstep_rolemappings")]
public partial class WorkflowstepRolemapping
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("scheme_id")]
    public long SchemeId { get; set; }

    [Column("workflow_step_id")]
    public int WorkflowStepId { get; set; }

    [Column("rank")]
    public long? Rank { get; set; }

    [Column("role_id")]
    public int RoleId { get; set; }

    [Column("same_level_role_id")]
    public long? SameLevelRoleId { get; set; }

    [Column("next_level_role_id")]
    public long? NextLevelRoleId { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("module_id")]
    public long? ModuleId { get; set; }

    [Column("is_first_step")]
    public bool IsFirstStep { get; set; }

    [Column("is_final_step")]
    public bool IsFinalStep { get; set; }

    [Column("action_type")]
    [StringLength(50)]
    public string? ActionType { get; set; }

    [ForeignKey("RoleId")]
    [InverseProperty("WorkflowstepRolemappings")]
    public virtual Role Role { get; set; } = null!;

    [ForeignKey("SchemeId")]
    [InverseProperty("WorkflowstepRolemappings")]
    public virtual Scheme Scheme { get; set; } = null!;
}
