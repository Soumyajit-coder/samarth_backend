using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("blocks")]
[Index("DistrictId", Name = "blocks_district_id_index")]
[Index("Id", Name = "blocks_id_index")]
[Index("LgdCode", Name = "blocks_lgd_code_index")]
[Index("LgdCode", Name = "blocks_lgd_code_unique", IsUnique = true)]
[Index("Name", "DistrictId", Name = "blocks_name_district_id_index")]
[Index("RefCode", Name = "blocks_ref_code_index")]
public partial class Block
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

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

    [Column("district_id")]
    public int DistrictId { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_active")]
    public short IsActive { get; set; }

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdDefault> BcdDefaults { get; set; } = new List<BcdDefault>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS10C10> BcdS10C10s { get; set; } = new List<BcdS10C10>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS10C1> BcdS10C1s { get; set; } = new List<BcdS10C1>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS10C2> BcdS10C2s { get; set; } = new List<BcdS10C2>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS10Default> BcdS10Defaults { get; set; } = new List<BcdS10Default>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS11C10> BcdS11C10s { get; set; } = new List<BcdS11C10>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS11C1> BcdS11C1s { get; set; } = new List<BcdS11C1>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS11C2> BcdS11C2s { get; set; } = new List<BcdS11C2>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS11Default> BcdS11Defaults { get; set; } = new List<BcdS11Default>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS13C10> BcdS13C10s { get; set; } = new List<BcdS13C10>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS13C1> BcdS13C1s { get; set; } = new List<BcdS13C1>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS13C2> BcdS13C2s { get; set; } = new List<BcdS13C2>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS13Default> BcdS13Defaults { get; set; } = new List<BcdS13Default>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS17C10> BcdS17C10s { get; set; } = new List<BcdS17C10>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS17C1> BcdS17C1s { get; set; } = new List<BcdS17C1>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS17C2> BcdS17C2s { get; set; } = new List<BcdS17C2>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS17Default> BcdS17Defaults { get; set; } = new List<BcdS17Default>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS19C10> BcdS19C10s { get; set; } = new List<BcdS19C10>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS19C1> BcdS19C1s { get; set; } = new List<BcdS19C1>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS19C2> BcdS19C2s { get; set; } = new List<BcdS19C2>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS19Default> BcdS19Defaults { get; set; } = new List<BcdS19Default>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS1C10> BcdS1C10s { get; set; } = new List<BcdS1C10>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS1C1> BcdS1C1s { get; set; } = new List<BcdS1C1>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS1C2> BcdS1C2s { get; set; } = new List<BcdS1C2>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS1Default> BcdS1Defaults { get; set; } = new List<BcdS1Default>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS20C10> BcdS20C10s { get; set; } = new List<BcdS20C10>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS20C1> BcdS20C1s { get; set; } = new List<BcdS20C1>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS20C2> BcdS20C2s { get; set; } = new List<BcdS20C2>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS20Default> BcdS20Defaults { get; set; } = new List<BcdS20Default>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS2C10> BcdS2C10s { get; set; } = new List<BcdS2C10>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS2C1> BcdS2C1s { get; set; } = new List<BcdS2C1>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS2C2> BcdS2C2s { get; set; } = new List<BcdS2C2>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS2Default> BcdS2Defaults { get; set; } = new List<BcdS2Default>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS3C10> BcdS3C10s { get; set; } = new List<BcdS3C10>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS3C1> BcdS3C1s { get; set; } = new List<BcdS3C1>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS3C2> BcdS3C2s { get; set; } = new List<BcdS3C2>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS3Default> BcdS3Defaults { get; set; } = new List<BcdS3Default>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS5C10> BcdS5C10s { get; set; } = new List<BcdS5C10>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS5C1> BcdS5C1s { get; set; } = new List<BcdS5C1>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS5C2> BcdS5C2s { get; set; } = new List<BcdS5C2>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS5Default> BcdS5Defaults { get; set; } = new List<BcdS5Default>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS6C10> BcdS6C10s { get; set; } = new List<BcdS6C10>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS6C1> BcdS6C1s { get; set; } = new List<BcdS6C1>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS6C2> BcdS6C2s { get; set; } = new List<BcdS6C2>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS6Default> BcdS6Defaults { get; set; } = new List<BcdS6Default>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS7C10> BcdS7C10s { get; set; } = new List<BcdS7C10>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS7C1> BcdS7C1s { get; set; } = new List<BcdS7C1>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS7C2> BcdS7C2s { get; set; } = new List<BcdS7C2>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS7Default> BcdS7Defaults { get; set; } = new List<BcdS7Default>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS8C10> BcdS8C10s { get; set; } = new List<BcdS8C10>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS8C1> BcdS8C1s { get; set; } = new List<BcdS8C1>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS8C2> BcdS8C2s { get; set; } = new List<BcdS8C2>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS8Default> BcdS8Defaults { get; set; } = new List<BcdS8Default>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS9C10> BcdS9C10s { get; set; } = new List<BcdS9C10>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS9C1> BcdS9C1s { get; set; } = new List<BcdS9C1>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS9C2> BcdS9C2s { get; set; } = new List<BcdS9C2>();

    [InverseProperty("BlockNavigation")]
    public virtual ICollection<BcdS9Default> BcdS9Defaults { get; set; } = new List<BcdS9Default>();

    [ForeignKey("DistrictId")]
    [InverseProperty("Blocks")]
    public virtual District District { get; set; } = null!;

    [InverseProperty("Block")]
    public virtual ICollection<OfficeMaster> OfficeMasters { get; set; } = new List<OfficeMaster>();

    [InverseProperty("Block")]
    public virtual ICollection<Panchayat> Panchayats { get; set; } = new List<Panchayat>();
}
