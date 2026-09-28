using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("schemes")]
[Index("DepartmentId", Name = "schemes_department_id_index")]
[Index("Name", "ShortName", Name = "schemes_name_short_name_index")]
public partial class Scheme
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("short_name")]
    [StringLength(255)]
    public string ShortName { get; set; } = null!;

    [Column("description")]
    [StringLength(255)]
    public string? Description { get; set; }

    [Column("department_id")]
    public short DepartmentId { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_active")]
    public short IsActive { get; set; }

    [Column("min_age")]
    public short? MinAge { get; set; }

    [Column("max_age")]
    public short? MaxAge { get; set; }

    [Column("base_amount")]
    [Precision(10, 2)]
    public decimal? BaseAmount { get; set; }

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdDefault> BbdDefaults { get; set; } = new List<BbdDefault>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS10C10> BbdS10C10s { get; set; } = new List<BbdS10C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS10C1> BbdS10C1s { get; set; } = new List<BbdS10C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS10C2> BbdS10C2s { get; set; } = new List<BbdS10C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS10Default> BbdS10Defaults { get; set; } = new List<BbdS10Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS11C10> BbdS11C10s { get; set; } = new List<BbdS11C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS11C1> BbdS11C1s { get; set; } = new List<BbdS11C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS11C2> BbdS11C2s { get; set; } = new List<BbdS11C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS11Default> BbdS11Defaults { get; set; } = new List<BbdS11Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS13C10> BbdS13C10s { get; set; } = new List<BbdS13C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS13C1> BbdS13C1s { get; set; } = new List<BbdS13C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS13C2> BbdS13C2s { get; set; } = new List<BbdS13C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS13Default> BbdS13Defaults { get; set; } = new List<BbdS13Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS17C10> BbdS17C10s { get; set; } = new List<BbdS17C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS17C1> BbdS17C1s { get; set; } = new List<BbdS17C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS17C2> BbdS17C2s { get; set; } = new List<BbdS17C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS17Default> BbdS17Defaults { get; set; } = new List<BbdS17Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS19C10> BbdS19C10s { get; set; } = new List<BbdS19C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS19C1> BbdS19C1s { get; set; } = new List<BbdS19C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS19C2> BbdS19C2s { get; set; } = new List<BbdS19C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS19Default> BbdS19Defaults { get; set; } = new List<BbdS19Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS1C10> BbdS1C10s { get; set; } = new List<BbdS1C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS1C1> BbdS1C1s { get; set; } = new List<BbdS1C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS1C2> BbdS1C2s { get; set; } = new List<BbdS1C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS1Default> BbdS1Defaults { get; set; } = new List<BbdS1Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS20C10> BbdS20C10s { get; set; } = new List<BbdS20C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS20C1> BbdS20C1s { get; set; } = new List<BbdS20C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS20C2> BbdS20C2s { get; set; } = new List<BbdS20C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS20Default> BbdS20Defaults { get; set; } = new List<BbdS20Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS2C10> BbdS2C10s { get; set; } = new List<BbdS2C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS2C1> BbdS2C1s { get; set; } = new List<BbdS2C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS2C2> BbdS2C2s { get; set; } = new List<BbdS2C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS2Default> BbdS2Defaults { get; set; } = new List<BbdS2Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS3C10> BbdS3C10s { get; set; } = new List<BbdS3C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS3C1> BbdS3C1s { get; set; } = new List<BbdS3C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS3C2> BbdS3C2s { get; set; } = new List<BbdS3C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS3Default> BbdS3Defaults { get; set; } = new List<BbdS3Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS5C10> BbdS5C10s { get; set; } = new List<BbdS5C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS5C1> BbdS5C1s { get; set; } = new List<BbdS5C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS5C2> BbdS5C2s { get; set; } = new List<BbdS5C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS5Default> BbdS5Defaults { get; set; } = new List<BbdS5Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS6C10> BbdS6C10s { get; set; } = new List<BbdS6C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS6C1> BbdS6C1s { get; set; } = new List<BbdS6C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS6C2> BbdS6C2s { get; set; } = new List<BbdS6C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS6Default> BbdS6Defaults { get; set; } = new List<BbdS6Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS7C10> BbdS7C10s { get; set; } = new List<BbdS7C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS7C1> BbdS7C1s { get; set; } = new List<BbdS7C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS7C2> BbdS7C2s { get; set; } = new List<BbdS7C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS7Default> BbdS7Defaults { get; set; } = new List<BbdS7Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS8C10> BbdS8C10s { get; set; } = new List<BbdS8C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS8C1> BbdS8C1s { get; set; } = new List<BbdS8C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS8C2> BbdS8C2s { get; set; } = new List<BbdS8C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS8Default> BbdS8Defaults { get; set; } = new List<BbdS8Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS9C10> BbdS9C10s { get; set; } = new List<BbdS9C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS9C1> BbdS9C1s { get; set; } = new List<BbdS9C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS9C2> BbdS9C2s { get; set; } = new List<BbdS9C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BbdS9Default> BbdS9Defaults { get; set; } = new List<BbdS9Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdDefault> BcdDefaults { get; set; } = new List<BcdDefault>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS10C10> BcdS10C10s { get; set; } = new List<BcdS10C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS10C1> BcdS10C1s { get; set; } = new List<BcdS10C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS10C2> BcdS10C2s { get; set; } = new List<BcdS10C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS10Default> BcdS10Defaults { get; set; } = new List<BcdS10Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS11C10> BcdS11C10s { get; set; } = new List<BcdS11C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS11C1> BcdS11C1s { get; set; } = new List<BcdS11C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS11C2> BcdS11C2s { get; set; } = new List<BcdS11C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS11Default> BcdS11Defaults { get; set; } = new List<BcdS11Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS13C10> BcdS13C10s { get; set; } = new List<BcdS13C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS13C1> BcdS13C1s { get; set; } = new List<BcdS13C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS13C2> BcdS13C2s { get; set; } = new List<BcdS13C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS13Default> BcdS13Defaults { get; set; } = new List<BcdS13Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS17C10> BcdS17C10s { get; set; } = new List<BcdS17C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS17C1> BcdS17C1s { get; set; } = new List<BcdS17C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS17C2> BcdS17C2s { get; set; } = new List<BcdS17C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS17Default> BcdS17Defaults { get; set; } = new List<BcdS17Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS19C10> BcdS19C10s { get; set; } = new List<BcdS19C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS19C1> BcdS19C1s { get; set; } = new List<BcdS19C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS19C2> BcdS19C2s { get; set; } = new List<BcdS19C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS19Default> BcdS19Defaults { get; set; } = new List<BcdS19Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS1C10> BcdS1C10s { get; set; } = new List<BcdS1C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS1C1> BcdS1C1s { get; set; } = new List<BcdS1C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS1C2> BcdS1C2s { get; set; } = new List<BcdS1C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS1Default> BcdS1Defaults { get; set; } = new List<BcdS1Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS20C10> BcdS20C10s { get; set; } = new List<BcdS20C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS20C1> BcdS20C1s { get; set; } = new List<BcdS20C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS20C2> BcdS20C2s { get; set; } = new List<BcdS20C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS20Default> BcdS20Defaults { get; set; } = new List<BcdS20Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS2C10> BcdS2C10s { get; set; } = new List<BcdS2C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS2C1> BcdS2C1s { get; set; } = new List<BcdS2C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS2C2> BcdS2C2s { get; set; } = new List<BcdS2C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS2Default> BcdS2Defaults { get; set; } = new List<BcdS2Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS3C10> BcdS3C10s { get; set; } = new List<BcdS3C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS3C1> BcdS3C1s { get; set; } = new List<BcdS3C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS3C2> BcdS3C2s { get; set; } = new List<BcdS3C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS3Default> BcdS3Defaults { get; set; } = new List<BcdS3Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS5C10> BcdS5C10s { get; set; } = new List<BcdS5C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS5C1> BcdS5C1s { get; set; } = new List<BcdS5C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS5C2> BcdS5C2s { get; set; } = new List<BcdS5C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS5Default> BcdS5Defaults { get; set; } = new List<BcdS5Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS6C10> BcdS6C10s { get; set; } = new List<BcdS6C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS6C1> BcdS6C1s { get; set; } = new List<BcdS6C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS6C2> BcdS6C2s { get; set; } = new List<BcdS6C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS6Default> BcdS6Defaults { get; set; } = new List<BcdS6Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS7C10> BcdS7C10s { get; set; } = new List<BcdS7C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS7C1> BcdS7C1s { get; set; } = new List<BcdS7C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS7C2> BcdS7C2s { get; set; } = new List<BcdS7C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS7Default> BcdS7Defaults { get; set; } = new List<BcdS7Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS8C10> BcdS8C10s { get; set; } = new List<BcdS8C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS8C1> BcdS8C1s { get; set; } = new List<BcdS8C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS8C2> BcdS8C2s { get; set; } = new List<BcdS8C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS8Default> BcdS8Defaults { get; set; } = new List<BcdS8Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS9C10> BcdS9C10s { get; set; } = new List<BcdS9C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS9C1> BcdS9C1s { get; set; } = new List<BcdS9C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS9C2> BcdS9C2s { get; set; } = new List<BcdS9C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BcdS9Default> BcdS9Defaults { get; set; } = new List<BcdS9Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddDefault> BddDefaults { get; set; } = new List<BddDefault>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS10C10> BddS10C10s { get; set; } = new List<BddS10C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS10C1> BddS10C1s { get; set; } = new List<BddS10C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS10C2> BddS10C2s { get; set; } = new List<BddS10C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS10Default> BddS10Defaults { get; set; } = new List<BddS10Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS11C10> BddS11C10s { get; set; } = new List<BddS11C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS11C1> BddS11C1s { get; set; } = new List<BddS11C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS11C2> BddS11C2s { get; set; } = new List<BddS11C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS11Default> BddS11Defaults { get; set; } = new List<BddS11Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS13C10> BddS13C10s { get; set; } = new List<BddS13C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS13C1> BddS13C1s { get; set; } = new List<BddS13C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS13C2> BddS13C2s { get; set; } = new List<BddS13C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS13Default> BddS13Defaults { get; set; } = new List<BddS13Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS17C10> BddS17C10s { get; set; } = new List<BddS17C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS17C1> BddS17C1s { get; set; } = new List<BddS17C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS17C2> BddS17C2s { get; set; } = new List<BddS17C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS17Default> BddS17Defaults { get; set; } = new List<BddS17Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS19C10> BddS19C10s { get; set; } = new List<BddS19C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS19C1> BddS19C1s { get; set; } = new List<BddS19C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS19C2> BddS19C2s { get; set; } = new List<BddS19C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS19Default> BddS19Defaults { get; set; } = new List<BddS19Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS1C10> BddS1C10s { get; set; } = new List<BddS1C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS1C1> BddS1C1s { get; set; } = new List<BddS1C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS1C2> BddS1C2s { get; set; } = new List<BddS1C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS1Default> BddS1Defaults { get; set; } = new List<BddS1Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS20C10> BddS20C10s { get; set; } = new List<BddS20C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS20C1> BddS20C1s { get; set; } = new List<BddS20C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS20C2> BddS20C2s { get; set; } = new List<BddS20C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS20Default> BddS20Defaults { get; set; } = new List<BddS20Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS2C10> BddS2C10s { get; set; } = new List<BddS2C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS2C1> BddS2C1s { get; set; } = new List<BddS2C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS2C2> BddS2C2s { get; set; } = new List<BddS2C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS2Default> BddS2Defaults { get; set; } = new List<BddS2Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS3C10> BddS3C10s { get; set; } = new List<BddS3C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS3C1> BddS3C1s { get; set; } = new List<BddS3C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS3C2> BddS3C2s { get; set; } = new List<BddS3C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS3Default> BddS3Defaults { get; set; } = new List<BddS3Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS5C10> BddS5C10s { get; set; } = new List<BddS5C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS5C1> BddS5C1s { get; set; } = new List<BddS5C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS5C2> BddS5C2s { get; set; } = new List<BddS5C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS5Default> BddS5Defaults { get; set; } = new List<BddS5Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS6C10> BddS6C10s { get; set; } = new List<BddS6C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS6C1> BddS6C1s { get; set; } = new List<BddS6C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS6C2> BddS6C2s { get; set; } = new List<BddS6C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS6Default> BddS6Defaults { get; set; } = new List<BddS6Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS7C10> BddS7C10s { get; set; } = new List<BddS7C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS7C1> BddS7C1s { get; set; } = new List<BddS7C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS7C2> BddS7C2s { get; set; } = new List<BddS7C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS7Default> BddS7Defaults { get; set; } = new List<BddS7Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS8C10> BddS8C10s { get; set; } = new List<BddS8C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS8C1> BddS8C1s { get; set; } = new List<BddS8C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS8C2> BddS8C2s { get; set; } = new List<BddS8C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS8Default> BddS8Defaults { get; set; } = new List<BddS8Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS9C10> BddS9C10s { get; set; } = new List<BddS9C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS9C1> BddS9C1s { get; set; } = new List<BddS9C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS9C2> BddS9C2s { get; set; } = new List<BddS9C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BddS9Default> BddS9Defaults { get; set; } = new List<BddS9Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BeneficiaryLandDetail> BeneficiaryLandDetails { get; set; } = new List<BeneficiaryLandDetail>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdDefault> BpdDefaults { get; set; } = new List<BpdDefault>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS10C10> BpdS10C10s { get; set; } = new List<BpdS10C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS10C1> BpdS10C1s { get; set; } = new List<BpdS10C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS10C2> BpdS10C2s { get; set; } = new List<BpdS10C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS10Default> BpdS10Defaults { get; set; } = new List<BpdS10Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS11C10> BpdS11C10s { get; set; } = new List<BpdS11C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS11C1> BpdS11C1s { get; set; } = new List<BpdS11C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS11C2> BpdS11C2s { get; set; } = new List<BpdS11C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS11Default> BpdS11Defaults { get; set; } = new List<BpdS11Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS13C10> BpdS13C10s { get; set; } = new List<BpdS13C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS13C1> BpdS13C1s { get; set; } = new List<BpdS13C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS13C2> BpdS13C2s { get; set; } = new List<BpdS13C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS13Default> BpdS13Defaults { get; set; } = new List<BpdS13Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS17C10> BpdS17C10s { get; set; } = new List<BpdS17C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS17C1> BpdS17C1s { get; set; } = new List<BpdS17C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS17C2> BpdS17C2s { get; set; } = new List<BpdS17C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS17Default> BpdS17Defaults { get; set; } = new List<BpdS17Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS19C10> BpdS19C10s { get; set; } = new List<BpdS19C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS19C1> BpdS19C1s { get; set; } = new List<BpdS19C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS19C2> BpdS19C2s { get; set; } = new List<BpdS19C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS19Default> BpdS19Defaults { get; set; } = new List<BpdS19Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS1C10> BpdS1C10s { get; set; } = new List<BpdS1C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS1C1> BpdS1C1s { get; set; } = new List<BpdS1C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS1C2> BpdS1C2s { get; set; } = new List<BpdS1C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS1Default> BpdS1Defaults { get; set; } = new List<BpdS1Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS20C10> BpdS20C10s { get; set; } = new List<BpdS20C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS20C1> BpdS20C1s { get; set; } = new List<BpdS20C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS20C2> BpdS20C2s { get; set; } = new List<BpdS20C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS20Default> BpdS20Defaults { get; set; } = new List<BpdS20Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS2C10> BpdS2C10s { get; set; } = new List<BpdS2C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS2C1> BpdS2C1s { get; set; } = new List<BpdS2C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS2C2> BpdS2C2s { get; set; } = new List<BpdS2C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS2Default> BpdS2Defaults { get; set; } = new List<BpdS2Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS3C10> BpdS3C10s { get; set; } = new List<BpdS3C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS3C1> BpdS3C1s { get; set; } = new List<BpdS3C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS3C2> BpdS3C2s { get; set; } = new List<BpdS3C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS3Default> BpdS3Defaults { get; set; } = new List<BpdS3Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS5C10> BpdS5C10s { get; set; } = new List<BpdS5C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS5C1> BpdS5C1s { get; set; } = new List<BpdS5C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS5C2> BpdS5C2s { get; set; } = new List<BpdS5C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS5Default> BpdS5Defaults { get; set; } = new List<BpdS5Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS6C10> BpdS6C10s { get; set; } = new List<BpdS6C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS6C1> BpdS6C1s { get; set; } = new List<BpdS6C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS6C2> BpdS6C2s { get; set; } = new List<BpdS6C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS6Default> BpdS6Defaults { get; set; } = new List<BpdS6Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS7C10> BpdS7C10s { get; set; } = new List<BpdS7C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS7C1> BpdS7C1s { get; set; } = new List<BpdS7C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS7C2> BpdS7C2s { get; set; } = new List<BpdS7C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS7Default> BpdS7Defaults { get; set; } = new List<BpdS7Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS8C10> BpdS8C10s { get; set; } = new List<BpdS8C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS8C1> BpdS8C1s { get; set; } = new List<BpdS8C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS8C2> BpdS8C2s { get; set; } = new List<BpdS8C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS8Default> BpdS8Defaults { get; set; } = new List<BpdS8Default>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS9C10> BpdS9C10s { get; set; } = new List<BpdS9C10>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS9C1> BpdS9C1s { get; set; } = new List<BpdS9C1>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS9C2> BpdS9C2s { get; set; } = new List<BpdS9C2>();

    [InverseProperty("Scheme")]
    public virtual ICollection<BpdS9Default> BpdS9Defaults { get; set; } = new List<BpdS9Default>();

    [ForeignKey("DepartmentId")]
    [InverseProperty("Schemes")]
    public virtual Department Department { get; set; } = null!;

    [InverseProperty("Scheme")]
    public virtual ICollection<DynamicWorkflowRequest> DynamicWorkflowRequests { get; set; } = new List<DynamicWorkflowRequest>();

    [InverseProperty("Scheme")]
    public virtual ICollection<DynamicWorkflowSchemeModule> DynamicWorkflowSchemeModules { get; set; } = new List<DynamicWorkflowSchemeModule>();

    [InverseProperty("Scheme")]
    public virtual ICollection<LandDetail> LandDetails { get; set; } = new List<LandDetail>();

    [InverseProperty("Scheme")]
    public virtual ICollection<SchemeAttachedDocMapping> SchemeAttachedDocMappings { get; set; } = new List<SchemeAttachedDocMapping>();

    [InverseProperty("Scheme")]
    public virtual ICollection<UserRoleSchemeOfficeMapping> UserRoleSchemeOfficeMappings { get; set; } = new List<UserRoleSchemeOfficeMapping>();

    [InverseProperty("Scheme")]
    public virtual ICollection<WorkflowStep> WorkflowSteps { get; set; } = new List<WorkflowStep>();

    [InverseProperty("Scheme")]
    public virtual ICollection<WorkflowstepRolemapping> WorkflowstepRolemappings { get; set; } = new List<WorkflowstepRolemapping>();
}
