
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


    }
}
