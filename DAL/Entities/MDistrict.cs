using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Keyless]
[Table("m_district")]
public partial class MDistrict
{
    [Column("district_code")]
    public int? DistrictCode { get; set; }

    [Column("district_name")]
    [StringLength(30)]
    public string? DistrictName { get; set; }

    [Column("is_revenue_district")]
    public int? IsRevenueDistrict { get; set; }

    [Column("id")]
    public long Id { get; set; }

    [Column("rch_district_code")]
    public int? RchDistrictCode { get; set; }

    [Column("state_code")]
    public int? StateCode { get; set; }

    [Column("district_status")]
    public int? DistrictStatus { get; set; }
}
