using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace samarth_backend.DAL.Entities;

[Table("cache_locks")]
public partial class CacheLock
{
    [Key]
    [Column("key")]
    [StringLength(255)]
    public string Key { get; set; } = null!;

    [Column("owner")]
    [StringLength(255)]
    public string Owner { get; set; } = null!;

    [Column("expiration")]
    public int Expiration { get; set; }
}
