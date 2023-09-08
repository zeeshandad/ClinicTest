using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DAL.Entities;

public partial class ClinicContext : DbContext
{
    public ClinicContext()
    {
    }

    public ClinicContext(DbContextOptions<ClinicContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Appointment_pkey");

            entity.ToTable("Appointment");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CancelStatus).HasDefaultValueSql("false");
            entity.Property(e => e.PatientId).HasColumnName("PatientID");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Patient_pkey");

            entity.ToTable("Patient");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("character varying");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
