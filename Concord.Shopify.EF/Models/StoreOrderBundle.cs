using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class StoreOrderBundle
    {
        public long OrderId { get; set; }
        public long? BundleVariantId { get; set; }
        public long VariantId { get; set; }
        public string Title { get; set; }
        public string Sku { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public string BundleJson { get; set; }

        public virtual ProductVariant BundleVariant { get; set; }
        public virtual StoreOrder Order { get; set; }
        public virtual ProductVariant Variant { get; set; }
    }
}
