using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("user_role_scheme_office_mappings")]
[Index("Id", Name = "user_role_scheme_office_mappings_id_index")]
[Index("OfficeId", Name = "user_role_scheme_office_mappings_office_id_index")]
[Index("UserId", Name = "user_role_scheme_office_mappings_user_id_index")]
public partial class UserRoleSchemeOfficeMapping
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("user_id")]
    public long UserId { get; set; }

    [Column("role_id")]
    public int RoleId { get; set; }

    [Column("office_id")]
    public long OfficeId { get; set; }

    [Column("scheme_id")]
    public long SchemeId { get; set; }

    [Column("is_active")]
    public short IsActive { get; set; }

    [ForeignKey("OfficeId")]
    [InverseProperty("UserRoleSchemeOfficeMappings")]
    public virtual OfficeMaster Office { get; set; } = null!;

    [ForeignKey("RoleId")]
    [InverseProperty("UserRoleSchemeOfficeMappings")]
    public virtual Role Role { get; set; } = null!;

    [ForeignKey("SchemeId")]
    [InverseProperty("UserRoleSchemeOfficeMappings")]
    public virtual Scheme Scheme { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("UserRoleSchemeOfficeMappings")]
    public virtual User User { get; set; } = null!;
}
