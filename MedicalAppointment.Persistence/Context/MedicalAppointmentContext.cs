
using MedicalAppointment.Domain.Entities.Appointments;
using MedicalAppointment.Domain.Entities.Insurance;
using MedicalAppointment.Domain.Entities.Medical;
using MedicalAppointment.Domain.Entities.System;
using MedicalAppointment.Domain.Entities.User.Users;
using MedicalAppointment.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace MedicalAppointment.Persistence.Context
{
    public class MedicalAppointmentContext : DbContext
    {
        public MedicalAppointmentContext(DbContextOptions<MedicalAppointmentContext> options) : base(options)
        {

        }

        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<DoctorAvailability> DoctorAvailabilities { get; set; }

        public DbSet<InsuranceProviders> InsuranceProviders { get; set; }
        public DbSet<NetworkType> NetworkTypes { get; set; }

        public DbSet<AvailabilityModes> AvailabilityModes { get; set; }
        public DbSet<MedicalRecords> MedicalRecords { get; set; }
        public DbSet<Specialties> Specialties { get; set; }

        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Status> Status { get; set; }

        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointments>()
                .HasOne(a => a.Patient)
                .WithMany()
                .HasForeignKey(a => a.PatientID);

            modelBuilder.Entity<Appointments>()
                .HasOne(a => a.Doctor)
                .WithMany()
                .HasForeignKey(a => a.DoctorID);

            modelBuilder.Entity<DoctorAvailability>()
                .HasOne(d => d.Doctor)
                .WithMany()
                .HasForeignKey(d => d.DoctorID);

            modelBuilder.Entity<InsuranceProviders>()
                .HasOne(i => i.NetworkType)
                .WithMany()
                .HasForeignKey(i => i.NetworkTypeId);

            modelBuilder.Entity<MedicalRecords>()
                .HasOne(m => m.Patient)
                .WithMany()
                .HasForeignKey(m => m.PatientID);

            modelBuilder.Entity<MedicalRecords>()
                .HasOne(m => m.Doctor)
                .WithMany()
                .HasForeignKey(m => m.DoctorID);

            modelBuilder.Entity<Doctors>()
                .HasOne(d => d.Specialty)
                .WithMany()
                .HasForeignKey(d => d.SpecialtyID);

            modelBuilder.Entity<Doctors>()
                .HasOne(d => d.AvailabilityMode)
                .WithMany()
                .HasForeignKey(d => d.AvailabilityModeId);

            modelBuilder.Entity<Patients>()
                .HasOne(p => p.InsuranceProvider)
                .WithMany()
                .HasForeignKey(p => p.InsuranceProviderID);

            modelBuilder.Entity<Users>()
                .HasOne(u => u.Role)
                .WithMany()
                .HasForeignKey(u => u.RoleID);
        }


    }
}
