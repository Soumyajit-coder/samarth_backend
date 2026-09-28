using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("ifsccodemasters")]
[Index("BankmasterId", Name = "ifsccodemasters_bankmaster_id_index")]
[Index("Code", Name = "ifsccodemasters_code_index")]
[Index("Code", Name = "ifsccodemasters_code_unique", IsUnique = true)]
[Index("Id", Name = "ifsccodemasters_id_index")]
[Index("StateId", Name = "ifsccodemasters_state_id_index")]
public partial class Ifsccodemaster
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("code")]
    [StringLength(11)]
    public string Code { get; set; } = null!;

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("branch")]
    [StringLength(255)]
    public string Branch { get; set; } = null!;

    [Column("state_id")]
    public short StateId { get; set; }

    [Column("bankmaster_id")]
    public long BankmasterId { get; set; }

    [Column("is_active")]
    public short IsActive { get; set; }

    [ForeignKey("BankmasterId")]
    [InverseProperty("Ifsccodemasters")]
    public virtual Bankmaster Bankmaster { get; set; } = null!;

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdDefault> BbdDefaults { get; set; } = new List<BbdDefault>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS10C10> BbdS10C10s { get; set; } = new List<BbdS10C10>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS10C1> BbdS10C1s { get; set; } = new List<BbdS10C1>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS10C2> BbdS10C2s { get; set; } = new List<BbdS10C2>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS10Default> BbdS10Defaults { get; set; } = new List<BbdS10Default>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS11C10> BbdS11C10s { get; set; } = new List<BbdS11C10>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS11C1> BbdS11C1s { get; set; } = new List<BbdS11C1>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS11C2> BbdS11C2s { get; set; } = new List<BbdS11C2>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS11Default> BbdS11Defaults { get; set; } = new List<BbdS11Default>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS13C10> BbdS13C10s { get; set; } = new List<BbdS13C10>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS13C1> BbdS13C1s { get; set; } = new List<BbdS13C1>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS13C2> BbdS13C2s { get; set; } = new List<BbdS13C2>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS13Default> BbdS13Defaults { get; set; } = new List<BbdS13Default>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS17C10> BbdS17C10s { get; set; } = new List<BbdS17C10>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS17C1> BbdS17C1s { get; set; } = new List<BbdS17C1>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS17C2> BbdS17C2s { get; set; } = new List<BbdS17C2>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS17Default> BbdS17Defaults { get; set; } = new List<BbdS17Default>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS19C10> BbdS19C10s { get; set; } = new List<BbdS19C10>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS19C1> BbdS19C1s { get; set; } = new List<BbdS19C1>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS19C2> BbdS19C2s { get; set; } = new List<BbdS19C2>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS19Default> BbdS19Defaults { get; set; } = new List<BbdS19Default>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS1C10> BbdS1C10s { get; set; } = new List<BbdS1C10>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS1C1> BbdS1C1s { get; set; } = new List<BbdS1C1>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS1C2> BbdS1C2s { get; set; } = new List<BbdS1C2>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS1Default> BbdS1Defaults { get; set; } = new List<BbdS1Default>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS20C10> BbdS20C10s { get; set; } = new List<BbdS20C10>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS20C1> BbdS20C1s { get; set; } = new List<BbdS20C1>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS20C2> BbdS20C2s { get; set; } = new List<BbdS20C2>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS20Default> BbdS20Defaults { get; set; } = new List<BbdS20Default>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS2C10> BbdS2C10s { get; set; } = new List<BbdS2C10>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS2C1> BbdS2C1s { get; set; } = new List<BbdS2C1>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS2C2> BbdS2C2s { get; set; } = new List<BbdS2C2>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS2Default> BbdS2Defaults { get; set; } = new List<BbdS2Default>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS3C10> BbdS3C10s { get; set; } = new List<BbdS3C10>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS3C1> BbdS3C1s { get; set; } = new List<BbdS3C1>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS3C2> BbdS3C2s { get; set; } = new List<BbdS3C2>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS3Default> BbdS3Defaults { get; set; } = new List<BbdS3Default>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS5C10> BbdS5C10s { get; set; } = new List<BbdS5C10>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS5C1> BbdS5C1s { get; set; } = new List<BbdS5C1>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS5C2> BbdS5C2s { get; set; } = new List<BbdS5C2>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS5Default> BbdS5Defaults { get; set; } = new List<BbdS5Default>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS6C10> BbdS6C10s { get; set; } = new List<BbdS6C10>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS6C1> BbdS6C1s { get; set; } = new List<BbdS6C1>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS6C2> BbdS6C2s { get; set; } = new List<BbdS6C2>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS6Default> BbdS6Defaults { get; set; } = new List<BbdS6Default>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS7C10> BbdS7C10s { get; set; } = new List<BbdS7C10>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS7C1> BbdS7C1s { get; set; } = new List<BbdS7C1>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS7C2> BbdS7C2s { get; set; } = new List<BbdS7C2>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS7Default> BbdS7Defaults { get; set; } = new List<BbdS7Default>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS8C10> BbdS8C10s { get; set; } = new List<BbdS8C10>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS8C1> BbdS8C1s { get; set; } = new List<BbdS8C1>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS8C2> BbdS8C2s { get; set; } = new List<BbdS8C2>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS8Default> BbdS8Defaults { get; set; } = new List<BbdS8Default>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS9C10> BbdS9C10s { get; set; } = new List<BbdS9C10>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS9C1> BbdS9C1s { get; set; } = new List<BbdS9C1>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS9C2> BbdS9C2s { get; set; } = new List<BbdS9C2>();

    [InverseProperty("IfscodeNavigation")]
    public virtual ICollection<BbdS9Default> BbdS9Defaults { get; set; } = new List<BbdS9Default>();

    [ForeignKey("StateId")]
    [InverseProperty("Ifsccodemasters")]
    public virtual State State { get; set; } = null!;
}
