using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class StoreOrderItemFulfillment
    {
        public long FulfillmentId { get; set; }
        public long OrderItemId { get; set; }
        public string FulfillmentStatus { get; set; }
        public string FulfillmentItemStatus { get; set; }
        public string FulfillmentService { get; set; }
        public string ShippingCompany { get; set; }
        public string ShippingSatus { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }

        public virtual StoreOrderItem OrderItem { get; set; }
    }
}
