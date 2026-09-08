using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using samarth_backend.DAL.Entities;

namespace samarth_backend.DAL;

public partial class jaiBanglaDBContext : DbContext
{
    public jaiBanglaDBContext()
    {
    }

    public jaiBanglaDBContext(DbContextOptions<jaiBanglaDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BenAcceptRejectInfo> BenAcceptRejectInfos { get; set; }

    public virtual DbSet<DutyAssignement> DutyAssignements { get; set; }

    public virtual DbSet<MAttachedDoc> MAttachedDocs { get; set; }

    public virtual DbSet<MBlock> MBlocks { get; set; }

    public virtual DbSet<MBlockUrbanEntryMapping> MBlockUrbanEntryMappings { get; set; }

    public virtual DbSet<MDistrict> MDistricts { get; set; }

    public virtual DbSet<MDsPhase> MDsPhases { get; set; }

    public virtual DbSet<MGp> MGps { get; set; }

    public virtual DbSet<MScheme> MSchemes { get; set; }

    public virtual DbSet<MSubDistrict> MSubDistricts { get; set; }

    public virtual DbSet<MUrbanBody> MUrbanBodies { get; set; }

    public virtual DbSet<MUrbanBodyWard> MUrbanBodyWards { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Name=ConnectionStrings:DBConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BenAcceptRejectInfo>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<DutyAssignement>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MAttachedDoc>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MDistrict>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MScheme>(entity =>
        {
            entity.Property(e => e.DdoCode).IsFixedLength();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
