using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class FactOrderItem
    {
        public FactOrderItem()
        {
            FactOrderItemRefunds = new HashSet<FactOrderItemRefund>();
        }

        public long OrderItemKey { get; set; }
        public long OrderKey { get; set; }
        public long ProductVariantKey { get; set; }
        public int VendorKey { get; set; }
        public int FulFillmentStatusKey { get; set; }
        public int OrderItemQuantity { get; set; }
        public decimal OrderItemAmount { get; set; }
        public decimal OrderItemDiscountAmount { get; set; }
        public decimal OrderItemTaxAmount { get; set; }

        public virtual DimFulFillmentStatus FulFillmentStatusKeyNavigation { get; set; }
        public virtual FactOrder OrderKeyNavigation { get; set; }
        public virtual DimProductVariant ProductVariantKeyNavigation { get; set; }
        public virtual DimVendor VendorKeyNavigation { get; set; }
        public virtual ICollection<FactOrderItemRefund> FactOrderItemRefunds { get; set; }
    }
}
