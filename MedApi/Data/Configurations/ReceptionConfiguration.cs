using MedApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MedApi.Data.Configurations
{
    public class ReceptionConfiguration : IEntityTypeConfiguration<Reception>
    {
        public void Configure(EntityTypeBuilder<Reception> builder)
        {
            builder.HasOne(e => e.User).WithMany().HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(e => e.Patient).WithMany().HasForeignKey(e => e.PatientId).OnDelete(DeleteBehavior.Restrict);

            builder.ToTable("Receptions");
        }
    }
}
