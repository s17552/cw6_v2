using Microsoft.EntityFrameworkCore;

namespace cw6_v2.Models
{
    public class HospitalContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }

        public HospitalContext(DbContextOptions options) : base(options)
        {
        }
    }
}