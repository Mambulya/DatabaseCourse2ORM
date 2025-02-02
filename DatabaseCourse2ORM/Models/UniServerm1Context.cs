using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCourse2ORM.Models;

public partial class UniServerm1Context : DbContext
{
    public UniServerm1Context()
    {
    }

    public UniServerm1Context(DbContextOptions<UniServerm1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ProductionNorma> ProductionNormas { get; set; }

    public virtual DbSet<WorkerExperience> WorkerExperiences { get; set; }

    public virtual DbSet<WorkerInfo> WorkerInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-LCHJBBK9;Database=uni_serverm1;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductionNorma>(entity =>
        {
            entity.HasKey(e => new { e.IdComponent, e.IdOperation }).HasName("pk_id_component");

            entity.ToTable("production_normas");

            entity.Property(e => e.IdComponent).HasColumnName("id_component");
            entity.Property(e => e.IdOperation).HasColumnName("id_operation");
            entity.Property(e => e.CodeWorkerProfession).HasColumnName("code_worker_profession");
            entity.Property(e => e.CompleteTime)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("complete_time");
            entity.Property(e => e.ItemTime)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("item_time");
            entity.Property(e => e.TariffCodeWorker).HasColumnName("tariff_code_worker");
            entity.Property(e => e.WorkerQuilification).HasColumnName("worker_quilification");
        });

        modelBuilder.Entity<WorkerExperience>(entity =>
        {
            entity.HasKey(e => e.IdWorker).HasName("PK__worker_e__F3638D7C8CBC3661");

            entity.ToTable("worker_experience");

            entity.HasIndex(e => new { e.IdWorker, e.IdComponent, e.IdOperation }, "uq_worker_experience").IsUnique();

            entity.Property(e => e.IdWorker)
                .ValueGeneratedNever()
                .HasColumnName("id_worker");
            entity.Property(e => e.DefectProportion)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("defect_proportion");
            entity.Property(e => e.FinishedWorkDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("finished_work_date");
            entity.Property(e => e.IdComponent).HasColumnName("id_component");
            entity.Property(e => e.IdOperation).HasColumnName("id_operation");
            entity.Property(e => e.NumBadComponents).HasColumnName("num_bad_components");
            entity.Property(e => e.NumGoodComponents).HasColumnName("num_good_components");

            entity.HasOne(d => d.IdWorkerNavigation).WithOne(p => p.WorkerExperience)
                .HasForeignKey<WorkerExperience>(d => d.IdWorker)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__worker_ex__id_wo__403A8C7D");

            entity.HasOne(d => d.ProductionNorma).WithMany(p => p.WorkerExperiences)
                .HasForeignKey(d => new { d.IdComponent, d.IdOperation })
                .HasConstraintName("FK__worker_experienc__4222D4EF");
        });

        modelBuilder.Entity<WorkerInfo>(entity =>
        {
            entity.HasKey(e => e.IdWorker).HasName("PK__worker_i__F3638D7CE6C75E6D");

            entity.ToTable("worker_info", tb => tb.HasTrigger("bd_Worker_info"));

            entity.Property(e => e.IdWorker).HasColumnName("id_worker");
            entity.Property(e => e.CodeWorkerProfession).HasColumnName("code_worker_profession");
            entity.Property(e => e.Fio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("fio");
            entity.Property(e => e.IdDepartment).HasColumnName("id_department");
            entity.Property(e => e.IdFactory).HasColumnName("id_factory");
            entity.Property(e => e.Married)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("not given")
                .HasColumnName("married");
            entity.Property(e => e.WorkerQuilification)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("not given")
                .HasColumnName("worker_quilification");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
