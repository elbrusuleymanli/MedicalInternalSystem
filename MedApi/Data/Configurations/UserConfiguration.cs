using MedApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace MedApi.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Fullname).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Password).HasMaxLength(150).IsRequired();
            builder.Property(e => e.ProfilePhoto).IsRequired();
            builder.Property(e => e.Token).HasMaxLength(200);

            builder.ToTable("Users");
        }
    }
}
