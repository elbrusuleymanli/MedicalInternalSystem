using MedApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MedApi.Data.Configurations
{
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasOne(e => e.Reception).WithMany().HasForeignKey(e => e.ReceptionId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.User).WithMany().HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Doctor).WithMany().HasForeignKey(e => e.DoctorId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Patient).WithMany().HasForeignKey(e => e.PatientId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Managers");
        
        }
    }
}
