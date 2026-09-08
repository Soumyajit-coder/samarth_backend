using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Keyless]
[Table("m_urban_body_ward")]
public partial class MUrbanBodyWard
{
    [Column("urban_body_code")]
    public int? UrbanBodyCode { get; set; }

    [Column("urban_body_ward_no")]
    public int? UrbanBodyWardNo { get; set; }

    [Column("urban_body_ward_code")]
    public int? UrbanBodyWardCode { get; set; }

    [Column("urban_body_ward_name")]
    [StringLength(100)]
    public string? UrbanBodyWardName { get; set; }
}
