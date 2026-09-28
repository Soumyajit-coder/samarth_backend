using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("workflow_steps")]
[Index("SchemeId", "Rank", Name = "workflow_steps_scheme_id_rank_unique", IsUnique = true)]
public partial class WorkflowStep
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("rank")]
    public long Rank { get; set; }

    [Column("scheme_id")]
    public long SchemeId { get; set; }

    [Column("label")]
    [StringLength(255)]
    public string Label { get; set; } = null!;

    [Column("parent_id")]
    public long? ParentId { get; set; }

    [Column("is_first")]
    public bool IsFirst { get; set; }

    [Column("is_last")]
    public bool IsLast { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<WorkflowStep> InverseParent { get; set; } = new List<WorkflowStep>();

    [ForeignKey("ParentId")]
    [InverseProperty("InverseParent")]
    public virtual WorkflowStep? Parent { get; set; }

    [ForeignKey("SchemeId")]
    [InverseProperty("WorkflowSteps")]
    public virtual Scheme Scheme { get; set; } = null!;
}
