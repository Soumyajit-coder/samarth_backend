using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Keyless]
[Table("m_urban_body")]
public partial class MUrbanBody
{
    [Column("district_code")]
    public int? DistrictCode { get; set; }

    [Column("sub_district_code")]
    public int? SubDistrictCode { get; set; }

    [Column("urban_body_code")]
    public int? UrbanBodyCode { get; set; }

    [Column("urban_body_name")]
    [StringLength(50)]
    public string? UrbanBodyName { get; set; }
}
