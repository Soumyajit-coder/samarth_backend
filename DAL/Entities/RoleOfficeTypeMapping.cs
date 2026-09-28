using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("role_office_type_mappings")]
[Index("OfficeTypeId", Name = "role_office_type_mappings_office_type_id_index")]
[Index("RoleId", Name = "role_office_type_mappings_role_id_index")]
public partial class RoleOfficeTypeMapping
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("office_type_id")]
    public int OfficeTypeId { get; set; }

    [Column("role_id")]
    public int RoleId { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("OfficeTypeId")]
    [InverseProperty("RoleOfficeTypeMappings")]
    public virtual Codemaster OfficeType { get; set; } = null!;

    [ForeignKey("RoleId")]
    [InverseProperty("RoleOfficeTypeMappings")]
    public virtual Role Role { get; set; } = null!;
}
