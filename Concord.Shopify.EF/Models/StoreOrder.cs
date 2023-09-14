using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class StoreOrder
    {
        public StoreOrder()
        {
            StoreOrderItems = new HashSet<StoreOrderItem>();
            StoreOrderRefunds = new HashSet<StoreOrderRefund>();
            StoreOrderShippings = new HashSet<StoreOrderShipping>();
        }

        public long OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string FinancialStatus { get; set; }
        public string FulfillmentStatus { get; set; }
        public string SaleChannel { get; set; }
        public string Currency { get; set; }
        public decimal LineItemAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal SubtotalAmount { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public DateTimeOffset? CancelledDate { get; set; }
        public string CancelledReason { get; set; }
        public string StoreName { get; set; }
        public string OrderJson { get; set; }

        public virtual ICollection<StoreOrderItem> StoreOrderItems { get; set; }
        public virtual ICollection<StoreOrderRefund> StoreOrderRefunds { get; set; }
        public virtual ICollection<StoreOrderShipping> StoreOrderShippings { get; set; }
    }
}
