using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("office_masters")]
[Index("BlockId", Name = "office_masters_block_id_index")]
[Index("DistrictId", Name = "office_masters_district_id_index")]
[Index("Id", Name = "office_masters_id_index")]
[Index("MunicipalitiyId", Name = "office_masters_municipalitiy_id_index")]
[Index("PanchayatId", Name = "office_masters_panchayat_id_index")]
[Index("SubdivisionId", Name = "office_masters_subdivision_id_index")]
[Index("WardId", Name = "office_masters_ward_id_index")]
public partial class OfficeMaster
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("address")]
    [StringLength(255)]
    public string? Address { get; set; }

    [Column("zip")]
    [StringLength(255)]
    public string? Zip { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("office_type_id")]
    public int OfficeTypeId { get; set; }

    [Column("state_id")]
    public short StateId { get; set; }

    [Column("district_id")]
    public int? DistrictId { get; set; }

    [Column("block_id")]
    public int? BlockId { get; set; }

    [Column("subdivision_id")]
    public int? SubdivisionId { get; set; }

    [Column("municipalitiy_id")]
    public int? MunicipalitiyId { get; set; }

    [Column("ward_id")]
    public int? WardId { get; set; }

    [Column("panchayat_id")]
    public int? PanchayatId { get; set; }

    [Column("is_active")]
    public short IsActive { get; set; }

    [Column("max_operator")]
    public int? MaxOperator { get; set; }

    [Column("max_verifier")]
    public int? MaxVerifier { get; set; }

    [Column("max_enquiry_officer")]
    public int? MaxEnquiryOfficer { get; set; }

    [ForeignKey("BlockId")]
    [InverseProperty("OfficeMasters")]
    public virtual Block? Block { get; set; }

    [ForeignKey("DistrictId")]
    [InverseProperty("OfficeMasters")]
    public virtual District? District { get; set; }

    [ForeignKey("MunicipalitiyId")]
    [InverseProperty("OfficeMasters")]
    public virtual Municipality? Municipalitiy { get; set; }

    [ForeignKey("OfficeTypeId")]
    [InverseProperty("OfficeMasters")]
    public virtual Codemaster OfficeType { get; set; } = null!;

    [ForeignKey("PanchayatId")]
    [InverseProperty("OfficeMasters")]
    public virtual Panchayat? Panchayat { get; set; }

    [ForeignKey("StateId")]
    [InverseProperty("OfficeMasters")]
    public virtual State State { get; set; } = null!;

    [ForeignKey("SubdivisionId")]
    [InverseProperty("OfficeMasters")]
    public virtual Subdivision? Subdivision { get; set; }

    [InverseProperty("Office")]
    public virtual ICollection<UserRoleSchemeOfficeMapping> UserRoleSchemeOfficeMappings { get; set; } = new List<UserRoleSchemeOfficeMapping>();

    [ForeignKey("WardId")]
    [InverseProperty("OfficeMasters")]
    public virtual Ward? Ward { get; set; }
}
