using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("codemasters")]
[Index("Code", Name = "codemasters_code_unique", IsUnique = true)]
[Index("Id", Name = "codemasters_id_index")]
public partial class Codemaster
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("short_name")]
    [StringLength(255)]
    public string ShortName { get; set; } = null!;

    [Column("parent_id")]
    public short? ParentId { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_active")]
    public short IsActive { get; set; }

    [Required]
    [Column("code")]
    public int? Code { get; set; }

    [Column("rank")]
    public short? Rank { get; set; }

    [Column("parent_short_code")]
    [StringLength(255)]
    public string? ParentShortCode { get; set; }

    [InverseProperty("OpTypeNavigation")]
    public virtual ICollection<AcceptRejectInfo> AcceptRejectInfoOpTypeNavigations { get; set; } = new List<AcceptRejectInfo>();

    [InverseProperty("RevertReasonCause")]
    public virtual ICollection<AcceptRejectInfo> AcceptRejectInfoRevertReasonCauses { get; set; } = new List<AcceptRejectInfo>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdDefault> BpdDefaultCasteNavigations { get; set; } = new List<BpdDefault>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdDefault> BpdDefaultMaritalStatusNavigations { get; set; } = new List<BpdDefault>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdDefault> BpdDefaultNextLevelRoles { get; set; } = new List<BpdDefault>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS10C10> BpdS10C10CasteNavigations { get; set; } = new List<BpdS10C10>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS10C10> BpdS10C10MaritalStatusNavigations { get; set; } = new List<BpdS10C10>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS10C10> BpdS10C10NextLevelRoles { get; set; } = new List<BpdS10C10>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS10C1> BpdS10C1CasteNavigations { get; set; } = new List<BpdS10C1>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS10C1> BpdS10C1MaritalStatusNavigations { get; set; } = new List<BpdS10C1>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS10C1> BpdS10C1NextLevelRoles { get; set; } = new List<BpdS10C1>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS10C2> BpdS10C2CasteNavigations { get; set; } = new List<BpdS10C2>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS10C2> BpdS10C2MaritalStatusNavigations { get; set; } = new List<BpdS10C2>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS10C2> BpdS10C2NextLevelRoles { get; set; } = new List<BpdS10C2>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS10Default> BpdS10DefaultCasteNavigations { get; set; } = new List<BpdS10Default>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS10Default> BpdS10DefaultMaritalStatusNavigations { get; set; } = new List<BpdS10Default>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS10Default> BpdS10DefaultNextLevelRoles { get; set; } = new List<BpdS10Default>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS11C10> BpdS11C10CasteNavigations { get; set; } = new List<BpdS11C10>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS11C10> BpdS11C10MaritalStatusNavigations { get; set; } = new List<BpdS11C10>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS11C10> BpdS11C10NextLevelRoles { get; set; } = new List<BpdS11C10>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS11C1> BpdS11C1CasteNavigations { get; set; } = new List<BpdS11C1>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS11C1> BpdS11C1MaritalStatusNavigations { get; set; } = new List<BpdS11C1>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS11C1> BpdS11C1NextLevelRoles { get; set; } = new List<BpdS11C1>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS11C2> BpdS11C2CasteNavigations { get; set; } = new List<BpdS11C2>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS11C2> BpdS11C2MaritalStatusNavigations { get; set; } = new List<BpdS11C2>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS11C2> BpdS11C2NextLevelRoles { get; set; } = new List<BpdS11C2>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS11Default> BpdS11DefaultCasteNavigations { get; set; } = new List<BpdS11Default>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS11Default> BpdS11DefaultMaritalStatusNavigations { get; set; } = new List<BpdS11Default>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS11Default> BpdS11DefaultNextLevelRoles { get; set; } = new List<BpdS11Default>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS13C10> BpdS13C10CasteNavigations { get; set; } = new List<BpdS13C10>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS13C10> BpdS13C10MaritalStatusNavigations { get; set; } = new List<BpdS13C10>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS13C10> BpdS13C10NextLevelRoles { get; set; } = new List<BpdS13C10>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS13C1> BpdS13C1CasteNavigations { get; set; } = new List<BpdS13C1>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS13C1> BpdS13C1MaritalStatusNavigations { get; set; } = new List<BpdS13C1>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS13C1> BpdS13C1NextLevelRoles { get; set; } = new List<BpdS13C1>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS13C2> BpdS13C2CasteNavigations { get; set; } = new List<BpdS13C2>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS13C2> BpdS13C2MaritalStatusNavigations { get; set; } = new List<BpdS13C2>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS13C2> BpdS13C2NextLevelRoles { get; set; } = new List<BpdS13C2>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS13Default> BpdS13DefaultCasteNavigations { get; set; } = new List<BpdS13Default>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS13Default> BpdS13DefaultMaritalStatusNavigations { get; set; } = new List<BpdS13Default>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS13Default> BpdS13DefaultNextLevelRoles { get; set; } = new List<BpdS13Default>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS17C10> BpdS17C10CasteNavigations { get; set; } = new List<BpdS17C10>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS17C10> BpdS17C10MaritalStatusNavigations { get; set; } = new List<BpdS17C10>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS17C10> BpdS17C10NextLevelRoles { get; set; } = new List<BpdS17C10>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS17C1> BpdS17C1CasteNavigations { get; set; } = new List<BpdS17C1>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS17C1> BpdS17C1MaritalStatusNavigations { get; set; } = new List<BpdS17C1>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS17C1> BpdS17C1NextLevelRoles { get; set; } = new List<BpdS17C1>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS17C2> BpdS17C2CasteNavigations { get; set; } = new List<BpdS17C2>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS17C2> BpdS17C2MaritalStatusNavigations { get; set; } = new List<BpdS17C2>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS17C2> BpdS17C2NextLevelRoles { get; set; } = new List<BpdS17C2>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS17Default> BpdS17DefaultCasteNavigations { get; set; } = new List<BpdS17Default>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS17Default> BpdS17DefaultMaritalStatusNavigations { get; set; } = new List<BpdS17Default>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS17Default> BpdS17DefaultNextLevelRoles { get; set; } = new List<BpdS17Default>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS19C10> BpdS19C10CasteNavigations { get; set; } = new List<BpdS19C10>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS19C10> BpdS19C10MaritalStatusNavigations { get; set; } = new List<BpdS19C10>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS19C10> BpdS19C10NextLevelRoles { get; set; } = new List<BpdS19C10>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS19C1> BpdS19C1CasteNavigations { get; set; } = new List<BpdS19C1>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS19C1> BpdS19C1MaritalStatusNavigations { get; set; } = new List<BpdS19C1>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS19C1> BpdS19C1NextLevelRoles { get; set; } = new List<BpdS19C1>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS19C2> BpdS19C2CasteNavigations { get; set; } = new List<BpdS19C2>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS19C2> BpdS19C2MaritalStatusNavigations { get; set; } = new List<BpdS19C2>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS19C2> BpdS19C2NextLevelRoles { get; set; } = new List<BpdS19C2>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS19Default> BpdS19DefaultCasteNavigations { get; set; } = new List<BpdS19Default>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS19Default> BpdS19DefaultMaritalStatusNavigations { get; set; } = new List<BpdS19Default>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS19Default> BpdS19DefaultNextLevelRoles { get; set; } = new List<BpdS19Default>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS1C10> BpdS1C10CasteNavigations { get; set; } = new List<BpdS1C10>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS1C10> BpdS1C10MaritalStatusNavigations { get; set; } = new List<BpdS1C10>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS1C10> BpdS1C10NextLevelRoles { get; set; } = new List<BpdS1C10>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS1C1> BpdS1C1CasteNavigations { get; set; } = new List<BpdS1C1>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS1C1> BpdS1C1MaritalStatusNavigations { get; set; } = new List<BpdS1C1>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS1C1> BpdS1C1NextLevelRoles { get; set; } = new List<BpdS1C1>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS1C2> BpdS1C2CasteNavigations { get; set; } = new List<BpdS1C2>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS1C2> BpdS1C2MaritalStatusNavigations { get; set; } = new List<BpdS1C2>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS1C2> BpdS1C2NextLevelRoles { get; set; } = new List<BpdS1C2>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS1Default> BpdS1DefaultCasteNavigations { get; set; } = new List<BpdS1Default>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS1Default> BpdS1DefaultMaritalStatusNavigations { get; set; } = new List<BpdS1Default>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS1Default> BpdS1DefaultNextLevelRoles { get; set; } = new List<BpdS1Default>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS20C10> BpdS20C10CasteNavigations { get; set; } = new List<BpdS20C10>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS20C10> BpdS20C10MaritalStatusNavigations { get; set; } = new List<BpdS20C10>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS20C10> BpdS20C10NextLevelRoles { get; set; } = new List<BpdS20C10>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS20C1> BpdS20C1CasteNavigations { get; set; } = new List<BpdS20C1>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS20C1> BpdS20C1MaritalStatusNavigations { get; set; } = new List<BpdS20C1>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS20C1> BpdS20C1NextLevelRoles { get; set; } = new List<BpdS20C1>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS20C2> BpdS20C2CasteNavigations { get; set; } = new List<BpdS20C2>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS20C2> BpdS20C2MaritalStatusNavigations { get; set; } = new List<BpdS20C2>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS20C2> BpdS20C2NextLevelRoles { get; set; } = new List<BpdS20C2>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS20Default> BpdS20DefaultCasteNavigations { get; set; } = new List<BpdS20Default>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS20Default> BpdS20DefaultMaritalStatusNavigations { get; set; } = new List<BpdS20Default>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS20Default> BpdS20DefaultNextLevelRoles { get; set; } = new List<BpdS20Default>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS2C10> BpdS2C10CasteNavigations { get; set; } = new List<BpdS2C10>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS2C10> BpdS2C10MaritalStatusNavigations { get; set; } = new List<BpdS2C10>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS2C10> BpdS2C10NextLevelRoles { get; set; } = new List<BpdS2C10>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS2C1> BpdS2C1CasteNavigations { get; set; } = new List<BpdS2C1>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS2C1> BpdS2C1MaritalStatusNavigations { get; set; } = new List<BpdS2C1>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS2C1> BpdS2C1NextLevelRoles { get; set; } = new List<BpdS2C1>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS2C2> BpdS2C2CasteNavigations { get; set; } = new List<BpdS2C2>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS2C2> BpdS2C2MaritalStatusNavigations { get; set; } = new List<BpdS2C2>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS2C2> BpdS2C2NextLevelRoles { get; set; } = new List<BpdS2C2>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS2Default> BpdS2DefaultCasteNavigations { get; set; } = new List<BpdS2Default>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS2Default> BpdS2DefaultMaritalStatusNavigations { get; set; } = new List<BpdS2Default>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS2Default> BpdS2DefaultNextLevelRoles { get; set; } = new List<BpdS2Default>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS3C10> BpdS3C10CasteNavigations { get; set; } = new List<BpdS3C10>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS3C10> BpdS3C10MaritalStatusNavigations { get; set; } = new List<BpdS3C10>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS3C10> BpdS3C10NextLevelRoles { get; set; } = new List<BpdS3C10>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS3C1> BpdS3C1CasteNavigations { get; set; } = new List<BpdS3C1>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS3C1> BpdS3C1MaritalStatusNavigations { get; set; } = new List<BpdS3C1>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS3C1> BpdS3C1NextLevelRoles { get; set; } = new List<BpdS3C1>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS3C2> BpdS3C2CasteNavigations { get; set; } = new List<BpdS3C2>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS3C2> BpdS3C2MaritalStatusNavigations { get; set; } = new List<BpdS3C2>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS3C2> BpdS3C2NextLevelRoles { get; set; } = new List<BpdS3C2>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS3Default> BpdS3DefaultCasteNavigations { get; set; } = new List<BpdS3Default>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS3Default> BpdS3DefaultMaritalStatusNavigations { get; set; } = new List<BpdS3Default>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS3Default> BpdS3DefaultNextLevelRoles { get; set; } = new List<BpdS3Default>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS5C10> BpdS5C10CasteNavigations { get; set; } = new List<BpdS5C10>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS5C10> BpdS5C10MaritalStatusNavigations { get; set; } = new List<BpdS5C10>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS5C10> BpdS5C10NextLevelRoles { get; set; } = new List<BpdS5C10>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS5C1> BpdS5C1CasteNavigations { get; set; } = new List<BpdS5C1>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS5C1> BpdS5C1MaritalStatusNavigations { get; set; } = new List<BpdS5C1>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS5C1> BpdS5C1NextLevelRoles { get; set; } = new List<BpdS5C1>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS5C2> BpdS5C2CasteNavigations { get; set; } = new List<BpdS5C2>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS5C2> BpdS5C2MaritalStatusNavigations { get; set; } = new List<BpdS5C2>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS5C2> BpdS5C2NextLevelRoles { get; set; } = new List<BpdS5C2>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS5Default> BpdS5DefaultCasteNavigations { get; set; } = new List<BpdS5Default>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS5Default> BpdS5DefaultMaritalStatusNavigations { get; set; } = new List<BpdS5Default>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS5Default> BpdS5DefaultNextLevelRoles { get; set; } = new List<BpdS5Default>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS6C10> BpdS6C10CasteNavigations { get; set; } = new List<BpdS6C10>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS6C10> BpdS6C10MaritalStatusNavigations { get; set; } = new List<BpdS6C10>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS6C10> BpdS6C10NextLevelRoles { get; set; } = new List<BpdS6C10>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS6C1> BpdS6C1CasteNavigations { get; set; } = new List<BpdS6C1>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS6C1> BpdS6C1MaritalStatusNavigations { get; set; } = new List<BpdS6C1>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS6C1> BpdS6C1NextLevelRoles { get; set; } = new List<BpdS6C1>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS6C2> BpdS6C2CasteNavigations { get; set; } = new List<BpdS6C2>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS6C2> BpdS6C2MaritalStatusNavigations { get; set; } = new List<BpdS6C2>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS6C2> BpdS6C2NextLevelRoles { get; set; } = new List<BpdS6C2>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS6Default> BpdS6DefaultCasteNavigations { get; set; } = new List<BpdS6Default>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS6Default> BpdS6DefaultMaritalStatusNavigations { get; set; } = new List<BpdS6Default>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS6Default> BpdS6DefaultNextLevelRoles { get; set; } = new List<BpdS6Default>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS7C10> BpdS7C10CasteNavigations { get; set; } = new List<BpdS7C10>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS7C10> BpdS7C10MaritalStatusNavigations { get; set; } = new List<BpdS7C10>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS7C10> BpdS7C10NextLevelRoles { get; set; } = new List<BpdS7C10>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS7C1> BpdS7C1CasteNavigations { get; set; } = new List<BpdS7C1>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS7C1> BpdS7C1MaritalStatusNavigations { get; set; } = new List<BpdS7C1>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS7C1> BpdS7C1NextLevelRoles { get; set; } = new List<BpdS7C1>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS7C2> BpdS7C2CasteNavigations { get; set; } = new List<BpdS7C2>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS7C2> BpdS7C2MaritalStatusNavigations { get; set; } = new List<BpdS7C2>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS7C2> BpdS7C2NextLevelRoles { get; set; } = new List<BpdS7C2>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS7Default> BpdS7DefaultCasteNavigations { get; set; } = new List<BpdS7Default>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS7Default> BpdS7DefaultMaritalStatusNavigations { get; set; } = new List<BpdS7Default>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS7Default> BpdS7DefaultNextLevelRoles { get; set; } = new List<BpdS7Default>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS8C10> BpdS8C10CasteNavigations { get; set; } = new List<BpdS8C10>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS8C10> BpdS8C10MaritalStatusNavigations { get; set; } = new List<BpdS8C10>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS8C10> BpdS8C10NextLevelRoles { get; set; } = new List<BpdS8C10>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS8C1> BpdS8C1CasteNavigations { get; set; } = new List<BpdS8C1>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS8C1> BpdS8C1MaritalStatusNavigations { get; set; } = new List<BpdS8C1>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS8C1> BpdS8C1NextLevelRoles { get; set; } = new List<BpdS8C1>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS8C2> BpdS8C2CasteNavigations { get; set; } = new List<BpdS8C2>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS8C2> BpdS8C2MaritalStatusNavigations { get; set; } = new List<BpdS8C2>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS8C2> BpdS8C2NextLevelRoles { get; set; } = new List<BpdS8C2>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS8Default> BpdS8DefaultCasteNavigations { get; set; } = new List<BpdS8Default>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS8Default> BpdS8DefaultMaritalStatusNavigations { get; set; } = new List<BpdS8Default>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS8Default> BpdS8DefaultNextLevelRoles { get; set; } = new List<BpdS8Default>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS9C10> BpdS9C10CasteNavigations { get; set; } = new List<BpdS9C10>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS9C10> BpdS9C10MaritalStatusNavigations { get; set; } = new List<BpdS9C10>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS9C10> BpdS9C10NextLevelRoles { get; set; } = new List<BpdS9C10>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS9C1> BpdS9C1CasteNavigations { get; set; } = new List<BpdS9C1>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS9C1> BpdS9C1MaritalStatusNavigations { get; set; } = new List<BpdS9C1>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS9C1> BpdS9C1NextLevelRoles { get; set; } = new List<BpdS9C1>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS9C2> BpdS9C2CasteNavigations { get; set; } = new List<BpdS9C2>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS9C2> BpdS9C2MaritalStatusNavigations { get; set; } = new List<BpdS9C2>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS9C2> BpdS9C2NextLevelRoles { get; set; } = new List<BpdS9C2>();

    [InverseProperty("CasteNavigation")]
    public virtual ICollection<BpdS9Default> BpdS9DefaultCasteNavigations { get; set; } = new List<BpdS9Default>();

    [InverseProperty("MaritalStatusNavigation")]
    public virtual ICollection<BpdS9Default> BpdS9DefaultMaritalStatusNavigations { get; set; } = new List<BpdS9Default>();

    [InverseProperty("NextLevelRole")]
    public virtual ICollection<BpdS9Default> BpdS9DefaultNextLevelRoles { get; set; } = new List<BpdS9Default>();

    [InverseProperty("OfficeType")]
    public virtual ICollection<OfficeMaster> OfficeMasters { get; set; } = new List<OfficeMaster>();

    [InverseProperty("OfficeType")]
    public virtual ICollection<RoleOfficeTypeMapping> RoleOfficeTypeMappings { get; set; } = new List<RoleOfficeTypeMapping>();

    [InverseProperty("DocType")]
    public virtual ICollection<SchemeAttachedDocMapping> SchemeAttachedDocMappings { get; set; } = new List<SchemeAttachedDocMapping>();
}
