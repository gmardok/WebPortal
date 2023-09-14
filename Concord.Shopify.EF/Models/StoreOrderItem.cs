using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class StoreOrderItem
    {
        public StoreOrderItem()
        {
            StoreOrderItemFulfillments = new HashSet<StoreOrderItemFulfillment>();
            StoreOrderItemRefunds = new HashSet<StoreOrderItemRefund>();
        }

        public long OrderItemId { get; set; }
        public long OrderId { get; set; }
        public long? ProductId { get; set; }
        public long? VariantId { get; set; }
        public string Vendor { get; set; }
        public string FulfillmentStatus { get; set; }
        public int Quantity { get; set; }
        public decimal LineItemAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }

        public virtual StoreOrder Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual ProductVariant Variant { get; set; }
        public virtual ICollection<StoreOrderItemFulfillment> StoreOrderItemFulfillments { get; set; }
        public virtual ICollection<StoreOrderItemRefund> StoreOrderItemRefunds { get; set; }
    }
}
