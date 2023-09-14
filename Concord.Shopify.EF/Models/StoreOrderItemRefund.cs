using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class StoreOrderItemRefund
    {
        public long OrderItemAdjustmentId { get; set; }
        public long OrderItemId { get; set; }
        public string RefundNote { get; set; }
        public string RestockType { get; set; }
        public int Quantity { get; set; }
        public decimal RefundAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public virtual StoreOrderItem OrderItem { get; set; }
    }
}
