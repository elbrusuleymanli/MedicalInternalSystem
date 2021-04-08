using MedApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MedApi.Data.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.Property(e => e.Note).HasMaxLength(1000).IsRequired();
            builder.HasOne(e => e.Reception).WithMany().HasForeignKey(e => e.ReceptionId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.User).WithMany().HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Doctors");
        
        }

    }
}
