using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("critical_change_masters")]
[Index("Code", Name = "critical_change_masters_code_unique", IsUnique = true)]
[Index("Id", Name = "critical_change_masters_id_index")]
public partial class CriticalChangeMaster
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

    [Column("code")]
    public short? Code { get; set; }

    [Column("is_active")]
    public short IsActive { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }
}
