using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistences.EntityConfigurations;

public class EmailAuthenticatorConfiguration : IEntityTypeConfiguration<EmailAuthenticator>
{
    public void Configure(EntityTypeBuilder<EmailAuthenticator> builder)
    {
        builder.ToTable("EmailAuthenticators").HasKey(ea => ea.Id);

        builder.Property(oa => oa.Id).HasColumnName("Id").IsRequired();
        builder.Property(oa => oa.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(oa => oa.IsVerified).HasColumnName("IsVerified").IsRequired();
        builder.Property(oa => oa.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(oa => oa.ActivationKey).HasColumnName("ActivationKey");
        builder.Property(oa => oa.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(oa => oa.DeletedDate).HasColumnName("DeletedDate");

        builder.HasQueryFilter(oa => !oa.DeletedDate.HasValue);

        builder.HasOne(oa => oa.User);
    }
}