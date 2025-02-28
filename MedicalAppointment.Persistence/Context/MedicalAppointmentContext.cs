using MedicalAppointment.Domain.Entities.Appointments;
using MedicalAppointment.Domain.Entities.Insurance;
using MedicalAppointment.Domain.Entities.Medical;
using MedicalAppointment.Domain.Entities.System;
using MedicalAppointment.Domain.Entities.User.Users;
using MedicalAppointment.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

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
            .ToTable("Appointments", "appointments")
            .HasOne(a => a.Patient)
            .WithMany()
            .HasForeignKey(a => a.PatientID);

            modelBuilder.Entity<Appointments>()
            .ToTable("Appointments", "appointments")
            .HasOne(a => a.Doctor)
            .WithMany()
            .HasForeignKey(a => a.DoctorID);

            modelBuilder.Entity<DoctorAvailability>()
            .ToTable("DoctorAvailability", "appointments")
            .HasOne(d => d.Doctor)
            .WithMany()
            .HasForeignKey(d => d.DoctorID);

            modelBuilder.Entity<InsuranceProviders>()
            .ToTable("InsuranceProviders", "Insurance")
            .HasOne(i => i.NetworkType)
            .WithMany()
            .HasForeignKey(i => i.NetworkTypeId);

            modelBuilder.Entity<NetworkType>()
            .ToTable("NetworkType", "Insurance");

            modelBuilder.Entity<AvailabilityModes>()
                .ToTable("AvailabilityModes", "medical");

            modelBuilder.Entity<MedicalRecords>()
                .ToTable("MedicalRecords", "medical")
                .HasOne(m => m.Patient)
                .WithMany()
                .HasForeignKey(m => m.PatientID);

            modelBuilder.Entity<MedicalRecords>()
                .ToTable("MedicalRecords", "medical")
                .HasOne(m => m.Doctor)
                .WithMany()
                .HasForeignKey(m => m.DoctorID);

            modelBuilder.Entity<Specialties>()
                .ToTable("Specialties", "medical");

            modelBuilder.Entity<Notifications>()
                .ToTable("Notifications", "system");

            modelBuilder.Entity<Roles>()
                .ToTable("Roles", "system");

            modelBuilder.Entity<Status>()
                .ToTable("Status", "system");

            modelBuilder.Entity<Doctors>()
                .ToTable("Doctors", "users")
                .HasOne(d => d.Specialty)
                .WithMany()
                .HasForeignKey(d => d.SpecialtyID);

            modelBuilder.Entity<Doctors>()
                .ToTable("Doctors", "users")
                .HasOne(d => d.AvailabilityMode)
                .WithMany()
                .HasForeignKey(d => d.AvailabilityModeId);

            modelBuilder.Entity<Patients>()
                .ToTable("Patients", "users")
                .HasOne(p => p.InsuranceProvider)
                .WithMany()
                .HasForeignKey(p => p.InsuranceProviderID);

            modelBuilder.Entity<Users>()
                .ToTable("Users", "users")
                .HasOne(u => u.Role)
                .WithMany()
                .HasForeignKey(u => u.RoleID);
        }


    }
}
