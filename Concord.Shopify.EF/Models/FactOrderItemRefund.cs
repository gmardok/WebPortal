using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class FactOrderItemRefund
    {
        public long OrderItemRefundKey { get; set; }
        public long OrderItemKey { get; set; }
        public int RefundDateKey { get; set; }
        public string RefundReason { get; set; }
        public string RestockType { get; set; }
        public int OrderItemRefundQuantity { get; set; }
        public decimal OrderItemRefundAmount { get; set; }
        public decimal OrderItemRefundTaxAmount { get; set; }

        public virtual FactOrderItem OrderItemKeyNavigation { get; set; }
        public virtual DimDate RefundDateKeyNavigation { get; set; }
    }
}
