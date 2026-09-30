using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("roles")]
[Index("Name", "GuardName", Name = "roles_name_guard_name_unique", IsUnique = true)]
public partial class Role
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("guard_name")]
    [StringLength(255)]
    public string GuardName { get; set; } = null!;

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("rank")]
    public short? Rank { get; set; }

    [Column("is_active")]
    public short? IsActive { get; set; }

    [InverseProperty("Role")]
    public virtual ICollection<ModelHasRole> ModelHasRoles { get; set; } = new List<ModelHasRole>();

    [InverseProperty("Role")]
    public virtual ICollection<RoleOfficeTypeMapping> RoleOfficeTypeMappings { get; set; } = new List<RoleOfficeTypeMapping>();

    [InverseProperty("Role")]
    public virtual ICollection<UserRoleSchemeOfficeMapping> UserRoleSchemeOfficeMappings { get; set; } = new List<UserRoleSchemeOfficeMapping>();

    [InverseProperty("Role")]
    public virtual ICollection<WorkflowstepRolemapping> WorkflowstepRolemappings { get; set; } = new List<WorkflowstepRolemapping>();

    [ForeignKey("RoleId")]
    [InverseProperty("Roles")]
    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}
