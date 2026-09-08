using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Keyless]
[Table("m_block_urban_entry_mapping")]
public partial class MBlockUrbanEntryMapping
{
    [Column("district_code")]
    public int? DistrictCode { get; set; }

    [Column("block_ulb_code")]
    public int? BlockUlbCode { get; set; }

    [Column("main_entry")]
    public bool? MainEntry { get; set; }

    [Column("main_verification")]
    public bool? MainVerification { get; set; }

    [Column("main_approval")]
    public bool? MainApproval { get; set; }

    [Column("scheme_id")]
    public short? SchemeId { get; set; }

    [Column("capacity")]
    public int? Capacity { get; set; }

    [Column("special_entry")]
    public bool? SpecialEntry { get; set; }

    [Column("special_verification")]
    public bool? SpecialVerification { get; set; }

    [Column("special_approval")]
    public bool? SpecialApproval { get; set; }

    [Column("special_capacity")]
    public int? SpecialCapacity { get; set; }

    [Column("is_urban")]
    public short? IsUrban { get; set; }

    [Column("entry_cap")]
    public short? EntryCap { get; set; }

    [Column("updated_at", TypeName = "timestamp without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("main_verification_lb")]
    public bool? MainVerificationLb { get; set; }

    [Column("main_approval_lb")]
    public bool? MainApprovalLb { get; set; }

    [Column("dept_special_quota")]
    public short? DeptSpecialQuota { get; set; }
}
