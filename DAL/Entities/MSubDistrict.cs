using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Keyless]
[Table("m_sub_district")]
public partial class MSubDistrict
{
    [Column("district_code")]
    public int? DistrictCode { get; set; }

    [Column("sub_district_code")]
    public int? SubDistrictCode { get; set; }

    [Column("sub_district_name")]
    [StringLength(50)]
    public string? SubDistrictName { get; set; }
}
