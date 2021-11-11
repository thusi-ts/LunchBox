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

        [Key]
        public int StoreId { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public String MerchantId { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public String AgreementId { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public String Currency { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String PaymentWindowApiKey { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        public String AccountPrivateKey { get; set; }
    }
}
