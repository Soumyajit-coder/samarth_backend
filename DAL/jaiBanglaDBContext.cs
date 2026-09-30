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

    public virtual DbSet<AcceptRejectInfo> AcceptRejectInfos { get; set; }

    public virtual DbSet<ActivityLog> ActivityLogs { get; set; }

    public virtual DbSet<AgeManagement> AgeManagements { get; set; }

    public virtual DbSet<Audit> Audits { get; set; }

    public virtual DbSet<Bankmaster> Bankmasters { get; set; }

    public virtual DbSet<BbdDefault> BbdDefaults { get; set; }

    public virtual DbSet<BbdS10C1> BbdS10C1s { get; set; }

    public virtual DbSet<BbdS10C10> BbdS10C10s { get; set; }

    public virtual DbSet<BbdS10C2> BbdS10C2s { get; set; }

    public virtual DbSet<BbdS10Default> BbdS10Defaults { get; set; }

    public virtual DbSet<BbdS11C1> BbdS11C1s { get; set; }

    public virtual DbSet<BbdS11C10> BbdS11C10s { get; set; }

    public virtual DbSet<BbdS11C2> BbdS11C2s { get; set; }

    public virtual DbSet<BbdS11Default> BbdS11Defaults { get; set; }

    public virtual DbSet<BbdS13C1> BbdS13C1s { get; set; }

    public virtual DbSet<BbdS13C10> BbdS13C10s { get; set; }

    public virtual DbSet<BbdS13C2> BbdS13C2s { get; set; }

    public virtual DbSet<BbdS13Default> BbdS13Defaults { get; set; }

    public virtual DbSet<BbdS17C1> BbdS17C1s { get; set; }

    public virtual DbSet<BbdS17C10> BbdS17C10s { get; set; }

    public virtual DbSet<BbdS17C2> BbdS17C2s { get; set; }

    public virtual DbSet<BbdS17Default> BbdS17Defaults { get; set; }

    public virtual DbSet<BbdS19C1> BbdS19C1s { get; set; }

    public virtual DbSet<BbdS19C10> BbdS19C10s { get; set; }

    public virtual DbSet<BbdS19C2> BbdS19C2s { get; set; }

    public virtual DbSet<BbdS19Default> BbdS19Defaults { get; set; }

    public virtual DbSet<BbdS1C1> BbdS1C1s { get; set; }

    public virtual DbSet<BbdS1C10> BbdS1C10s { get; set; }

    public virtual DbSet<BbdS1C2> BbdS1C2s { get; set; }

    public virtual DbSet<BbdS1Default> BbdS1Defaults { get; set; }

    public virtual DbSet<BbdS20C1> BbdS20C1s { get; set; }

    public virtual DbSet<BbdS20C10> BbdS20C10s { get; set; }

    public virtual DbSet<BbdS20C2> BbdS20C2s { get; set; }

    public virtual DbSet<BbdS20Default> BbdS20Defaults { get; set; }

    public virtual DbSet<BbdS2C1> BbdS2C1s { get; set; }

    public virtual DbSet<BbdS2C10> BbdS2C10s { get; set; }

    public virtual DbSet<BbdS2C2> BbdS2C2s { get; set; }

    public virtual DbSet<BbdS2Default> BbdS2Defaults { get; set; }

    public virtual DbSet<BbdS3C1> BbdS3C1s { get; set; }

    public virtual DbSet<BbdS3C10> BbdS3C10s { get; set; }

    public virtual DbSet<BbdS3C2> BbdS3C2s { get; set; }

    public virtual DbSet<BbdS3Default> BbdS3Defaults { get; set; }

    public virtual DbSet<BbdS5C1> BbdS5C1s { get; set; }

    public virtual DbSet<BbdS5C10> BbdS5C10s { get; set; }

    public virtual DbSet<BbdS5C2> BbdS5C2s { get; set; }

    public virtual DbSet<BbdS5Default> BbdS5Defaults { get; set; }

    public virtual DbSet<BbdS6C1> BbdS6C1s { get; set; }

    public virtual DbSet<BbdS6C10> BbdS6C10s { get; set; }

    public virtual DbSet<BbdS6C2> BbdS6C2s { get; set; }

    public virtual DbSet<BbdS6Default> BbdS6Defaults { get; set; }

    public virtual DbSet<BbdS7C1> BbdS7C1s { get; set; }

    public virtual DbSet<BbdS7C10> BbdS7C10s { get; set; }

    public virtual DbSet<BbdS7C2> BbdS7C2s { get; set; }

    public virtual DbSet<BbdS7Default> BbdS7Defaults { get; set; }

    public virtual DbSet<BbdS8C1> BbdS8C1s { get; set; }

    public virtual DbSet<BbdS8C10> BbdS8C10s { get; set; }

    public virtual DbSet<BbdS8C2> BbdS8C2s { get; set; }

    public virtual DbSet<BbdS8Default> BbdS8Defaults { get; set; }

    public virtual DbSet<BbdS9C1> BbdS9C1s { get; set; }

    public virtual DbSet<BbdS9C10> BbdS9C10s { get; set; }

    public virtual DbSet<BbdS9C2> BbdS9C2s { get; set; }

    public virtual DbSet<BbdS9Default> BbdS9Defaults { get; set; }

    public virtual DbSet<BcdDefault> BcdDefaults { get; set; }

    public virtual DbSet<BcdS10C1> BcdS10C1s { get; set; }

    public virtual DbSet<BcdS10C10> BcdS10C10s { get; set; }

    public virtual DbSet<BcdS10C2> BcdS10C2s { get; set; }

    public virtual DbSet<BcdS10Default> BcdS10Defaults { get; set; }

    public virtual DbSet<BcdS11C1> BcdS11C1s { get; set; }

    public virtual DbSet<BcdS11C10> BcdS11C10s { get; set; }

    public virtual DbSet<BcdS11C2> BcdS11C2s { get; set; }

    public virtual DbSet<BcdS11Default> BcdS11Defaults { get; set; }

    public virtual DbSet<BcdS13C1> BcdS13C1s { get; set; }

    public virtual DbSet<BcdS13C10> BcdS13C10s { get; set; }

    public virtual DbSet<BcdS13C2> BcdS13C2s { get; set; }

    public virtual DbSet<BcdS13Default> BcdS13Defaults { get; set; }

    public virtual DbSet<BcdS17C1> BcdS17C1s { get; set; }

    public virtual DbSet<BcdS17C10> BcdS17C10s { get; set; }

    public virtual DbSet<BcdS17C2> BcdS17C2s { get; set; }

    public virtual DbSet<BcdS17Default> BcdS17Defaults { get; set; }

    public virtual DbSet<BcdS19C1> BcdS19C1s { get; set; }

    public virtual DbSet<BcdS19C10> BcdS19C10s { get; set; }

    public virtual DbSet<BcdS19C2> BcdS19C2s { get; set; }

    public virtual DbSet<BcdS19Default> BcdS19Defaults { get; set; }

    public virtual DbSet<BcdS1C1> BcdS1C1s { get; set; }

    public virtual DbSet<BcdS1C10> BcdS1C10s { get; set; }

    public virtual DbSet<BcdS1C2> BcdS1C2s { get; set; }

    public virtual DbSet<BcdS1Default> BcdS1Defaults { get; set; }

    public virtual DbSet<BcdS20C1> BcdS20C1s { get; set; }

    public virtual DbSet<BcdS20C10> BcdS20C10s { get; set; }

    public virtual DbSet<BcdS20C2> BcdS20C2s { get; set; }

    public virtual DbSet<BcdS20Default> BcdS20Defaults { get; set; }

    public virtual DbSet<BcdS2C1> BcdS2C1s { get; set; }

    public virtual DbSet<BcdS2C10> BcdS2C10s { get; set; }

    public virtual DbSet<BcdS2C2> BcdS2C2s { get; set; }

    public virtual DbSet<BcdS2Default> BcdS2Defaults { get; set; }

    public virtual DbSet<BcdS3C1> BcdS3C1s { get; set; }

    public virtual DbSet<BcdS3C10> BcdS3C10s { get; set; }

    public virtual DbSet<BcdS3C2> BcdS3C2s { get; set; }

    public virtual DbSet<BcdS3Default> BcdS3Defaults { get; set; }

    public virtual DbSet<BcdS5C1> BcdS5C1s { get; set; }

    public virtual DbSet<BcdS5C10> BcdS5C10s { get; set; }

    public virtual DbSet<BcdS5C2> BcdS5C2s { get; set; }

    public virtual DbSet<BcdS5Default> BcdS5Defaults { get; set; }

    public virtual DbSet<BcdS6C1> BcdS6C1s { get; set; }

    public virtual DbSet<BcdS6C10> BcdS6C10s { get; set; }

    public virtual DbSet<BcdS6C2> BcdS6C2s { get; set; }

    public virtual DbSet<BcdS6Default> BcdS6Defaults { get; set; }

    public virtual DbSet<BcdS7C1> BcdS7C1s { get; set; }

    public virtual DbSet<BcdS7C10> BcdS7C10s { get; set; }

    public virtual DbSet<BcdS7C2> BcdS7C2s { get; set; }

    public virtual DbSet<BcdS7Default> BcdS7Defaults { get; set; }

    public virtual DbSet<BcdS8C1> BcdS8C1s { get; set; }

    public virtual DbSet<BcdS8C10> BcdS8C10s { get; set; }

    public virtual DbSet<BcdS8C2> BcdS8C2s { get; set; }

    public virtual DbSet<BcdS8Default> BcdS8Defaults { get; set; }

    public virtual DbSet<BcdS9C1> BcdS9C1s { get; set; }

    public virtual DbSet<BcdS9C10> BcdS9C10s { get; set; }

    public virtual DbSet<BcdS9C2> BcdS9C2s { get; set; }

    public virtual DbSet<BcdS9Default> BcdS9Defaults { get; set; }

    public virtual DbSet<BddDefault> BddDefaults { get; set; }

    public virtual DbSet<BddS10C1> BddS10C1s { get; set; }

    public virtual DbSet<BddS10C10> BddS10C10s { get; set; }

    public virtual DbSet<BddS10C2> BddS10C2s { get; set; }

    public virtual DbSet<BddS10Default> BddS10Defaults { get; set; }

    public virtual DbSet<BddS11C1> BddS11C1s { get; set; }

    public virtual DbSet<BddS11C10> BddS11C10s { get; set; }

    public virtual DbSet<BddS11C2> BddS11C2s { get; set; }

    public virtual DbSet<BddS11Default> BddS11Defaults { get; set; }

    public virtual DbSet<BddS13C1> BddS13C1s { get; set; }

    public virtual DbSet<BddS13C10> BddS13C10s { get; set; }

    public virtual DbSet<BddS13C2> BddS13C2s { get; set; }

    public virtual DbSet<BddS13Default> BddS13Defaults { get; set; }

    public virtual DbSet<BddS17C1> BddS17C1s { get; set; }

    public virtual DbSet<BddS17C10> BddS17C10s { get; set; }

    public virtual DbSet<BddS17C2> BddS17C2s { get; set; }

    public virtual DbSet<BddS17Default> BddS17Defaults { get; set; }

    public virtual DbSet<BddS19C1> BddS19C1s { get; set; }

    public virtual DbSet<BddS19C10> BddS19C10s { get; set; }

    public virtual DbSet<BddS19C2> BddS19C2s { get; set; }

    public virtual DbSet<BddS19Default> BddS19Defaults { get; set; }

    public virtual DbSet<BddS1C1> BddS1C1s { get; set; }

    public virtual DbSet<BddS1C10> BddS1C10s { get; set; }

    public virtual DbSet<BddS1C2> BddS1C2s { get; set; }

    public virtual DbSet<BddS1Default> BddS1Defaults { get; set; }

    public virtual DbSet<BddS20C1> BddS20C1s { get; set; }

    public virtual DbSet<BddS20C10> BddS20C10s { get; set; }

    public virtual DbSet<BddS20C2> BddS20C2s { get; set; }

    public virtual DbSet<BddS20Default> BddS20Defaults { get; set; }

    public virtual DbSet<BddS2C1> BddS2C1s { get; set; }

    public virtual DbSet<BddS2C10> BddS2C10s { get; set; }

    public virtual DbSet<BddS2C2> BddS2C2s { get; set; }

    public virtual DbSet<BddS2Default> BddS2Defaults { get; set; }

    public virtual DbSet<BddS3C1> BddS3C1s { get; set; }

    public virtual DbSet<BddS3C10> BddS3C10s { get; set; }

    public virtual DbSet<BddS3C2> BddS3C2s { get; set; }

    public virtual DbSet<BddS3Default> BddS3Defaults { get; set; }

    public virtual DbSet<BddS5C1> BddS5C1s { get; set; }

    public virtual DbSet<BddS5C10> BddS5C10s { get; set; }

    public virtual DbSet<BddS5C2> BddS5C2s { get; set; }

    public virtual DbSet<BddS5Default> BddS5Defaults { get; set; }

    public virtual DbSet<BddS6C1> BddS6C1s { get; set; }

    public virtual DbSet<BddS6C10> BddS6C10s { get; set; }

    public virtual DbSet<BddS6C2> BddS6C2s { get; set; }

    public virtual DbSet<BddS6Default> BddS6Defaults { get; set; }

    public virtual DbSet<BddS7C1> BddS7C1s { get; set; }

    public virtual DbSet<BddS7C10> BddS7C10s { get; set; }

    public virtual DbSet<BddS7C2> BddS7C2s { get; set; }

    public virtual DbSet<BddS7Default> BddS7Defaults { get; set; }

    public virtual DbSet<BddS8C1> BddS8C1s { get; set; }

    public virtual DbSet<BddS8C10> BddS8C10s { get; set; }

    public virtual DbSet<BddS8C2> BddS8C2s { get; set; }

    public virtual DbSet<BddS8Default> BddS8Defaults { get; set; }

    public virtual DbSet<BddS9C1> BddS9C1s { get; set; }

    public virtual DbSet<BddS9C10> BddS9C10s { get; set; }

    public virtual DbSet<BddS9C2> BddS9C2s { get; set; }

    public virtual DbSet<BddS9Default> BddS9Defaults { get; set; }

    public virtual DbSet<BeneficiaryLandDetail> BeneficiaryLandDetails { get; set; }

    public virtual DbSet<Block> Blocks { get; set; }

    public virtual DbSet<BpdDefault> BpdDefaults { get; set; }

    public virtual DbSet<BpdS10C1> BpdS10C1s { get; set; }

    public virtual DbSet<BpdS10C10> BpdS10C10s { get; set; }

    public virtual DbSet<BpdS10C2> BpdS10C2s { get; set; }

    public virtual DbSet<BpdS10Default> BpdS10Defaults { get; set; }

    public virtual DbSet<BpdS11C1> BpdS11C1s { get; set; }

    public virtual DbSet<BpdS11C10> BpdS11C10s { get; set; }

    public virtual DbSet<BpdS11C2> BpdS11C2s { get; set; }

    public virtual DbSet<BpdS11Default> BpdS11Defaults { get; set; }

    public virtual DbSet<BpdS13C1> BpdS13C1s { get; set; }

    public virtual DbSet<BpdS13C10> BpdS13C10s { get; set; }

    public virtual DbSet<BpdS13C2> BpdS13C2s { get; set; }

    public virtual DbSet<BpdS13Default> BpdS13Defaults { get; set; }

    public virtual DbSet<BpdS17C1> BpdS17C1s { get; set; }

    public virtual DbSet<BpdS17C10> BpdS17C10s { get; set; }

    public virtual DbSet<BpdS17C2> BpdS17C2s { get; set; }

    public virtual DbSet<BpdS17Default> BpdS17Defaults { get; set; }

    public virtual DbSet<BpdS19C1> BpdS19C1s { get; set; }

    public virtual DbSet<BpdS19C10> BpdS19C10s { get; set; }

    public virtual DbSet<BpdS19C2> BpdS19C2s { get; set; }

    public virtual DbSet<BpdS19Default> BpdS19Defaults { get; set; }

    public virtual DbSet<BpdS1C1> BpdS1C1s { get; set; }

    public virtual DbSet<BpdS1C10> BpdS1C10s { get; set; }

    public virtual DbSet<BpdS1C2> BpdS1C2s { get; set; }

    public virtual DbSet<BpdS1Default> BpdS1Defaults { get; set; }

    public virtual DbSet<BpdS20C1> BpdS20C1s { get; set; }

    public virtual DbSet<BpdS20C10> BpdS20C10s { get; set; }

    public virtual DbSet<BpdS20C2> BpdS20C2s { get; set; }

    public virtual DbSet<BpdS20Default> BpdS20Defaults { get; set; }

    public virtual DbSet<BpdS2C1> BpdS2C1s { get; set; }

    public virtual DbSet<BpdS2C10> BpdS2C10s { get; set; }

    public virtual DbSet<BpdS2C2> BpdS2C2s { get; set; }

    public virtual DbSet<BpdS2Default> BpdS2Defaults { get; set; }

    public virtual DbSet<BpdS3C1> BpdS3C1s { get; set; }

    public virtual DbSet<BpdS3C10> BpdS3C10s { get; set; }

    public virtual DbSet<BpdS3C2> BpdS3C2s { get; set; }

    public virtual DbSet<BpdS3Default> BpdS3Defaults { get; set; }

    public virtual DbSet<BpdS5C1> BpdS5C1s { get; set; }

    public virtual DbSet<BpdS5C10> BpdS5C10s { get; set; }

    public virtual DbSet<BpdS5C2> BpdS5C2s { get; set; }

    public virtual DbSet<BpdS5Default> BpdS5Defaults { get; set; }

    public virtual DbSet<BpdS6C1> BpdS6C1s { get; set; }

    public virtual DbSet<BpdS6C10> BpdS6C10s { get; set; }

    public virtual DbSet<BpdS6C2> BpdS6C2s { get; set; }

    public virtual DbSet<BpdS6Default> BpdS6Defaults { get; set; }

    public virtual DbSet<BpdS7C1> BpdS7C1s { get; set; }

    public virtual DbSet<BpdS7C10> BpdS7C10s { get; set; }

    public virtual DbSet<BpdS7C2> BpdS7C2s { get; set; }

    public virtual DbSet<BpdS7Default> BpdS7Defaults { get; set; }

    public virtual DbSet<BpdS8C1> BpdS8C1s { get; set; }

    public virtual DbSet<BpdS8C10> BpdS8C10s { get; set; }

    public virtual DbSet<BpdS8C2> BpdS8C2s { get; set; }

    public virtual DbSet<BpdS8Default> BpdS8Defaults { get; set; }

    public virtual DbSet<BpdS9C1> BpdS9C1s { get; set; }

    public virtual DbSet<BpdS9C10> BpdS9C10s { get; set; }

    public virtual DbSet<BpdS9C2> BpdS9C2s { get; set; }

    public virtual DbSet<BpdS9Default> BpdS9Defaults { get; set; }

    public virtual DbSet<Cache> Caches { get; set; }

    public virtual DbSet<CacheLock> CacheLocks { get; set; }

    public virtual DbSet<ChangeTypeMaster> ChangeTypeMasters { get; set; }

    public virtual DbSet<Codemaster> Codemasters { get; set; }

    public virtual DbSet<CriticalChangeMaster> CriticalChangeMasters { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<DsMapRecord> DsMapRecords { get; set; }

    public virtual DbSet<DsPhase> DsPhases { get; set; }

    public virtual DbSet<DupcheckschemeconfigSetting> DupcheckschemeconfigSettings { get; set; }

    public virtual DbSet<DynamicWorkflowLabel> DynamicWorkflowLabels { get; set; }

    public virtual DbSet<DynamicWorkflowModule> DynamicWorkflowModules { get; set; }

    public virtual DbSet<DynamicWorkflowRequest> DynamicWorkflowRequests { get; set; }

    public virtual DbSet<DynamicWorkflowSchemeModule> DynamicWorkflowSchemeModules { get; set; }

    public virtual DbSet<FailedJob> FailedJobs { get; set; }

    public virtual DbSet<Ifsccodemaster> Ifsccodemasters { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<JobBatch> JobBatches { get; set; }

    public virtual DbSet<LandDetail> LandDetails { get; set; }

    public virtual DbSet<LivewireActionLog> LivewireActionLogs { get; set; }

    public virtual DbSet<MasterMimeType> MasterMimeTypes { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<ModelHasPermission> ModelHasPermissions { get; set; }

    public virtual DbSet<ModelHasRole> ModelHasRoles { get; set; }

    public virtual DbSet<Municipality> Municipalities { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<OfficeMaster> OfficeMasters { get; set; }

    public virtual DbSet<Panchayat> Panchayats { get; set; }

    public virtual DbSet<PasswordHistory> PasswordHistories { get; set; }

    public virtual DbSet<PasswordResetToken> PasswordResetTokens { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RoleOfficeTypeMapping> RoleOfficeTypeMappings { get; set; }

    public virtual DbSet<Scheme> Schemes { get; set; }

    public virtual DbSet<SchemeAttachedDocMapping> SchemeAttachedDocMappings { get; set; }

    public virtual DbSet<SchemeCapacity> SchemeCapacities { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Subdivision> Subdivisions { get; set; }

    public virtual DbSet<UniqueAppBenId> UniqueAppBenIds { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAuditTrail> UserAuditTrails { get; set; }

    public virtual DbSet<UserPageVisitLog> UserPageVisitLogs { get; set; }

    public virtual DbSet<UserPersonal> UserPersonals { get; set; }

    public virtual DbSet<UserRoleSchemeOfficeMapping> UserRoleSchemeOfficeMappings { get; set; }

    public virtual DbSet<VerificationCode> VerificationCodes { get; set; }

    public virtual DbSet<Ward> Wards { get; set; }

    public virtual DbSet<WorkflowStep> WorkflowSteps { get; set; }

    public virtual DbSet<WorkflowstepRolemapping> WorkflowstepRolemappings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Name=ConnectionStrings:DBConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcceptRejectInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accept_reject_infos_pkey");

            entity.Property(e => e.CriticalChanges).HasDefaultValueSql("'0'::smallint");
            entity.Property(e => e.OldOpType).IsFixedLength();

            entity.HasOne(d => d.OpTypeNavigation).WithMany(p => p.AcceptRejectInfoOpTypeNavigations)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("op_type_fk");

            entity.HasOne(d => d.RevertReasonCause).WithMany(p => p.AcceptRejectInfoRevertReasonCauses).HasConstraintName("reject_revert_reason_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.AcceptRejectInfos)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<ActivityLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("activity_log_pkey");
        });

        modelBuilder.Entity<AgeManagement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("age_managements_pkey");

            entity.Property(e => e.IsSpecial).HasDefaultValue(false);
        });

        modelBuilder.Entity<Audit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("audits_pkey");
        });

        modelBuilder.Entity<Bankmaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bankmasters_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");
        });

        modelBuilder.Entity<BbdDefault>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdDefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdDefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdDefaults)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdDefaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS10C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s10_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS10C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS10C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS10C1s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS10C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS10C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s10_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS10C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS10C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS10C10s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS10C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS10C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s10_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS10C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS10C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS10C2s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS10C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS10Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s10_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS10DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS10DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS10Defaults)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS10Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS11C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s11_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS11C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS11C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS11C1s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS11C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS11C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s11_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS11C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS11C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS11C10s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS11C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS11C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s11_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS11C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS11C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS11C2s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS11C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS11Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s11_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS11DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS11DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS11Defaults)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS11Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS13C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s13_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS13C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS13C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS13C1s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS13C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS13C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s13_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS13C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS13C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS13C10s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS13C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS13C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s13_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS13C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS13C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS13C2s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS13C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS13Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s13_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS13DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS13DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS13Defaults)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS13Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS17C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s17_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS17C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS17C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS17C1s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS17C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS17C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s17_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS17C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS17C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS17C10s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS17C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS17C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s17_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS17C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS17C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS17C2s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS17C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS17Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s17_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS17DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS17DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS17Defaults)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS17Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS19C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s19_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS19C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS19C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS19C1s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS19C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS19C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s19_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS19C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS19C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS19C10s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS19C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS19C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s19_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS19C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS19C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS19C2s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS19C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS19Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s19_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS19DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS19DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS19Defaults)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS19Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS1C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s1_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS1C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS1C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS1C1s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS1C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS1C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s1_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS1C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS1C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS1C10s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS1C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS1C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s1_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS1C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS1C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS1C2s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS1C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS1Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s1_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS1DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS1DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS1Defaults)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS1Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS20C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s20_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS20C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS20C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS20C1s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS20C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS20C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s20_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS20C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS20C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS20C10s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS20C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS20C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s20_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS20C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS20C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS20C2s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS20C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS20Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s20_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS20DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS20DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS20Defaults)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS20Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS2C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s2_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS2C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS2C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS2C1s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS2C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS2C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s2_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS2C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS2C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS2C10s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS2C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS2C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s2_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS2C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS2C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS2C2s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS2C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS2Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s2_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS2DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS2DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS2Defaults)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS2Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS3C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s3_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS3C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS3C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS3C1s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS3C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS3C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s3_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS3C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS3C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS3C10s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS3C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS3C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s3_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS3C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS3C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS3C2s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS3C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS3Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s3_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS3DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS3DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS3Defaults)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS3Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS5C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s5_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS5C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS5C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS5C1s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS5C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS5C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s5_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS5C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS5C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS5C10s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS5C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS5C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s5_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS5C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS5C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS5C2s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS5C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS5Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s5_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS5DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS5DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS5Defaults)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS5Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS6C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s6_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS6C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS6C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS6C1s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS6C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS6C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s6_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS6C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS6C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS6C10s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS6C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS6C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s6_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS6C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS6C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS6C2s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS6C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS6Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s6_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS6DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS6DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS6Defaults)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS6Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS7C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s7_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS7C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS7C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS7C1s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS7C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS7C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s7_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS7C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS7C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS7C10s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS7C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS7C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s7_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS7C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS7C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS7C2s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS7C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS7Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s7_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS7DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS7DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS7Defaults)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS7Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS8C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s8_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS8C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS8C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS8C1s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS8C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS8C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s8_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS8C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS8C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS8C10s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS8C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS8C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s8_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS8C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS8C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS8C2s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS8C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS8Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s8_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS8DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS8DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS8Defaults)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS8Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS9C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s9_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS9C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS9C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS9C1s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS9C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS9C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s9_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS9C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS9C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS9C10s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS9C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS9C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s9_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS9C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS9C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS9C2s)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS9C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BbdS9Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bbd_s9_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BbdS9DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BbdS9DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bbd_beneficiary_id");

            entity.HasOne(d => d.IfscodeNavigation).WithMany(p => p.BbdS9Defaults)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.Ifscode)
                .HasConstraintName("fk_bbd_ifsc");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BbdS9Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bbd_scheme_id");
        });

        modelBuilder.Entity<BcdDefault>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdDefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdDefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdDefaults).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdDefaults).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdDefaults).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdDefaults).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdDefaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdDefaults).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS10C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s10_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS10C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS10C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS10C1s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS10C1s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS10C1s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS10C1s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS10C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS10C1s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS10C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s10_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS10C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS10C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS10C10s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS10C10s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS10C10s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS10C10s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS10C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS10C10s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS10C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s10_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS10C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS10C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS10C2s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS10C2s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS10C2s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS10C2s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS10C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS10C2s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS10Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s10_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS10DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS10DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS10Defaults).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS10Defaults).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS10Defaults).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS10Defaults).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS10Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS10Defaults).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS11C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s11_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS11C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS11C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS11C1s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS11C1s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS11C1s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS11C1s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS11C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS11C1s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS11C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s11_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS11C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS11C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS11C10s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS11C10s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS11C10s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS11C10s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS11C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS11C10s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS11C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s11_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS11C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS11C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS11C2s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS11C2s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS11C2s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS11C2s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS11C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS11C2s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS11Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s11_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS11DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS11DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS11Defaults).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS11Defaults).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS11Defaults).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS11Defaults).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS11Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS11Defaults).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS13C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s13_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS13C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS13C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS13C1s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS13C1s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS13C1s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS13C1s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS13C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS13C1s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS13C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s13_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS13C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS13C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS13C10s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS13C10s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS13C10s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS13C10s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS13C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS13C10s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS13C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s13_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS13C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS13C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS13C2s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS13C2s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS13C2s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS13C2s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS13C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS13C2s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS13Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s13_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS13DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS13DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS13Defaults).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS13Defaults).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS13Defaults).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS13Defaults).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS13Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS13Defaults).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS17C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s17_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS17C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS17C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS17C1s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS17C1s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS17C1s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS17C1s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS17C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS17C1s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS17C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s17_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS17C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS17C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS17C10s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS17C10s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS17C10s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS17C10s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS17C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS17C10s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS17C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s17_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS17C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS17C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS17C2s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS17C2s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS17C2s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS17C2s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS17C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS17C2s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS17Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s17_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS17DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS17DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS17Defaults).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS17Defaults).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS17Defaults).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS17Defaults).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS17Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS17Defaults).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS19C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s19_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS19C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS19C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS19C1s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS19C1s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS19C1s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS19C1s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS19C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS19C1s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS19C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s19_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS19C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS19C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS19C10s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS19C10s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS19C10s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS19C10s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS19C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS19C10s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS19C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s19_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS19C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS19C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS19C2s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS19C2s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS19C2s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS19C2s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS19C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS19C2s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS19Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s19_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS19DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS19DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS19Defaults).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS19Defaults).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS19Defaults).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS19Defaults).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS19Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS19Defaults).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS1C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s1_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS1C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS1C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS1C1s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS1C1s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS1C1s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS1C1s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS1C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS1C1s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS1C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s1_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS1C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS1C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS1C10s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS1C10s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS1C10s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS1C10s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS1C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS1C10s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS1C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s1_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS1C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS1C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS1C2s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS1C2s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS1C2s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS1C2s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS1C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS1C2s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS1Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s1_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS1DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS1DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS1Defaults).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS1Defaults).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS1Defaults).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS1Defaults).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS1Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS1Defaults).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS20C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s20_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS20C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS20C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS20C1s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS20C1s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS20C1s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS20C1s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS20C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS20C1s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS20C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s20_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS20C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS20C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS20C10s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS20C10s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS20C10s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS20C10s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS20C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS20C10s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS20C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s20_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS20C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS20C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS20C2s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS20C2s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS20C2s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS20C2s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS20C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS20C2s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS20Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s20_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS20DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS20DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS20Defaults).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS20Defaults).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS20Defaults).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS20Defaults).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS20Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS20Defaults).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS2C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s2_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS2C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS2C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS2C1s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS2C1s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS2C1s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS2C1s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS2C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS2C1s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS2C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s2_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS2C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS2C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS2C10s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS2C10s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS2C10s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS2C10s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS2C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS2C10s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS2C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s2_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS2C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS2C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS2C2s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS2C2s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS2C2s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS2C2s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS2C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS2C2s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS2Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s2_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS2DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS2DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS2Defaults).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS2Defaults).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS2Defaults).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS2Defaults).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS2Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS2Defaults).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS3C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s3_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS3C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS3C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS3C1s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS3C1s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS3C1s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS3C1s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS3C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS3C1s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS3C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s3_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS3C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS3C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS3C10s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS3C10s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS3C10s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS3C10s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS3C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS3C10s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS3C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s3_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS3C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS3C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS3C2s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS3C2s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS3C2s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS3C2s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS3C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS3C2s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS3Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s3_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS3DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS3DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS3Defaults).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS3Defaults).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS3Defaults).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS3Defaults).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS3Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS3Defaults).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS5C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s5_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS5C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS5C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS5C1s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS5C1s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS5C1s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS5C1s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS5C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS5C1s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS5C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s5_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS5C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS5C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS5C10s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS5C10s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS5C10s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS5C10s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS5C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS5C10s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS5C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s5_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS5C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS5C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS5C2s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS5C2s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS5C2s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS5C2s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS5C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS5C2s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS5Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s5_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS5DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS5DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS5Defaults).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS5Defaults).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS5Defaults).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS5Defaults).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS5Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS5Defaults).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS6C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s6_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS6C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS6C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS6C1s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS6C1s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS6C1s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS6C1s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS6C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS6C1s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS6C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s6_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS6C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS6C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS6C10s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS6C10s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS6C10s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS6C10s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS6C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS6C10s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS6C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s6_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS6C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS6C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS6C2s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS6C2s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS6C2s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS6C2s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS6C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS6C2s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS6Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s6_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS6DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS6DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS6Defaults).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS6Defaults).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS6Defaults).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS6Defaults).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS6Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS6Defaults).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS7C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s7_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS7C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS7C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS7C1s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS7C1s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS7C1s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS7C1s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS7C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS7C1s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS7C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s7_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS7C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS7C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS7C10s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS7C10s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS7C10s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS7C10s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS7C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS7C10s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS7C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s7_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS7C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS7C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS7C2s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS7C2s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS7C2s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS7C2s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS7C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS7C2s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS7Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s7_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS7DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS7DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS7Defaults).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS7Defaults).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS7Defaults).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS7Defaults).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS7Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS7Defaults).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS8C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s8_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS8C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS8C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS8C1s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS8C1s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS8C1s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS8C1s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS8C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS8C1s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS8C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s8_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS8C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS8C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS8C10s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS8C10s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS8C10s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS8C10s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS8C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS8C10s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS8C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s8_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS8C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS8C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS8C2s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS8C2s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS8C2s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS8C2s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS8C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS8C2s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS8Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s8_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS8DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS8DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS8Defaults).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS8Defaults).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS8Defaults).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS8Defaults).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS8Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS8Defaults).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS9C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s9_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS9C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS9C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS9C1s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS9C1s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS9C1s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS9C1s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS9C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS9C1s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS9C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s9_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS9C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS9C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS9C10s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS9C10s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS9C10s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS9C10s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS9C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS9C10s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS9C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s9_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS9C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS9C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS9C2s).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS9C2s).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS9C2s).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS9C2s).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS9C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS9C2s).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BcdS9Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bcd_s9_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.Pincode).IsFixedLength();

            entity.HasOne(d => d.Application).WithMany(p => p.BcdS9DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BcdS9DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bcd_beneficiary_id");

            entity.HasOne(d => d.BlockNavigation).WithMany(p => p.BcdS9Defaults).HasConstraintName("fk_bcd_block");

            entity.HasOne(d => d.District).WithMany(p => p.BcdS9Defaults).HasConstraintName("fk_bcd_district_id");

            entity.HasOne(d => d.GpNavigation).WithMany(p => p.BcdS9Defaults).HasConstraintName("fk_bcd_gp");

            entity.HasOne(d => d.MunicipalityNavigation).WithMany(p => p.BcdS9Defaults).HasConstraintName("fk_bcd_municipality");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BcdS9Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bcd_scheme_id");

            entity.HasOne(d => d.WardNavigation).WithMany(p => p.BcdS9Defaults).HasConstraintName("fk_bcd_ward");
        });

        modelBuilder.Entity<BddDefault>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddDefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddDefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddDefaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS10C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s10_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS10C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS10C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS10C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS10C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s10_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS10C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS10C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS10C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS10C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s10_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS10C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS10C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS10C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS10Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s10_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS10DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS10DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS10Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS11C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s11_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS11C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS11C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS11C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS11C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s11_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS11C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS11C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS11C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS11C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s11_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS11C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS11C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS11C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS11Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s11_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS11DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS11DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS11Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS13C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s13_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS13C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS13C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS13C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS13C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s13_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS13C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS13C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS13C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS13C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s13_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS13C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS13C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS13C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS13Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s13_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS13DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS13DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS13Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS17C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s17_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS17C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS17C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS17C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS17C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s17_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS17C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS17C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS17C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS17C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s17_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS17C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS17C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS17C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS17Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s17_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS17DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS17DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS17Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS19C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s19_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS19C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS19C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS19C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS19C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s19_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS19C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS19C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS19C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS19C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s19_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS19C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS19C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS19C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS19Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s19_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS19DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS19DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS19Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS1C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s1_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS1C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS1C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS1C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS1C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s1_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS1C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS1C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS1C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS1C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s1_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS1C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS1C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS1C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS1Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s1_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS1DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS1DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS1Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS20C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s20_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS20C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS20C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS20C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS20C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s20_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS20C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS20C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS20C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS20C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s20_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS20C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS20C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS20C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS20Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s20_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS20DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS20DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS20Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS2C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s2_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS2C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS2C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS2C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS2C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s2_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS2C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS2C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS2C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS2C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s2_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS2C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS2C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS2C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS2Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s2_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS2DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS2DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS2Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS3C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s3_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS3C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS3C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS3C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS3C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s3_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS3C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS3C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS3C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS3C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s3_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS3C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS3C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS3C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS3Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s3_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS3DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS3DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS3Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS5C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s5_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS5C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS5C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS5C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS5C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s5_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS5C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS5C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS5C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS5C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s5_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS5C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS5C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS5C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS5Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s5_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS5DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS5DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS5Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS6C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s6_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS6C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS6C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS6C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS6C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s6_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS6C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS6C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS6C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS6C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s6_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS6C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS6C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS6C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS6Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s6_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS6DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS6DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS6Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS7C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s7_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS7C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS7C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS7C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS7C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s7_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS7C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS7C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS7C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS7C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s7_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS7C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS7C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS7C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS7Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s7_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS7DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS7DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS7Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS8C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s8_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS8C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS8C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS8C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS8C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s8_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS8C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS8C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS8C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS8C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s8_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS8C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS8C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS8C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS8Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s8_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS8DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS8DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS8Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS9C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s9_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS9C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS9C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS9C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS9C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s9_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS9C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS9C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS9C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS9C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s9_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS9C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS9C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS9C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BddS9Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bdd_s9_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);

            entity.HasOne(d => d.Application).WithMany(p => p.BddS9DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BddS9DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bdd_beneficiary_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BddS9Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bdd_scheme_id");
        });

        modelBuilder.Entity<BeneficiaryLandDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("beneficiary_land_details_pkey");

            entity.HasOne(d => d.Application).WithOne(p => p.BeneficiaryLandDetailApplication).HasConstraintName("application_id_fk");

            entity.HasOne(d => d.Beneficiary).WithOne(p => p.BeneficiaryLandDetailBeneficiary)
                .HasPrincipalKey<UniqueAppBenId>(p => p.BeneficiaryId)
                .HasForeignKey<BeneficiaryLandDetail>(d => d.BeneficiaryId)
                .HasConstraintName("beneficiary_id_fk");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BeneficiaryLandDetails).HasConstraintName("scheme_id_fk");
        });

        modelBuilder.Entity<Block>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("blocks_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");

            entity.HasOne(d => d.District).WithMany(p => p.Blocks).HasConstraintName("district_id_fk");
        });

        modelBuilder.Entity<BpdDefault>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdDefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdDefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdDefaultCasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdDefaultMaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdDefaultNextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdDefaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS10C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s10_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS10C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS10C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS10C1CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS10C1MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS10C1NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS10C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS10C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s10_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS10C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS10C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS10C10CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS10C10MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS10C10NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS10C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS10C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s10_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS10C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS10C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS10C2CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS10C2MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS10C2NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS10C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS10Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s10_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS10DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS10DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS10DefaultCasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS10DefaultMaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS10DefaultNextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS10Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS11C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s11_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS11C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS11C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS11C1CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS11C1MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS11C1NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS11C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS11C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s11_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS11C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS11C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS11C10CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS11C10MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS11C10NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS11C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS11C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s11_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS11C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS11C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS11C2CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS11C2MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS11C2NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS11C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS11Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s11_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS11DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS11DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS11DefaultCasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS11DefaultMaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS11DefaultNextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS11Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS13C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s13_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS13C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS13C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS13C1CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS13C1MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS13C1NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS13C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS13C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s13_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS13C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS13C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS13C10CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS13C10MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS13C10NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS13C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS13C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s13_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS13C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS13C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS13C2CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS13C2MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS13C2NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS13C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS13Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s13_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS13DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS13DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS13DefaultCasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS13DefaultMaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS13DefaultNextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS13Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS17C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s17_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS17C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS17C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS17C1CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS17C1MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS17C1NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS17C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS17C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s17_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS17C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS17C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS17C10CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS17C10MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS17C10NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS17C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS17C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s17_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS17C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS17C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS17C2CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS17C2MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS17C2NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS17C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS17Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s17_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS17DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS17DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS17DefaultCasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS17DefaultMaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS17DefaultNextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS17Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS19C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s19_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS19C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS19C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS19C1CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS19C1MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS19C1NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS19C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS19C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s19_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS19C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS19C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS19C10CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS19C10MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS19C10NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS19C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS19C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s19_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS19C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS19C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS19C2CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS19C2MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS19C2NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS19C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS19Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s19_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS19DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS19DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS19DefaultCasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS19DefaultMaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS19DefaultNextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS19Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS1C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s1_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS1C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS1C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS1C1CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS1C1MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS1C1NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS1C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS1C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s1_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS1C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS1C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS1C10CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS1C10MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS1C10NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS1C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS1C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s1_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS1C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS1C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS1C2CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS1C2MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS1C2NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS1C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS1Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s1_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS1DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS1DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS1DefaultCasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS1DefaultMaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS1DefaultNextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS1Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS20C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s20_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS20C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS20C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS20C1CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS20C1MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS20C1NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS20C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS20C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s20_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS20C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS20C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS20C10CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS20C10MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS20C10NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS20C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS20C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s20_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS20C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS20C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS20C2CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS20C2MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS20C2NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS20C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS20Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s20_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS20DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS20DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS20DefaultCasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS20DefaultMaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS20DefaultNextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS20Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS2C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s2_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS2C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS2C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS2C1CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS2C1MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS2C1NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS2C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS2C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s2_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS2C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS2C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS2C10CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS2C10MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS2C10NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS2C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS2C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s2_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS2C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS2C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS2C2CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS2C2MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS2C2NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS2C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS2Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s2_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS2DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS2DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS2DefaultCasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS2DefaultMaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS2DefaultNextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS2Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS3C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s3_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS3C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS3C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS3C1CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS3C1MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS3C1NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS3C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS3C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s3_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS3C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS3C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS3C10CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS3C10MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS3C10NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS3C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS3C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s3_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS3C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS3C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS3C2CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS3C2MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS3C2NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS3C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS3Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s3_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS3DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS3DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS3DefaultCasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS3DefaultMaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS3DefaultNextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS3Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS5C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s5_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS5C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS5C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS5C1CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS5C1MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS5C1NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS5C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS5C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s5_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS5C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS5C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS5C10CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS5C10MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS5C10NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS5C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS5C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s5_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS5C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS5C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS5C2CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS5C2MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS5C2NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS5C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS5Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s5_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS5DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS5DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS5DefaultCasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS5DefaultMaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS5DefaultNextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS5Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS6C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s6_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS6C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS6C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS6C1CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS6C1MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS6C1NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS6C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS6C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s6_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS6C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS6C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS6C10CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS6C10MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS6C10NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS6C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS6C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s6_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS6C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS6C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS6C2CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS6C2MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS6C2NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS6C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS6Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s6_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS6DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS6DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS6DefaultCasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS6DefaultMaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS6DefaultNextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS6Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS7C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s7_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS7C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS7C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS7C1CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS7C1MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS7C1NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS7C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS7C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s7_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS7C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS7C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS7C10CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS7C10MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS7C10NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS7C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS7C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s7_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS7C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS7C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS7C2CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS7C2MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS7C2NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS7C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS7Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s7_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS7DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS7DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS7DefaultCasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS7DefaultMaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS7DefaultNextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS7Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS8C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s8_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS8C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS8C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS8C1CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS8C1MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS8C1NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS8C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS8C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s8_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS8C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS8C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS8C10CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS8C10MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS8C10NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS8C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS8C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s8_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS8C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS8C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS8C2CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS8C2MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS8C2NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS8C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS8Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s8_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS8DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS8DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS8DefaultCasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS8DefaultMaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS8DefaultNextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS8Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS9C1>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s9_c1_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS9C1Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS9C1Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS9C1CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS9C1MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS9C1NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS9C1s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS9C10>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s9_c10_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS9C10Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS9C10Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS9C10CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS9C10MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS9C10NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS9C10s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS9C2>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s9_c2_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS9C2Applications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS9C2Beneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS9C2CasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS9C2MaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS9C2NextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS9C2s)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<BpdS9Default>(entity =>
        {
            entity.HasKey(e => new { e.ApplicationId, e.SchemeId, e.IsClean }).HasName("bpd_s9_default_pkey");

            entity.Property(e => e.IsClean).HasDefaultValue((short)1);
            entity.Property(e => e.IsFinal).HasDefaultValue((short)0);

            entity.HasOne(d => d.Application).WithMany(p => p.BpdS9DefaultApplications)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_application_id");

            entity.HasOne(d => d.Beneficiary).WithMany(p => p.BpdS9DefaultBeneficiaries)
                .HasPrincipalKey(p => p.BeneficiaryId)
                .HasForeignKey(d => d.BeneficiaryId)
                .HasConstraintName("fk_bpd_beneficiary_id");

            entity.HasOne(d => d.CasteNavigation).WithMany(p => p.BpdS9DefaultCasteNavigations).HasConstraintName("fk_bpd_caste");

            entity.HasOne(d => d.MaritalStatusNavigation).WithMany(p => p.BpdS9DefaultMaritalStatusNavigations).HasConstraintName("fk_bpd_marital_status");

            entity.HasOne(d => d.NextLevelRole).WithMany(p => p.BpdS9DefaultNextLevelRoles).HasConstraintName("fk_bpd_next_level_role_id");

            entity.HasOne(d => d.Scheme).WithMany(p => p.BpdS9Defaults)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bpd_scheme_id");
        });

        modelBuilder.Entity<Cache>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("cache_pkey");
        });

        modelBuilder.Entity<CacheLock>(entity =>
        {
            entity.HasKey(e => e.Key).HasName("cache_locks_pkey");
        });

        modelBuilder.Entity<ChangeTypeMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("change_type_masters_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");
        });

        modelBuilder.Entity<Codemaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("codemasters_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");
        });

        modelBuilder.Entity<CriticalChangeMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("critical_change_masters_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("departments_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");

            entity.HasOne(d => d.State).WithMany(p => p.Departments)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("1");
        });

        modelBuilder.Entity<District>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("districts_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");

            entity.HasOne(d => d.State).WithMany(p => p.Districts).HasConstraintName("state_id_fk");
        });

        modelBuilder.Entity<DsMapRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ds_map_records_pkey");
        });

        modelBuilder.Entity<DsPhase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ds_phases_pkey");

            entity.Property(e => e.IsCurrent).HasDefaultValue(false);
        });

        modelBuilder.Entity<DupcheckschemeconfigSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dupcheckschemeconfig_settings_pkey");

            entity.Property(e => e.IsCross).HasDefaultValue(false);
            entity.Property(e => e.IsSame).HasDefaultValue(false);
        });

        modelBuilder.Entity<DynamicWorkflowLabel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dynamic_workflow_labels_pkey");

            entity.HasOne(d => d.Module).WithMany(p => p.DynamicWorkflowLabels).HasConstraintName("dynamic_workflow_labels_module_id_foreign");
        });

        modelBuilder.Entity<DynamicWorkflowModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dynamic_workflow_modules_pkey");

            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<DynamicWorkflowRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dynamic_workflow_requests_pkey");

            entity.HasOne(d => d.Module).WithMany(p => p.DynamicWorkflowRequests).HasConstraintName("dynamic_workflow_requests_module_id_foreign");

            entity.HasOne(d => d.Scheme).WithMany(p => p.DynamicWorkflowRequests)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dynamic_workflow_requests_scheme_id_foreign");
        });

        modelBuilder.Entity<DynamicWorkflowSchemeModule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dynamic_workflow_scheme_modules_pkey");

            entity.Property(e => e.StepCount).HasDefaultValue(1);

            entity.HasOne(d => d.Module).WithMany(p => p.DynamicWorkflowSchemeModules).HasConstraintName("dynamic_workflow_scheme_modules_module_id_foreign");

            entity.HasOne(d => d.Scheme).WithMany(p => p.DynamicWorkflowSchemeModules)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dynamic_workflow_scheme_modules_scheme_id_foreign");
        });

        modelBuilder.Entity<FailedJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("failed_jobs_pkey");

            entity.Property(e => e.FailedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
        });

        modelBuilder.Entity<Ifsccodemaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ifsccodemasters_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");

            entity.HasOne(d => d.Bankmaster).WithMany(p => p.Ifsccodemasters).HasConstraintName("bankmaster_id_fk");

            entity.HasOne(d => d.State).WithMany(p => p.Ifsccodemasters).HasConstraintName("state_id_fk");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("jobs_pkey");
        });

        modelBuilder.Entity<JobBatch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("job_batches_pkey");
        });

        modelBuilder.Entity<LandDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("land_details_pkey");

            entity.HasOne(d => d.Application).WithOne(p => p.LandDetailApplication).HasConstraintName("application_id_fk");

            entity.HasOne(d => d.Beneficiary).WithOne(p => p.LandDetailBeneficiary)
                .HasPrincipalKey<UniqueAppBenId>(p => p.BeneficiaryId)
                .HasForeignKey<LandDetail>(d => d.BeneficiaryId)
                .HasConstraintName("beneficiary_id_fk");

            entity.HasOne(d => d.Scheme).WithMany(p => p.LandDetails).HasConstraintName("scheme_id_fk");
        });

        modelBuilder.Entity<LivewireActionLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("livewire_action_logs_pkey");

            entity.Property(e => e.LogLevel).HasDefaultValueSql("'N'::character varying");
        });

        modelBuilder.Entity<MasterMimeType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("master_mime_types_pkey");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("migrations_pkey");
        });

        modelBuilder.Entity<ModelHasPermission>(entity =>
        {
            entity.HasOne(d => d.Permission).WithMany().HasConstraintName("model_has_permissions_permission_id_foreign");
        });

        modelBuilder.Entity<ModelHasRole>(entity =>
        {
            entity.HasKey(e => new { e.RoleId, e.ModelId, e.ModelType }).HasName("model_has_roles_pkey");

            entity.HasOne(d => d.Role).WithMany(p => p.ModelHasRoles).HasConstraintName("model_has_roles_role_id_foreign");
        });

        modelBuilder.Entity<Municipality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("municipalities_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");

            entity.HasOne(d => d.Subdivision).WithMany(p => p.Municipalities).HasConstraintName("subdivision_id_fk");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("notifications_pkey");
        });

        modelBuilder.Entity<OfficeMaster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("office_masters_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");

            entity.HasOne(d => d.Block).WithMany(p => p.OfficeMasters)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("block_id_fk");

            entity.HasOne(d => d.District).WithMany(p => p.OfficeMasters)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("district_id_fk");

            entity.HasOne(d => d.Municipalitiy).WithMany(p => p.OfficeMasters)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("municipalitiy_id_fk");

            entity.HasOne(d => d.OfficeType).WithMany(p => p.OfficeMasters)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.OfficeTypeId)
                .HasConstraintName("office_type_id_fk");

            entity.HasOne(d => d.Panchayat).WithMany(p => p.OfficeMasters)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("panchayat_id_fk");

            entity.HasOne(d => d.State).WithMany(p => p.OfficeMasters).HasConstraintName("state_id_fk");

            entity.HasOne(d => d.Subdivision).WithMany(p => p.OfficeMasters)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("subdivision_id_fk");

            entity.HasOne(d => d.Ward).WithMany(p => p.OfficeMasters)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("ward_id_fk");
        });

        modelBuilder.Entity<Panchayat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("panchayats_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");

            entity.HasOne(d => d.Block).WithMany(p => p.Panchayats).HasConstraintName("block_id_fk");
        });

        modelBuilder.Entity<PasswordHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("password_histories_pkey");

            entity.HasOne(d => d.User).WithMany(p => p.PasswordHistories).HasConstraintName("password_histories_user_id_foreign");
        });

        modelBuilder.Entity<PasswordResetToken>(entity =>
        {
            entity.HasKey(e => e.Email).HasName("password_reset_tokens_pkey");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("permissions_pkey");

            entity.Property(e => e.IsActive).HasDefaultValue((short)0);

            entity.HasMany(d => d.Roles).WithMany(p => p.Permissions)
                .UsingEntity<Dictionary<string, object>>(
                    "RoleHasPermission",
                    r => r.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("role_has_permissions_role_id_foreign"),
                    l => l.HasOne<Permission>().WithMany()
                        .HasForeignKey("PermissionId")
                        .HasConstraintName("role_has_permissions_permission_id_foreign"),
                    j =>
                    {
                        j.HasKey("PermissionId", "RoleId").HasName("role_has_permissions_pkey");
                        j.ToTable("role_has_permissions");
                        j.IndexerProperty<long>("PermissionId").HasColumnName("permission_id");
                        j.IndexerProperty<int>("RoleId").HasColumnName("role_id");
                    });
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.Property(e => e.IsActive).HasDefaultValue((short)0);
        });

        modelBuilder.Entity<RoleOfficeTypeMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("role_office_type_mappings_pkey");

            entity.HasOne(d => d.OfficeType).WithMany(p => p.RoleOfficeTypeMappings)
                .HasPrincipalKey(p => p.Code)
                .HasForeignKey(d => d.OfficeTypeId)
                .HasConstraintName("office_type_id_fk");

            entity.HasOne(d => d.Role).WithMany(p => p.RoleOfficeTypeMappings).HasConstraintName("role_id_fk");
        });

        modelBuilder.Entity<Scheme>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("schemes_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");

            entity.HasOne(d => d.Department).WithMany(p => p.Schemes).HasConstraintName("department_id_fk");
        });

        modelBuilder.Entity<SchemeAttachedDocMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("scheme_attached_doc_mappings_pkey");

            entity.HasOne(d => d.DocType).WithMany(p => p.SchemeAttachedDocMappings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("doc_type_id_fk");

            entity.HasOne(d => d.Scheme).WithMany(p => p.SchemeAttachedDocMappings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("scheme_id_fk");
        });

        modelBuilder.Entity<SchemeCapacity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("scheme_capacities_pkey");

            entity.Property(e => e.EntryType).HasDefaultValueSql("'0'::smallint");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sessions_pkey");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("states_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");
        });

        modelBuilder.Entity<Subdivision>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("subdivisions_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");

            entity.HasOne(d => d.District).WithMany(p => p.Subdivisions).HasConstraintName("district_id_fk");
        });

        modelBuilder.Entity<UniqueAppBenId>(entity =>
        {
            entity.HasKey(e => e.ApplicationId).HasName("unique_app_ben_ids_pkey");

            entity.Property(e => e.ApplicationId).HasDefaultValueSql("nextval('pension_unique_app_ben_ids_application_id_seq'::regclass)");
            entity.Property(e => e.BeneficiaryId).HasDefaultValueSql("nextval('pension_unique_app_ben_ids_beneficiary_id_seq'::regclass)");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.HasIndex(e => new { e.Email, e.IsActive }, "users_email_unique_index")
                .IsUnique()
                .HasFilter("(is_active = 1)");

            entity.HasIndex(e => new { e.MobileNo, e.IsActive }, "users_mobile_no_unique_index")
                .IsUnique()
                .HasFilter("(is_active = 1)");

            entity.Property(e => e.AllowMultiSession).HasDefaultValue(false);
            entity.Property(e => e.BypassOtp).HasDefaultValue(false);
            entity.Property(e => e.FlagSentOtp).HasDefaultValueSql("'1'::smallint");
            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");
            entity.Property(e => e.IsLogin).HasDefaultValueSql("'0'::smallint");
            entity.Property(e => e.MobileNo).IsFixedLength();
        });

        modelBuilder.Entity<UserAuditTrail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_audit_trails_pkey");
        });

        modelBuilder.Entity<UserPageVisitLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_page_visit_logs_pkey");

            entity.Property(e => e.LogLevel).HasDefaultValueSql("'N'::character varying");
        });

        modelBuilder.Entity<UserPersonal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_personals_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");

            entity.HasOne(d => d.Department).WithMany(p => p.UserPersonals).HasConstraintName("department_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.UserPersonals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<UserRoleSchemeOfficeMapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_role_scheme_office_mappings_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");

            entity.HasOne(d => d.Office).WithMany(p => p.UserRoleSchemeOfficeMappings).HasConstraintName("office_id_fk");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoleSchemeOfficeMappings).HasConstraintName("role_id_fk");

            entity.HasOne(d => d.Scheme).WithMany(p => p.UserRoleSchemeOfficeMappings).HasConstraintName("scheme_id_fk");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoleSchemeOfficeMappings).HasConstraintName("user_id_fk");
        });

        modelBuilder.Entity<VerificationCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("verification_codes_pkey");

            entity.Property(e => e.Status).HasDefaultValueSql("'pending'::character varying");
        });

        modelBuilder.Entity<Ward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("wards_pkey");

            entity.Property(e => e.IsActive).HasDefaultValueSql("'1'::smallint");

            entity.HasOne(d => d.Municipality).WithMany(p => p.Wards).HasConstraintName("municipality_id_fk");
        });

        modelBuilder.Entity<WorkflowStep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("workflow_steps_pkey");

            entity.Property(e => e.IsFirst).HasDefaultValue(false);
            entity.Property(e => e.IsLast).HasDefaultValue(false);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("workflow_steps_parent_id_foreign");

            entity.HasOne(d => d.Scheme).WithMany(p => p.WorkflowSteps).HasConstraintName("workflow_steps_scheme_id_foreign");
        });

        modelBuilder.Entity<WorkflowstepRolemapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("workflowstep_rolemappings_pkey");

            entity.Property(e => e.IsFinalStep).HasDefaultValue(false);
            entity.Property(e => e.IsFirstStep).HasDefaultValue(false);

            entity.HasOne(d => d.Role).WithMany(p => p.WorkflowstepRolemappings).HasConstraintName("workflowstep_rolemappings_role_id_foreign");

            entity.HasOne(d => d.Scheme).WithMany(p => p.WorkflowstepRolemappings).HasConstraintName("workflowstep_rolemappings_scheme_id_foreign");
        });
        modelBuilder.HasSequence("beneficiary_bank_details_id_seq", "pension");
        modelBuilder.HasSequence("beneficiary_contact_details_id_seq", "pension");
        modelBuilder.HasSequence("beneficiary_declaration_details_id_seq", "pension");
        modelBuilder.HasSequence("beneficiary_personal_details_id_seq", "pension");
        modelBuilder.HasSequence("pension_unique_app_ben_ids_application_id_seq").StartsAt(150000000L);
        modelBuilder.HasSequence("pension_unique_app_ben_ids_beneficiary_id_seq").StartsAt(700000000L);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
