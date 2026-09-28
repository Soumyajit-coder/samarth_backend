using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("states")]
[Index("LgdCode", Name = "states_lgd_code_unique", IsUnique = true)]
[Index("Name", "StateUt", Name = "states_name_state_ut_index")]
[Index("RefCode", Name = "states_ref_code_index")]
public partial class State
{
    [Key]
    [Column("id")]
    public short Id { get; set; }

    [Column("ref_code")]
    [StringLength(50)]
    public string? RefCode { get; set; }

    [Column("lgd_code")]
    [StringLength(255)]
    public string LgdCode { get; set; } = null!;

    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("local_name")]
    [StringLength(255)]
    public string? LocalName { get; set; }

    [Column("state_ut")]
    [StringLength(255)]
    public string StateUt { get; set; } = null!;

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_active")]
    public short IsActive { get; set; }

    [InverseProperty("State")]
    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    [InverseProperty("State")]
    public virtual ICollection<District> Districts { get; set; } = new List<District>();

    [InverseProperty("State")]
    public virtual ICollection<Ifsccodemaster> Ifsccodemasters { get; set; } = new List<Ifsccodemaster>();

    [InverseProperty("State")]
    public virtual ICollection<OfficeMaster> OfficeMasters { get; set; } = new List<OfficeMaster>();
}
