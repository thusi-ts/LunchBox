using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lunchbox.shared
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
        }
    }
}
