using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Keyless]
[Table("m_block")]
public partial class MBlock
{
    [Column("district_code")]
    public int? DistrictCode { get; set; }

    [Column("block_code")]
    public int? BlockCode { get; set; }

    [Column("block_name")]
    [StringLength(50)]
    public string? BlockName { get; set; }
}
