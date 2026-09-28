using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("verification_codes")]
public partial class VerificationCode
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("user_id")]
    public long UserId { get; set; }

    [Column("otp")]
    [StringLength(255)]
    public string Otp { get; set; } = null!;

    [Column("mobile_no")]
    [StringLength(255)]
    public string MobileNo { get; set; } = null!;

    [Column("expire_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? ExpireAt { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("status")]
    [StringLength(255)]
    public string Status { get; set; } = null!;
}
