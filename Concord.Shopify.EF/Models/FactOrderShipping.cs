using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class FactOrderShipping
    {
        public long ShippingKey { get; set; }
        public long OrderKey { get; set; }
        public string Carrier { get; set; }
        public decimal ShippingAmount { get; set; }
        public decimal ShippingDiscountAmount { get; set; }
        public decimal ShippingTaxAmount { get; set; }

        public virtual FactOrder OrderKeyNavigation { get; set; }
    }
}
