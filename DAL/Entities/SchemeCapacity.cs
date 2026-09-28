using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("scheme_capacities")]
[Index("ActionType", Name = "scheme_capacities_action_type_index")]
[Index("CapacityType", Name = "scheme_capacities_capacity_type_index")]
[Index("ModelType", "ModelId", Name = "scheme_capacities_model_type_model_id_index")]
[Index("SchemeId", "EntryType", Name = "scheme_capacities_scheme_id_entry_type_index")]
public partial class SchemeCapacity
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("scheme_id")]
    public long SchemeId { get; set; }

    [Column("capacity_type")]
    public short CapacityType { get; set; }

    [Column("model_type")]
    [StringLength(255)]
    public string ModelType { get; set; } = null!;

    [Column("model_id")]
    public long ModelId { get; set; }

    [Column("entry_type")]
    public short EntryType { get; set; }

    [Column("total_capacity")]
    [StringLength(20)]
    public string TotalCapacity { get; set; } = null!;

    [Column("extra_condition")]
    public string? ExtraCondition { get; set; }

    [Column("is_active")]
    public bool IsActive { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("action_type")]
    public short? ActionType { get; set; }
}
