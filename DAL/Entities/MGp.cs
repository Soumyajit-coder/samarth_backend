using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Keyless]
[Table("m_gp")]
public partial class MGp
{
    [Column("district_code")]
    public int? DistrictCode { get; set; }

    [Column("block_code")]
    public int? BlockCode { get; set; }

    [Column("gram_panchyat_code")]
    public int? GramPanchyatCode { get; set; }

    [Column("gram_panchyat_name")]
    [StringLength(100)]
    public string? GramPanchyatName { get; set; }
}
