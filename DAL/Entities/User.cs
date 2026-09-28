using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("users")]
[Index("Email", Name = "users_email_index")]
[Index("Id", Name = "users_id_index")]
[Index("MobileNo", Name = "users_mobile_no_index")]
public partial class User
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("email")]
    [StringLength(255)]
    public string Email { get; set; } = null!;

    [Column("email_verified_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? EmailVerifiedAt { get; set; }

    [Column("password")]
    [StringLength(255)]
    public string Password { get; set; } = null!;

    [Column("remember_token")]
    [StringLength(100)]
    public string? RememberToken { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("mobile_no")]
    [StringLength(10)]
    public string MobileNo { get; set; } = null!;

    [Column("flag_sent_otp")]
    public short FlagSentOtp { get; set; }

    [Column("first_time_set_password")]
    public bool? FirstTimeSetPassword { get; set; }

    [Column("password_set_time", TypeName = "timestamp(0) without time zone")]
    public DateTime? PasswordSetTime { get; set; }

    [Column("password_expires_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? PasswordExpiresAt { get; set; }

    [Column("last_otp")]
    [StringLength(255)]
    public string? LastOtp { get; set; }

    [Column("last_otp_generation_time", TypeName = "timestamp(0) without time zone")]
    public DateTime? LastOtpGenerationTime { get; set; }

    [Column("last_otp_expire_time", TypeName = "timestamp(0) without time zone")]
    public DateTime? LastOtpExpireTime { get; set; }

    [Column("is_active")]
    public short IsActive { get; set; }

    [Column("is_login")]
    public short IsLogin { get; set; }

    [Column("bypass_otp")]
    public bool BypassOtp { get; set; }

    [Column("current_session_id")]
    [StringLength(255)]
    public string? CurrentSessionId { get; set; }

    [Column("allow_multi_session")]
    public bool AllowMultiSession { get; set; }

    [Column("designation")]
    [StringLength(255)]
    public string? Designation { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<AcceptRejectInfo> AcceptRejectInfos { get; set; } = new List<AcceptRejectInfo>();

    [InverseProperty("User")]
    public virtual ICollection<PasswordHistory> PasswordHistories { get; set; } = new List<PasswordHistory>();

    [InverseProperty("User")]
    public virtual ICollection<UserPersonal> UserPersonals { get; set; } = new List<UserPersonal>();

    [InverseProperty("User")]
    public virtual ICollection<UserRoleSchemeOfficeMapping> UserRoleSchemeOfficeMappings { get; set; } = new List<UserRoleSchemeOfficeMapping>();
}
