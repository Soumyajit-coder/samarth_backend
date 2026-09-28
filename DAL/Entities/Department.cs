using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("departments")]
[Index("Name", "ShortName", Name = "departments_name_short_name_index")]
public partial class Department
{
    [Key]
    [Column("id")]
    public short Id { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("short_name")]
    [StringLength(255)]
    public string ShortName { get; set; } = null!;

    [Column("logo")]
    [StringLength(255)]
    public string? Logo { get; set; }

    [Column("state_id")]
    public short StateId { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_active")]
    public short IsActive { get; set; }

    [InverseProperty("Department")]
    public virtual ICollection<Scheme> Schemes { get; set; } = new List<Scheme>();

    [ForeignKey("StateId")]
    [InverseProperty("Departments")]
    public virtual State State { get; set; } = null!;

    [InverseProperty("Department")]
    public virtual ICollection<UserPersonal> UserPersonals { get; set; } = new List<UserPersonal>();
}
