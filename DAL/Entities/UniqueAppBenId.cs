using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("unique_app_ben_ids", Schema = "pension")]
[Index("BeneficiaryId", Name = "pension_unique_app_ben_ids_beneficiary_id_unique", IsUnique = true)]
public partial class UniqueAppBenId
{
    [Key]
    [Column("application_id")]
    public long ApplicationId { get; set; }

    [Column("beneficiary_id")]
    public long BeneficiaryId { get; set; }

    [Column("scheme_id")]
    public long SchemeId { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [InverseProperty("Application")]
    public virtual ICollection<BbdDefault> BbdDefaultApplications { get; set; } = new List<BbdDefault>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdDefault> BbdDefaultBeneficiaries { get; set; } = new List<BbdDefault>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS10C10> BbdS10C10Applications { get; set; } = new List<BbdS10C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS10C10> BbdS10C10Beneficiaries { get; set; } = new List<BbdS10C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS10C1> BbdS10C1Applications { get; set; } = new List<BbdS10C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS10C1> BbdS10C1Beneficiaries { get; set; } = new List<BbdS10C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS10C2> BbdS10C2Applications { get; set; } = new List<BbdS10C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS10C2> BbdS10C2Beneficiaries { get; set; } = new List<BbdS10C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS10Default> BbdS10DefaultApplications { get; set; } = new List<BbdS10Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS10Default> BbdS10DefaultBeneficiaries { get; set; } = new List<BbdS10Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS11C10> BbdS11C10Applications { get; set; } = new List<BbdS11C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS11C10> BbdS11C10Beneficiaries { get; set; } = new List<BbdS11C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS11C1> BbdS11C1Applications { get; set; } = new List<BbdS11C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS11C1> BbdS11C1Beneficiaries { get; set; } = new List<BbdS11C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS11C2> BbdS11C2Applications { get; set; } = new List<BbdS11C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS11C2> BbdS11C2Beneficiaries { get; set; } = new List<BbdS11C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS11Default> BbdS11DefaultApplications { get; set; } = new List<BbdS11Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS11Default> BbdS11DefaultBeneficiaries { get; set; } = new List<BbdS11Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS13C10> BbdS13C10Applications { get; set; } = new List<BbdS13C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS13C10> BbdS13C10Beneficiaries { get; set; } = new List<BbdS13C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS13C1> BbdS13C1Applications { get; set; } = new List<BbdS13C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS13C1> BbdS13C1Beneficiaries { get; set; } = new List<BbdS13C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS13C2> BbdS13C2Applications { get; set; } = new List<BbdS13C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS13C2> BbdS13C2Beneficiaries { get; set; } = new List<BbdS13C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS13Default> BbdS13DefaultApplications { get; set; } = new List<BbdS13Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS13Default> BbdS13DefaultBeneficiaries { get; set; } = new List<BbdS13Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS17C10> BbdS17C10Applications { get; set; } = new List<BbdS17C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS17C10> BbdS17C10Beneficiaries { get; set; } = new List<BbdS17C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS17C1> BbdS17C1Applications { get; set; } = new List<BbdS17C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS17C1> BbdS17C1Beneficiaries { get; set; } = new List<BbdS17C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS17C2> BbdS17C2Applications { get; set; } = new List<BbdS17C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS17C2> BbdS17C2Beneficiaries { get; set; } = new List<BbdS17C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS17Default> BbdS17DefaultApplications { get; set; } = new List<BbdS17Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS17Default> BbdS17DefaultBeneficiaries { get; set; } = new List<BbdS17Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS19C10> BbdS19C10Applications { get; set; } = new List<BbdS19C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS19C10> BbdS19C10Beneficiaries { get; set; } = new List<BbdS19C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS19C1> BbdS19C1Applications { get; set; } = new List<BbdS19C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS19C1> BbdS19C1Beneficiaries { get; set; } = new List<BbdS19C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS19C2> BbdS19C2Applications { get; set; } = new List<BbdS19C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS19C2> BbdS19C2Beneficiaries { get; set; } = new List<BbdS19C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS19Default> BbdS19DefaultApplications { get; set; } = new List<BbdS19Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS19Default> BbdS19DefaultBeneficiaries { get; set; } = new List<BbdS19Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS1C10> BbdS1C10Applications { get; set; } = new List<BbdS1C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS1C10> BbdS1C10Beneficiaries { get; set; } = new List<BbdS1C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS1C1> BbdS1C1Applications { get; set; } = new List<BbdS1C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS1C1> BbdS1C1Beneficiaries { get; set; } = new List<BbdS1C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS1C2> BbdS1C2Applications { get; set; } = new List<BbdS1C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS1C2> BbdS1C2Beneficiaries { get; set; } = new List<BbdS1C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS1Default> BbdS1DefaultApplications { get; set; } = new List<BbdS1Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS1Default> BbdS1DefaultBeneficiaries { get; set; } = new List<BbdS1Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS20C10> BbdS20C10Applications { get; set; } = new List<BbdS20C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS20C10> BbdS20C10Beneficiaries { get; set; } = new List<BbdS20C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS20C1> BbdS20C1Applications { get; set; } = new List<BbdS20C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS20C1> BbdS20C1Beneficiaries { get; set; } = new List<BbdS20C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS20C2> BbdS20C2Applications { get; set; } = new List<BbdS20C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS20C2> BbdS20C2Beneficiaries { get; set; } = new List<BbdS20C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS20Default> BbdS20DefaultApplications { get; set; } = new List<BbdS20Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS20Default> BbdS20DefaultBeneficiaries { get; set; } = new List<BbdS20Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS2C10> BbdS2C10Applications { get; set; } = new List<BbdS2C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS2C10> BbdS2C10Beneficiaries { get; set; } = new List<BbdS2C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS2C1> BbdS2C1Applications { get; set; } = new List<BbdS2C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS2C1> BbdS2C1Beneficiaries { get; set; } = new List<BbdS2C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS2C2> BbdS2C2Applications { get; set; } = new List<BbdS2C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS2C2> BbdS2C2Beneficiaries { get; set; } = new List<BbdS2C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS2Default> BbdS2DefaultApplications { get; set; } = new List<BbdS2Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS2Default> BbdS2DefaultBeneficiaries { get; set; } = new List<BbdS2Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS3C10> BbdS3C10Applications { get; set; } = new List<BbdS3C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS3C10> BbdS3C10Beneficiaries { get; set; } = new List<BbdS3C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS3C1> BbdS3C1Applications { get; set; } = new List<BbdS3C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS3C1> BbdS3C1Beneficiaries { get; set; } = new List<BbdS3C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS3C2> BbdS3C2Applications { get; set; } = new List<BbdS3C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS3C2> BbdS3C2Beneficiaries { get; set; } = new List<BbdS3C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS3Default> BbdS3DefaultApplications { get; set; } = new List<BbdS3Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS3Default> BbdS3DefaultBeneficiaries { get; set; } = new List<BbdS3Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS5C10> BbdS5C10Applications { get; set; } = new List<BbdS5C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS5C10> BbdS5C10Beneficiaries { get; set; } = new List<BbdS5C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS5C1> BbdS5C1Applications { get; set; } = new List<BbdS5C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS5C1> BbdS5C1Beneficiaries { get; set; } = new List<BbdS5C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS5C2> BbdS5C2Applications { get; set; } = new List<BbdS5C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS5C2> BbdS5C2Beneficiaries { get; set; } = new List<BbdS5C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS5Default> BbdS5DefaultApplications { get; set; } = new List<BbdS5Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS5Default> BbdS5DefaultBeneficiaries { get; set; } = new List<BbdS5Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS6C10> BbdS6C10Applications { get; set; } = new List<BbdS6C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS6C10> BbdS6C10Beneficiaries { get; set; } = new List<BbdS6C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS6C1> BbdS6C1Applications { get; set; } = new List<BbdS6C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS6C1> BbdS6C1Beneficiaries { get; set; } = new List<BbdS6C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS6C2> BbdS6C2Applications { get; set; } = new List<BbdS6C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS6C2> BbdS6C2Beneficiaries { get; set; } = new List<BbdS6C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS6Default> BbdS6DefaultApplications { get; set; } = new List<BbdS6Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS6Default> BbdS6DefaultBeneficiaries { get; set; } = new List<BbdS6Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS7C10> BbdS7C10Applications { get; set; } = new List<BbdS7C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS7C10> BbdS7C10Beneficiaries { get; set; } = new List<BbdS7C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS7C1> BbdS7C1Applications { get; set; } = new List<BbdS7C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS7C1> BbdS7C1Beneficiaries { get; set; } = new List<BbdS7C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS7C2> BbdS7C2Applications { get; set; } = new List<BbdS7C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS7C2> BbdS7C2Beneficiaries { get; set; } = new List<BbdS7C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS7Default> BbdS7DefaultApplications { get; set; } = new List<BbdS7Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS7Default> BbdS7DefaultBeneficiaries { get; set; } = new List<BbdS7Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS8C10> BbdS8C10Applications { get; set; } = new List<BbdS8C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS8C10> BbdS8C10Beneficiaries { get; set; } = new List<BbdS8C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS8C1> BbdS8C1Applications { get; set; } = new List<BbdS8C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS8C1> BbdS8C1Beneficiaries { get; set; } = new List<BbdS8C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS8C2> BbdS8C2Applications { get; set; } = new List<BbdS8C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS8C2> BbdS8C2Beneficiaries { get; set; } = new List<BbdS8C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS8Default> BbdS8DefaultApplications { get; set; } = new List<BbdS8Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS8Default> BbdS8DefaultBeneficiaries { get; set; } = new List<BbdS8Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS9C10> BbdS9C10Applications { get; set; } = new List<BbdS9C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS9C10> BbdS9C10Beneficiaries { get; set; } = new List<BbdS9C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS9C1> BbdS9C1Applications { get; set; } = new List<BbdS9C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS9C1> BbdS9C1Beneficiaries { get; set; } = new List<BbdS9C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS9C2> BbdS9C2Applications { get; set; } = new List<BbdS9C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS9C2> BbdS9C2Beneficiaries { get; set; } = new List<BbdS9C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BbdS9Default> BbdS9DefaultApplications { get; set; } = new List<BbdS9Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BbdS9Default> BbdS9DefaultBeneficiaries { get; set; } = new List<BbdS9Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdDefault> BcdDefaultApplications { get; set; } = new List<BcdDefault>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdDefault> BcdDefaultBeneficiaries { get; set; } = new List<BcdDefault>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS10C10> BcdS10C10Applications { get; set; } = new List<BcdS10C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS10C10> BcdS10C10Beneficiaries { get; set; } = new List<BcdS10C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS10C1> BcdS10C1Applications { get; set; } = new List<BcdS10C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS10C1> BcdS10C1Beneficiaries { get; set; } = new List<BcdS10C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS10C2> BcdS10C2Applications { get; set; } = new List<BcdS10C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS10C2> BcdS10C2Beneficiaries { get; set; } = new List<BcdS10C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS10Default> BcdS10DefaultApplications { get; set; } = new List<BcdS10Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS10Default> BcdS10DefaultBeneficiaries { get; set; } = new List<BcdS10Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS11C10> BcdS11C10Applications { get; set; } = new List<BcdS11C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS11C10> BcdS11C10Beneficiaries { get; set; } = new List<BcdS11C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS11C1> BcdS11C1Applications { get; set; } = new List<BcdS11C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS11C1> BcdS11C1Beneficiaries { get; set; } = new List<BcdS11C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS11C2> BcdS11C2Applications { get; set; } = new List<BcdS11C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS11C2> BcdS11C2Beneficiaries { get; set; } = new List<BcdS11C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS11Default> BcdS11DefaultApplications { get; set; } = new List<BcdS11Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS11Default> BcdS11DefaultBeneficiaries { get; set; } = new List<BcdS11Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS13C10> BcdS13C10Applications { get; set; } = new List<BcdS13C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS13C10> BcdS13C10Beneficiaries { get; set; } = new List<BcdS13C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS13C1> BcdS13C1Applications { get; set; } = new List<BcdS13C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS13C1> BcdS13C1Beneficiaries { get; set; } = new List<BcdS13C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS13C2> BcdS13C2Applications { get; set; } = new List<BcdS13C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS13C2> BcdS13C2Beneficiaries { get; set; } = new List<BcdS13C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS13Default> BcdS13DefaultApplications { get; set; } = new List<BcdS13Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS13Default> BcdS13DefaultBeneficiaries { get; set; } = new List<BcdS13Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS17C10> BcdS17C10Applications { get; set; } = new List<BcdS17C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS17C10> BcdS17C10Beneficiaries { get; set; } = new List<BcdS17C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS17C1> BcdS17C1Applications { get; set; } = new List<BcdS17C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS17C1> BcdS17C1Beneficiaries { get; set; } = new List<BcdS17C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS17C2> BcdS17C2Applications { get; set; } = new List<BcdS17C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS17C2> BcdS17C2Beneficiaries { get; set; } = new List<BcdS17C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS17Default> BcdS17DefaultApplications { get; set; } = new List<BcdS17Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS17Default> BcdS17DefaultBeneficiaries { get; set; } = new List<BcdS17Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS19C10> BcdS19C10Applications { get; set; } = new List<BcdS19C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS19C10> BcdS19C10Beneficiaries { get; set; } = new List<BcdS19C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS19C1> BcdS19C1Applications { get; set; } = new List<BcdS19C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS19C1> BcdS19C1Beneficiaries { get; set; } = new List<BcdS19C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS19C2> BcdS19C2Applications { get; set; } = new List<BcdS19C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS19C2> BcdS19C2Beneficiaries { get; set; } = new List<BcdS19C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS19Default> BcdS19DefaultApplications { get; set; } = new List<BcdS19Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS19Default> BcdS19DefaultBeneficiaries { get; set; } = new List<BcdS19Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS1C10> BcdS1C10Applications { get; set; } = new List<BcdS1C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS1C10> BcdS1C10Beneficiaries { get; set; } = new List<BcdS1C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS1C1> BcdS1C1Applications { get; set; } = new List<BcdS1C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS1C1> BcdS1C1Beneficiaries { get; set; } = new List<BcdS1C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS1C2> BcdS1C2Applications { get; set; } = new List<BcdS1C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS1C2> BcdS1C2Beneficiaries { get; set; } = new List<BcdS1C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS1Default> BcdS1DefaultApplications { get; set; } = new List<BcdS1Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS1Default> BcdS1DefaultBeneficiaries { get; set; } = new List<BcdS1Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS20C10> BcdS20C10Applications { get; set; } = new List<BcdS20C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS20C10> BcdS20C10Beneficiaries { get; set; } = new List<BcdS20C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS20C1> BcdS20C1Applications { get; set; } = new List<BcdS20C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS20C1> BcdS20C1Beneficiaries { get; set; } = new List<BcdS20C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS20C2> BcdS20C2Applications { get; set; } = new List<BcdS20C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS20C2> BcdS20C2Beneficiaries { get; set; } = new List<BcdS20C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS20Default> BcdS20DefaultApplications { get; set; } = new List<BcdS20Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS20Default> BcdS20DefaultBeneficiaries { get; set; } = new List<BcdS20Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS2C10> BcdS2C10Applications { get; set; } = new List<BcdS2C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS2C10> BcdS2C10Beneficiaries { get; set; } = new List<BcdS2C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS2C1> BcdS2C1Applications { get; set; } = new List<BcdS2C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS2C1> BcdS2C1Beneficiaries { get; set; } = new List<BcdS2C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS2C2> BcdS2C2Applications { get; set; } = new List<BcdS2C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS2C2> BcdS2C2Beneficiaries { get; set; } = new List<BcdS2C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS2Default> BcdS2DefaultApplications { get; set; } = new List<BcdS2Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS2Default> BcdS2DefaultBeneficiaries { get; set; } = new List<BcdS2Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS3C10> BcdS3C10Applications { get; set; } = new List<BcdS3C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS3C10> BcdS3C10Beneficiaries { get; set; } = new List<BcdS3C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS3C1> BcdS3C1Applications { get; set; } = new List<BcdS3C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS3C1> BcdS3C1Beneficiaries { get; set; } = new List<BcdS3C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS3C2> BcdS3C2Applications { get; set; } = new List<BcdS3C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS3C2> BcdS3C2Beneficiaries { get; set; } = new List<BcdS3C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS3Default> BcdS3DefaultApplications { get; set; } = new List<BcdS3Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS3Default> BcdS3DefaultBeneficiaries { get; set; } = new List<BcdS3Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS5C10> BcdS5C10Applications { get; set; } = new List<BcdS5C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS5C10> BcdS5C10Beneficiaries { get; set; } = new List<BcdS5C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS5C1> BcdS5C1Applications { get; set; } = new List<BcdS5C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS5C1> BcdS5C1Beneficiaries { get; set; } = new List<BcdS5C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS5C2> BcdS5C2Applications { get; set; } = new List<BcdS5C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS5C2> BcdS5C2Beneficiaries { get; set; } = new List<BcdS5C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS5Default> BcdS5DefaultApplications { get; set; } = new List<BcdS5Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS5Default> BcdS5DefaultBeneficiaries { get; set; } = new List<BcdS5Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS6C10> BcdS6C10Applications { get; set; } = new List<BcdS6C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS6C10> BcdS6C10Beneficiaries { get; set; } = new List<BcdS6C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS6C1> BcdS6C1Applications { get; set; } = new List<BcdS6C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS6C1> BcdS6C1Beneficiaries { get; set; } = new List<BcdS6C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS6C2> BcdS6C2Applications { get; set; } = new List<BcdS6C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS6C2> BcdS6C2Beneficiaries { get; set; } = new List<BcdS6C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS6Default> BcdS6DefaultApplications { get; set; } = new List<BcdS6Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS6Default> BcdS6DefaultBeneficiaries { get; set; } = new List<BcdS6Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS7C10> BcdS7C10Applications { get; set; } = new List<BcdS7C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS7C10> BcdS7C10Beneficiaries { get; set; } = new List<BcdS7C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS7C1> BcdS7C1Applications { get; set; } = new List<BcdS7C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS7C1> BcdS7C1Beneficiaries { get; set; } = new List<BcdS7C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS7C2> BcdS7C2Applications { get; set; } = new List<BcdS7C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS7C2> BcdS7C2Beneficiaries { get; set; } = new List<BcdS7C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS7Default> BcdS7DefaultApplications { get; set; } = new List<BcdS7Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS7Default> BcdS7DefaultBeneficiaries { get; set; } = new List<BcdS7Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS8C10> BcdS8C10Applications { get; set; } = new List<BcdS8C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS8C10> BcdS8C10Beneficiaries { get; set; } = new List<BcdS8C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS8C1> BcdS8C1Applications { get; set; } = new List<BcdS8C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS8C1> BcdS8C1Beneficiaries { get; set; } = new List<BcdS8C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS8C2> BcdS8C2Applications { get; set; } = new List<BcdS8C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS8C2> BcdS8C2Beneficiaries { get; set; } = new List<BcdS8C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS8Default> BcdS8DefaultApplications { get; set; } = new List<BcdS8Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS8Default> BcdS8DefaultBeneficiaries { get; set; } = new List<BcdS8Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS9C10> BcdS9C10Applications { get; set; } = new List<BcdS9C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS9C10> BcdS9C10Beneficiaries { get; set; } = new List<BcdS9C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS9C1> BcdS9C1Applications { get; set; } = new List<BcdS9C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS9C1> BcdS9C1Beneficiaries { get; set; } = new List<BcdS9C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS9C2> BcdS9C2Applications { get; set; } = new List<BcdS9C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS9C2> BcdS9C2Beneficiaries { get; set; } = new List<BcdS9C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BcdS9Default> BcdS9DefaultApplications { get; set; } = new List<BcdS9Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BcdS9Default> BcdS9DefaultBeneficiaries { get; set; } = new List<BcdS9Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BddDefault> BddDefaultApplications { get; set; } = new List<BddDefault>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddDefault> BddDefaultBeneficiaries { get; set; } = new List<BddDefault>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS10C10> BddS10C10Applications { get; set; } = new List<BddS10C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS10C10> BddS10C10Beneficiaries { get; set; } = new List<BddS10C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS10C1> BddS10C1Applications { get; set; } = new List<BddS10C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS10C1> BddS10C1Beneficiaries { get; set; } = new List<BddS10C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS10C2> BddS10C2Applications { get; set; } = new List<BddS10C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS10C2> BddS10C2Beneficiaries { get; set; } = new List<BddS10C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS10Default> BddS10DefaultApplications { get; set; } = new List<BddS10Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS10Default> BddS10DefaultBeneficiaries { get; set; } = new List<BddS10Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS11C10> BddS11C10Applications { get; set; } = new List<BddS11C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS11C10> BddS11C10Beneficiaries { get; set; } = new List<BddS11C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS11C1> BddS11C1Applications { get; set; } = new List<BddS11C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS11C1> BddS11C1Beneficiaries { get; set; } = new List<BddS11C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS11C2> BddS11C2Applications { get; set; } = new List<BddS11C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS11C2> BddS11C2Beneficiaries { get; set; } = new List<BddS11C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS11Default> BddS11DefaultApplications { get; set; } = new List<BddS11Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS11Default> BddS11DefaultBeneficiaries { get; set; } = new List<BddS11Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS13C10> BddS13C10Applications { get; set; } = new List<BddS13C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS13C10> BddS13C10Beneficiaries { get; set; } = new List<BddS13C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS13C1> BddS13C1Applications { get; set; } = new List<BddS13C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS13C1> BddS13C1Beneficiaries { get; set; } = new List<BddS13C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS13C2> BddS13C2Applications { get; set; } = new List<BddS13C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS13C2> BddS13C2Beneficiaries { get; set; } = new List<BddS13C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS13Default> BddS13DefaultApplications { get; set; } = new List<BddS13Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS13Default> BddS13DefaultBeneficiaries { get; set; } = new List<BddS13Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS17C10> BddS17C10Applications { get; set; } = new List<BddS17C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS17C10> BddS17C10Beneficiaries { get; set; } = new List<BddS17C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS17C1> BddS17C1Applications { get; set; } = new List<BddS17C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS17C1> BddS17C1Beneficiaries { get; set; } = new List<BddS17C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS17C2> BddS17C2Applications { get; set; } = new List<BddS17C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS17C2> BddS17C2Beneficiaries { get; set; } = new List<BddS17C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS17Default> BddS17DefaultApplications { get; set; } = new List<BddS17Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS17Default> BddS17DefaultBeneficiaries { get; set; } = new List<BddS17Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS19C10> BddS19C10Applications { get; set; } = new List<BddS19C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS19C10> BddS19C10Beneficiaries { get; set; } = new List<BddS19C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS19C1> BddS19C1Applications { get; set; } = new List<BddS19C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS19C1> BddS19C1Beneficiaries { get; set; } = new List<BddS19C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS19C2> BddS19C2Applications { get; set; } = new List<BddS19C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS19C2> BddS19C2Beneficiaries { get; set; } = new List<BddS19C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS19Default> BddS19DefaultApplications { get; set; } = new List<BddS19Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS19Default> BddS19DefaultBeneficiaries { get; set; } = new List<BddS19Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS1C10> BddS1C10Applications { get; set; } = new List<BddS1C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS1C10> BddS1C10Beneficiaries { get; set; } = new List<BddS1C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS1C1> BddS1C1Applications { get; set; } = new List<BddS1C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS1C1> BddS1C1Beneficiaries { get; set; } = new List<BddS1C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS1C2> BddS1C2Applications { get; set; } = new List<BddS1C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS1C2> BddS1C2Beneficiaries { get; set; } = new List<BddS1C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS1Default> BddS1DefaultApplications { get; set; } = new List<BddS1Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS1Default> BddS1DefaultBeneficiaries { get; set; } = new List<BddS1Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS20C10> BddS20C10Applications { get; set; } = new List<BddS20C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS20C10> BddS20C10Beneficiaries { get; set; } = new List<BddS20C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS20C1> BddS20C1Applications { get; set; } = new List<BddS20C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS20C1> BddS20C1Beneficiaries { get; set; } = new List<BddS20C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS20C2> BddS20C2Applications { get; set; } = new List<BddS20C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS20C2> BddS20C2Beneficiaries { get; set; } = new List<BddS20C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS20Default> BddS20DefaultApplications { get; set; } = new List<BddS20Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS20Default> BddS20DefaultBeneficiaries { get; set; } = new List<BddS20Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS2C10> BddS2C10Applications { get; set; } = new List<BddS2C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS2C10> BddS2C10Beneficiaries { get; set; } = new List<BddS2C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS2C1> BddS2C1Applications { get; set; } = new List<BddS2C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS2C1> BddS2C1Beneficiaries { get; set; } = new List<BddS2C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS2C2> BddS2C2Applications { get; set; } = new List<BddS2C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS2C2> BddS2C2Beneficiaries { get; set; } = new List<BddS2C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS2Default> BddS2DefaultApplications { get; set; } = new List<BddS2Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS2Default> BddS2DefaultBeneficiaries { get; set; } = new List<BddS2Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS3C10> BddS3C10Applications { get; set; } = new List<BddS3C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS3C10> BddS3C10Beneficiaries { get; set; } = new List<BddS3C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS3C1> BddS3C1Applications { get; set; } = new List<BddS3C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS3C1> BddS3C1Beneficiaries { get; set; } = new List<BddS3C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS3C2> BddS3C2Applications { get; set; } = new List<BddS3C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS3C2> BddS3C2Beneficiaries { get; set; } = new List<BddS3C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS3Default> BddS3DefaultApplications { get; set; } = new List<BddS3Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS3Default> BddS3DefaultBeneficiaries { get; set; } = new List<BddS3Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS5C10> BddS5C10Applications { get; set; } = new List<BddS5C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS5C10> BddS5C10Beneficiaries { get; set; } = new List<BddS5C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS5C1> BddS5C1Applications { get; set; } = new List<BddS5C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS5C1> BddS5C1Beneficiaries { get; set; } = new List<BddS5C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS5C2> BddS5C2Applications { get; set; } = new List<BddS5C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS5C2> BddS5C2Beneficiaries { get; set; } = new List<BddS5C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS5Default> BddS5DefaultApplications { get; set; } = new List<BddS5Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS5Default> BddS5DefaultBeneficiaries { get; set; } = new List<BddS5Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS6C10> BddS6C10Applications { get; set; } = new List<BddS6C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS6C10> BddS6C10Beneficiaries { get; set; } = new List<BddS6C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS6C1> BddS6C1Applications { get; set; } = new List<BddS6C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS6C1> BddS6C1Beneficiaries { get; set; } = new List<BddS6C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS6C2> BddS6C2Applications { get; set; } = new List<BddS6C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS6C2> BddS6C2Beneficiaries { get; set; } = new List<BddS6C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS6Default> BddS6DefaultApplications { get; set; } = new List<BddS6Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS6Default> BddS6DefaultBeneficiaries { get; set; } = new List<BddS6Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS7C10> BddS7C10Applications { get; set; } = new List<BddS7C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS7C10> BddS7C10Beneficiaries { get; set; } = new List<BddS7C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS7C1> BddS7C1Applications { get; set; } = new List<BddS7C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS7C1> BddS7C1Beneficiaries { get; set; } = new List<BddS7C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS7C2> BddS7C2Applications { get; set; } = new List<BddS7C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS7C2> BddS7C2Beneficiaries { get; set; } = new List<BddS7C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS7Default> BddS7DefaultApplications { get; set; } = new List<BddS7Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS7Default> BddS7DefaultBeneficiaries { get; set; } = new List<BddS7Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS8C10> BddS8C10Applications { get; set; } = new List<BddS8C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS8C10> BddS8C10Beneficiaries { get; set; } = new List<BddS8C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS8C1> BddS8C1Applications { get; set; } = new List<BddS8C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS8C1> BddS8C1Beneficiaries { get; set; } = new List<BddS8C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS8C2> BddS8C2Applications { get; set; } = new List<BddS8C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS8C2> BddS8C2Beneficiaries { get; set; } = new List<BddS8C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS8Default> BddS8DefaultApplications { get; set; } = new List<BddS8Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS8Default> BddS8DefaultBeneficiaries { get; set; } = new List<BddS8Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS9C10> BddS9C10Applications { get; set; } = new List<BddS9C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS9C10> BddS9C10Beneficiaries { get; set; } = new List<BddS9C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS9C1> BddS9C1Applications { get; set; } = new List<BddS9C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS9C1> BddS9C1Beneficiaries { get; set; } = new List<BddS9C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS9C2> BddS9C2Applications { get; set; } = new List<BddS9C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS9C2> BddS9C2Beneficiaries { get; set; } = new List<BddS9C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BddS9Default> BddS9DefaultApplications { get; set; } = new List<BddS9Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BddS9Default> BddS9DefaultBeneficiaries { get; set; } = new List<BddS9Default>();

    [InverseProperty("Application")]
    public virtual BeneficiaryLandDetail? BeneficiaryLandDetailApplication { get; set; }

    [InverseProperty("Beneficiary")]
    public virtual BeneficiaryLandDetail? BeneficiaryLandDetailBeneficiary { get; set; }

    [InverseProperty("Application")]
    public virtual ICollection<BpdDefault> BpdDefaultApplications { get; set; } = new List<BpdDefault>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdDefault> BpdDefaultBeneficiaries { get; set; } = new List<BpdDefault>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS10C10> BpdS10C10Applications { get; set; } = new List<BpdS10C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS10C10> BpdS10C10Beneficiaries { get; set; } = new List<BpdS10C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS10C1> BpdS10C1Applications { get; set; } = new List<BpdS10C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS10C1> BpdS10C1Beneficiaries { get; set; } = new List<BpdS10C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS10C2> BpdS10C2Applications { get; set; } = new List<BpdS10C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS10C2> BpdS10C2Beneficiaries { get; set; } = new List<BpdS10C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS10Default> BpdS10DefaultApplications { get; set; } = new List<BpdS10Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS10Default> BpdS10DefaultBeneficiaries { get; set; } = new List<BpdS10Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS11C10> BpdS11C10Applications { get; set; } = new List<BpdS11C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS11C10> BpdS11C10Beneficiaries { get; set; } = new List<BpdS11C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS11C1> BpdS11C1Applications { get; set; } = new List<BpdS11C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS11C1> BpdS11C1Beneficiaries { get; set; } = new List<BpdS11C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS11C2> BpdS11C2Applications { get; set; } = new List<BpdS11C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS11C2> BpdS11C2Beneficiaries { get; set; } = new List<BpdS11C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS11Default> BpdS11DefaultApplications { get; set; } = new List<BpdS11Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS11Default> BpdS11DefaultBeneficiaries { get; set; } = new List<BpdS11Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS13C10> BpdS13C10Applications { get; set; } = new List<BpdS13C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS13C10> BpdS13C10Beneficiaries { get; set; } = new List<BpdS13C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS13C1> BpdS13C1Applications { get; set; } = new List<BpdS13C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS13C1> BpdS13C1Beneficiaries { get; set; } = new List<BpdS13C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS13C2> BpdS13C2Applications { get; set; } = new List<BpdS13C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS13C2> BpdS13C2Beneficiaries { get; set; } = new List<BpdS13C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS13Default> BpdS13DefaultApplications { get; set; } = new List<BpdS13Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS13Default> BpdS13DefaultBeneficiaries { get; set; } = new List<BpdS13Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS17C10> BpdS17C10Applications { get; set; } = new List<BpdS17C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS17C10> BpdS17C10Beneficiaries { get; set; } = new List<BpdS17C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS17C1> BpdS17C1Applications { get; set; } = new List<BpdS17C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS17C1> BpdS17C1Beneficiaries { get; set; } = new List<BpdS17C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS17C2> BpdS17C2Applications { get; set; } = new List<BpdS17C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS17C2> BpdS17C2Beneficiaries { get; set; } = new List<BpdS17C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS17Default> BpdS17DefaultApplications { get; set; } = new List<BpdS17Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS17Default> BpdS17DefaultBeneficiaries { get; set; } = new List<BpdS17Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS19C10> BpdS19C10Applications { get; set; } = new List<BpdS19C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS19C10> BpdS19C10Beneficiaries { get; set; } = new List<BpdS19C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS19C1> BpdS19C1Applications { get; set; } = new List<BpdS19C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS19C1> BpdS19C1Beneficiaries { get; set; } = new List<BpdS19C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS19C2> BpdS19C2Applications { get; set; } = new List<BpdS19C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS19C2> BpdS19C2Beneficiaries { get; set; } = new List<BpdS19C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS19Default> BpdS19DefaultApplications { get; set; } = new List<BpdS19Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS19Default> BpdS19DefaultBeneficiaries { get; set; } = new List<BpdS19Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS1C10> BpdS1C10Applications { get; set; } = new List<BpdS1C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS1C10> BpdS1C10Beneficiaries { get; set; } = new List<BpdS1C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS1C1> BpdS1C1Applications { get; set; } = new List<BpdS1C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS1C1> BpdS1C1Beneficiaries { get; set; } = new List<BpdS1C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS1C2> BpdS1C2Applications { get; set; } = new List<BpdS1C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS1C2> BpdS1C2Beneficiaries { get; set; } = new List<BpdS1C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS1Default> BpdS1DefaultApplications { get; set; } = new List<BpdS1Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS1Default> BpdS1DefaultBeneficiaries { get; set; } = new List<BpdS1Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS20C10> BpdS20C10Applications { get; set; } = new List<BpdS20C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS20C10> BpdS20C10Beneficiaries { get; set; } = new List<BpdS20C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS20C1> BpdS20C1Applications { get; set; } = new List<BpdS20C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS20C1> BpdS20C1Beneficiaries { get; set; } = new List<BpdS20C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS20C2> BpdS20C2Applications { get; set; } = new List<BpdS20C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS20C2> BpdS20C2Beneficiaries { get; set; } = new List<BpdS20C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS20Default> BpdS20DefaultApplications { get; set; } = new List<BpdS20Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS20Default> BpdS20DefaultBeneficiaries { get; set; } = new List<BpdS20Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS2C10> BpdS2C10Applications { get; set; } = new List<BpdS2C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS2C10> BpdS2C10Beneficiaries { get; set; } = new List<BpdS2C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS2C1> BpdS2C1Applications { get; set; } = new List<BpdS2C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS2C1> BpdS2C1Beneficiaries { get; set; } = new List<BpdS2C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS2C2> BpdS2C2Applications { get; set; } = new List<BpdS2C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS2C2> BpdS2C2Beneficiaries { get; set; } = new List<BpdS2C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS2Default> BpdS2DefaultApplications { get; set; } = new List<BpdS2Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS2Default> BpdS2DefaultBeneficiaries { get; set; } = new List<BpdS2Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS3C10> BpdS3C10Applications { get; set; } = new List<BpdS3C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS3C10> BpdS3C10Beneficiaries { get; set; } = new List<BpdS3C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS3C1> BpdS3C1Applications { get; set; } = new List<BpdS3C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS3C1> BpdS3C1Beneficiaries { get; set; } = new List<BpdS3C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS3C2> BpdS3C2Applications { get; set; } = new List<BpdS3C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS3C2> BpdS3C2Beneficiaries { get; set; } = new List<BpdS3C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS3Default> BpdS3DefaultApplications { get; set; } = new List<BpdS3Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS3Default> BpdS3DefaultBeneficiaries { get; set; } = new List<BpdS3Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS5C10> BpdS5C10Applications { get; set; } = new List<BpdS5C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS5C10> BpdS5C10Beneficiaries { get; set; } = new List<BpdS5C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS5C1> BpdS5C1Applications { get; set; } = new List<BpdS5C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS5C1> BpdS5C1Beneficiaries { get; set; } = new List<BpdS5C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS5C2> BpdS5C2Applications { get; set; } = new List<BpdS5C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS5C2> BpdS5C2Beneficiaries { get; set; } = new List<BpdS5C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS5Default> BpdS5DefaultApplications { get; set; } = new List<BpdS5Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS5Default> BpdS5DefaultBeneficiaries { get; set; } = new List<BpdS5Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS6C10> BpdS6C10Applications { get; set; } = new List<BpdS6C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS6C10> BpdS6C10Beneficiaries { get; set; } = new List<BpdS6C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS6C1> BpdS6C1Applications { get; set; } = new List<BpdS6C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS6C1> BpdS6C1Beneficiaries { get; set; } = new List<BpdS6C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS6C2> BpdS6C2Applications { get; set; } = new List<BpdS6C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS6C2> BpdS6C2Beneficiaries { get; set; } = new List<BpdS6C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS6Default> BpdS6DefaultApplications { get; set; } = new List<BpdS6Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS6Default> BpdS6DefaultBeneficiaries { get; set; } = new List<BpdS6Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS7C10> BpdS7C10Applications { get; set; } = new List<BpdS7C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS7C10> BpdS7C10Beneficiaries { get; set; } = new List<BpdS7C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS7C1> BpdS7C1Applications { get; set; } = new List<BpdS7C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS7C1> BpdS7C1Beneficiaries { get; set; } = new List<BpdS7C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS7C2> BpdS7C2Applications { get; set; } = new List<BpdS7C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS7C2> BpdS7C2Beneficiaries { get; set; } = new List<BpdS7C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS7Default> BpdS7DefaultApplications { get; set; } = new List<BpdS7Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS7Default> BpdS7DefaultBeneficiaries { get; set; } = new List<BpdS7Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS8C10> BpdS8C10Applications { get; set; } = new List<BpdS8C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS8C10> BpdS8C10Beneficiaries { get; set; } = new List<BpdS8C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS8C1> BpdS8C1Applications { get; set; } = new List<BpdS8C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS8C1> BpdS8C1Beneficiaries { get; set; } = new List<BpdS8C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS8C2> BpdS8C2Applications { get; set; } = new List<BpdS8C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS8C2> BpdS8C2Beneficiaries { get; set; } = new List<BpdS8C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS8Default> BpdS8DefaultApplications { get; set; } = new List<BpdS8Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS8Default> BpdS8DefaultBeneficiaries { get; set; } = new List<BpdS8Default>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS9C10> BpdS9C10Applications { get; set; } = new List<BpdS9C10>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS9C10> BpdS9C10Beneficiaries { get; set; } = new List<BpdS9C10>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS9C1> BpdS9C1Applications { get; set; } = new List<BpdS9C1>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS9C1> BpdS9C1Beneficiaries { get; set; } = new List<BpdS9C1>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS9C2> BpdS9C2Applications { get; set; } = new List<BpdS9C2>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS9C2> BpdS9C2Beneficiaries { get; set; } = new List<BpdS9C2>();

    [InverseProperty("Application")]
    public virtual ICollection<BpdS9Default> BpdS9DefaultApplications { get; set; } = new List<BpdS9Default>();

    [InverseProperty("Beneficiary")]
    public virtual ICollection<BpdS9Default> BpdS9DefaultBeneficiaries { get; set; } = new List<BpdS9Default>();

    [InverseProperty("Application")]
    public virtual LandDetail? LandDetailApplication { get; set; }

    [InverseProperty("Beneficiary")]
    public virtual LandDetail? LandDetailBeneficiary { get; set; }
}
