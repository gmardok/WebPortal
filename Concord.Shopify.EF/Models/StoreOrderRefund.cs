using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class StoreOrderRefund
    {
        public long OrderAdjustmentId { get; set; }
        public long OrderId { get; set; }
        public string RefundNote { get; set; }
        public string RefundReason { get; set; }
        public decimal RefundAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public virtual StoreOrder Order { get; set; }
    }
}
