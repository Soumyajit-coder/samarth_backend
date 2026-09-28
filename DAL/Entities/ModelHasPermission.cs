using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Keyless]
[Table("model_has_permissions")]
[Index("ModelId", "ModelType", Name = "model_has_permissions_model_id_model_type_index")]
public partial class ModelHasPermission
{
    [Column("permission_id")]
    public long PermissionId { get; set; }

    [Column("model_type")]
    [StringLength(255)]
    public string ModelType { get; set; } = null!;

    [Column("model_id")]
    public long ModelId { get; set; }

    [Column("scheme_id")]
    public long? SchemeId { get; set; }

    [ForeignKey("PermissionId")]
    public virtual Permission Permission { get; set; } = null!;
}
