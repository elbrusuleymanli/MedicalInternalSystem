using MedApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MedApi.Data.Configurations
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.Property(e => e.Adress).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(50);
            builder.Property(e => e.Fullname).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Gender).HasMaxLength(50).IsRequired();
            builder.Property(e => e.IsMarried).HasDefaultValue(false).IsRequired();
            builder.Property(e => e.PasspExpDate).IsRequired();
            builder.Property(e => e.PassportNo).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Phone).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Birdhday).IsRequired();
            builder.Property(e => e.SickPurpose).HasMaxLength(50);
            builder.Property(e => e.RegisterDate).HasDefaultValueSql("GETDATE()").IsRequired();

            builder.ToTable("Patients");
        }
    }
}
