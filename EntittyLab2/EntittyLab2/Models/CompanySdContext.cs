﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntittyLab2.Models;

public partial class CompanySdContext : DbContext
{
    public CompanySdContext()
    {
    }

    public CompanySdContext(DbContextOptions<CompanySdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Dependent> Dependents { get; set; }

    public virtual DbSet<Display> Displays { get; set; }

    public virtual DbSet<Dml> Dmls { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Empo> Empos { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Projname> Projnames { get; set; }

    public virtual DbSet<Proname> Pronames { get; set; }

    public virtual DbSet<WorksFor> WorksFors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-C3O452Q;Database=Company_SD;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Dnum);

            entity.Property(e => e.Dnum).ValueGeneratedNever();
            entity.Property(e => e.Dname).HasMaxLength(50);
            entity.Property(e => e.Mgrssn).HasColumnName("MGRSSN");
            entity.Property(e => e.MgrstartDate)
                .HasColumnType("datetime")
                .HasColumnName("MGRStart Date");

            entity.HasOne(d => d.MgrssnNavigation).WithMany(p => p.Departments)
                .HasForeignKey(d => d.Mgrssn)
                .HasConstraintName("FK_Departments_Employee");
        });

        modelBuilder.Entity<Dependent>(entity =>
        {
            entity.HasKey(e => new { e.Essn, e.DependentName });

            entity.ToTable("Dependent");

            entity.Property(e => e.Essn).HasColumnName("ESSN");
            entity.Property(e => e.DependentName)
                .HasMaxLength(255)
                .HasColumnName("Dependent_name");
            entity.Property(e => e.Bdate).HasColumnType("datetime");
            entity.Property(e => e.Sex).HasMaxLength(255);

            entity.HasOne(d => d.EssnNavigation).WithMany(p => p.Dependents)
                .HasForeignKey(d => d.Essn)
                .HasConstraintName("FK_Dependent_Employee");
        });

        modelBuilder.Entity<Display>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Display");

            entity.Property(e => e.Dname).HasMaxLength(50);
            entity.Property(e => e.Fname).HasMaxLength(50);
        });

        modelBuilder.Entity<Dml>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("dml");

            entity.Property(e => e.Plocation).HasMaxLength(50);
            entity.Property(e => e.Pname).HasMaxLength(50);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Ssn);

            entity.ToTable("Employee");

            entity.Property(e => e.Ssn)
                .ValueGeneratedNever()
                .HasColumnName("SSN");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Bdate).HasColumnType("datetime");
            entity.Property(e => e.Fname).HasMaxLength(50);
            entity.Property(e => e.Lname).HasMaxLength(50);
            entity.Property(e => e.Sex).HasMaxLength(50);

            entity.HasOne(d => d.DnoNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.Dno)
                .HasConstraintName("FK_Employee_Departments");

            entity.HasOne(d => d.SuperssnNavigation).WithMany(p => p.InverseSuperssnNavigation)
                .HasForeignKey(d => d.Superssn)
                .HasConstraintName("FK_Employee_Employee");
        });

        modelBuilder.Entity<Empo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("empo");

            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Bdate).HasColumnType("datetime");
            entity.Property(e => e.Fname).HasMaxLength(50);
            entity.Property(e => e.Lname).HasMaxLength(50);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.Ssn).HasColumnName("SSN");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Pnumber);

            entity.ToTable("Project");

            entity.Property(e => e.Pnumber).ValueGeneratedNever();
            entity.Property(e => e.City).HasMaxLength(50);
            entity.Property(e => e.Plocation).HasMaxLength(50);
            entity.Property(e => e.Pname).HasMaxLength(50);

            entity.HasOne(d => d.DnumNavigation).WithMany(p => p.Projects)
                .HasForeignKey(d => d.Dnum)
                .HasConstraintName("FK_Project_Departments");
        });

        modelBuilder.Entity<Projname>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("projname");

            entity.Property(e => e.Dname).HasMaxLength(50);
            entity.Property(e => e.Pname).HasMaxLength(50);
        });

        modelBuilder.Entity<Proname>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("proname");

            entity.Property(e => e.FullName)
                .HasMaxLength(101)
                .HasColumnName("fullName");
            entity.Property(e => e.Pname)
                .HasMaxLength(50)
                .HasColumnName("pname");
        });

        modelBuilder.Entity<WorksFor>(entity =>
        {
            entity.HasKey(e => new { e.Essn, e.Pno });

            entity.ToTable("Works_for");

            entity.Property(e => e.Essn).HasColumnName("ESSn");

            entity.HasOne(d => d.EssnNavigation).WithMany(p => p.WorksFors)
                .HasForeignKey(d => d.Essn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Works_for_Employee");

            entity.HasOne(d => d.PnoNavigation).WithMany(p => p.WorksFors)
                .HasForeignKey(d => d.Pno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Works_for_Project");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
