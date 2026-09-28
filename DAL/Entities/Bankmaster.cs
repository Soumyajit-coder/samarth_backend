using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("bankmasters")]
[Index("BankCode", Name = "bankmasters_bank_code_index")]
[Index("Id", Name = "bankmasters_id_index")]
public partial class Bankmaster
{
    [Key]
    [Column("id")]
    public long Id { get; set; }

    [Column("name")]
    [StringLength(255)]
    public string Name { get; set; } = null!;

    [Column("short_name")]
    [StringLength(255)]
    public string ShortName { get; set; } = null!;

    [Column("bank_code")]
    [StringLength(255)]
    public string BankCode { get; set; } = null!;

    [Column("created_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? CreatedAt { get; set; }

    [Column("updated_at", TypeName = "timestamp(0) without time zone")]
    public DateTime? UpdatedAt { get; set; }

    [Column("is_active")]
    public short IsActive { get; set; }

    [InverseProperty("Bankmaster")]
    public virtual ICollection<Ifsccodemaster> Ifsccodemasters { get; set; } = new List<Ifsccodemaster>();
}
