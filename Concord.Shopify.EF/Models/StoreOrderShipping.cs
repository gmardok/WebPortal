using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class StoreOrderShipping
    {
        public long ShippingId { get; set; }
        public long OrderId { get; set; }
        public string Carrier { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxAmount { get; set; }

        public virtual StoreOrder Order { get; set; }
    }
}
