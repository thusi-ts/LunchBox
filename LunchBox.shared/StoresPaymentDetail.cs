using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBox.Shared
{
    public class StoresPaymentDetail
    {
        public Store Store { get; set; }

        public int StoreId { get; set; }

        public String MerchantId { get; set; }

        public String AgreementId { get; set; }

        public String Currency { get; set; }

        public String PaymentWindowApiKey { get; set; }

        public String AccountPrivateKey { get; set; }
    }

    /// <summary>
    /// OnModelCreating call this method automatically by ApplyConfigurationsFromAssembly function in LbDbContext.cs
    /// Specify Fluent Api to this class property. Read more https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx
    /// Fluent Api is equal to Annotation in class property like [Key], [MaxLength]
    /// Fluent Api more powerful and have control. Easily can create relation between tables. Annotation is uses for simple cases
    /// </summary>
    public class StoresPaymentDetailImageEntityTypeConfiguration : IEntityTypeConfiguration<StoresPaymentDetail>
    {
        public void Configure(EntityTypeBuilder<StoresPaymentDetail> builder)
        {
            builder.HasKey(p => p.StoreId);
            builder.Property(p => p.MerchantId).HasMaxLength(100).IsRequired();
            builder.Property(p => p.AgreementId).HasMaxLength(200);
            builder.Property(p => p.Currency).HasMaxLength(200);
            builder.Property(p => p.PaymentWindowApiKey).HasMaxLength(200);
            builder.Property(p => p.AccountPrivateKey).HasMaxLength(200);

            builder.HasOne(p => p.Store).WithMany(p => p.StoresPaymentDetails)
            .HasForeignKey(p => p.StoreId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
        }
    }
}
