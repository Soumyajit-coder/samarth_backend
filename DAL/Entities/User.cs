using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Keyless]
[Table("users")]
public partial class User
{
    [Column("id")]
    public int Id { get; set; }

    [Column("username")]
    [StringLength(191)]
    public string? Username { get; set; }

    [Column("email")]
    [StringLength(191)]
    public string? Email { get; set; }

    [Column("password")]
    [StringLength(191)]
    public string? Password { get; set; }

    [Column("remember_token")]
    [StringLength(100)]
    public string? RememberToken { get; set; }

    [Column("deleted_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? DeletedAt { get; set; }

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("emp_id")]
    public int? EmpId { get; set; }

    [Column("designation_id")]
    [StringLength(191)]
    public string? DesignationId { get; set; }

    [Column("user_scheme_id")]
    public int? UserSchemeId { get; set; }

    [Column("mobile_no")]
    [StringLength(10)]
    public string? MobileNo { get; set; }

    [Column("login_otp")]
    [StringLength(6)]
    public string? LoginOtp { get; set; }

    [Column("otp_time", TypeName = "timestamp without time zone")]
    public DateTime? OtpTime { get; set; }

    [Column("is_state_login")]
    public bool? IsStateLogin { get; set; }

    [Column("created_by")]
    public int? CreatedBy { get; set; }

    [Column("is_deleted")]
    public bool? IsDeleted { get; set; }

    [Column("is_active")]
    public short? IsActive { get; set; }

    [Column("updated_by")]
    public int? UpdatedBy { get; set; }

    [Column("designation_id_new")]
    public int? DesignationIdNew { get; set; }

    [Column("last_otp")]
    public string? LastOtp { get; set; }

    [Column("flag_sent_otp")]
    public short? FlagSentOtp { get; set; }

    [Column("last_otp_generation_time", TypeName = "timestamp without time zone")]
    public DateTime? LastOtpGenerationTime { get; set; }

    [Column("last_otp_expire_time", TypeName = "timestamp without time zone")]
    public DateTime? LastOtpExpireTime { get; set; }

    [Column("password_set_time", TypeName = "timestamp without time zone")]
    public DateTime? PasswordSetTime { get; set; }

    [Column("password_expires_at", TypeName = "timestamp without time zone")]
    public DateTime? PasswordExpiresAt { get; set; }

    [Column("is_login")]
    public short? IsLogin { get; set; }

    [Column("password_hash")]
    public byte[]? PasswordHash { get; set; }

    [Column("password_salt")]
    public byte[]? PasswordSalt { get; set; }
}
