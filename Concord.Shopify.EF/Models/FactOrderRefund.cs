using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class FactOrderRefund
    {
        public long OrderRefundKey { get; set; }
        public long OrderKey { get; set; }
        public int RefundDateKey { get; set; }
        public string RefundReason { get; set; }
        public string RefundLineReason { get; set; }
        public decimal RefundAmount { get; set; }
        public decimal RefundTaxAmount { get; set; }

        public virtual FactOrder OrderKeyNavigation { get; set; }
        public virtual DimDate RefundDateKeyNavigation { get; set; }
    }
}
