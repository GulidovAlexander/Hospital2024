using Microsoft.EntityFrameworkCore;

namespace BlazorClient.Models.Entity
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Referral> Referrals { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .Property(u => u.UserId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Patient>()
                .Property(u => u.PatientId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<MedicalRecord>()
                .HasOne(mr => mr.Patient)
                .WithMany(p => p.MedicalRecords)
                .HasForeignKey(mr => mr.PatientId);

            modelBuilder.Entity<Prescription>()
                .HasOne(mr => mr.MedicalRecord)
                .WithOne(p => p.Prescription)
                .HasForeignKey<Prescription>(p => p.PrescriptionId);

            modelBuilder.Entity<Medication>()
                .HasOne(mr => mr.Prescription)
                .WithMany(p => p.Medications)
                .HasForeignKey(mr => mr.PrescriptionId);

            modelBuilder.Entity<Referral>()
                .HasOne(mr => mr.MedicalRecord)
                .WithMany(p => p.Referrals)
                .HasForeignKey(mr => mr.MedicalRecordId);
        }
    }
}
