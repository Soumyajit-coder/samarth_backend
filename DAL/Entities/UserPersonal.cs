using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("user_personals")]
[Index("Id", Name = "user_personals_id_index")]
[Index("UserId", Name = "user_personals_user_id_index")]
public partial class UserPersonal
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("user_id")]
    public long UserId { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("full_name_as_in_aadhaar")]
    [StringLength(255)]
    public string? FullNameAsInAadhaar { get; set; }

    [Column("picture")]
    [StringLength(255)]
    public string? Picture { get; set; }

    [Column("date_hired")]
    public DateOnly? DateHired { get; set; }

    [Column("department_id")]
    public short? DepartmentId { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_active")]
    public short IsActive { get; set; }

    [ForeignKey("DepartmentId")]
    [InverseProperty("UserPersonals")]
    public virtual Department? Department { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("UserPersonals")]
    public virtual User User { get; set; } = null!;
}
