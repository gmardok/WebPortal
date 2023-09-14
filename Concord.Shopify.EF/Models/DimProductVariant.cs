using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class DimProductVariant
    {
        public DimProductVariant()
        {
            FactOrderItems = new HashSet<FactOrderItem>();
        }

        public long ProductVariantKey { get; set; }
        public long ProductKey { get; set; }
        public string VariantTitle { get; set; }
        public string ProductTitle { get; set; }
        public string Vendor { get; set; }
        public string ProductType { get; set; }
        public string Sku { get; set; }
        public string Barcode { get; set; }
        public string FulfillmentService { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<FactOrderItem> FactOrderItems { get; set; }
    }
}
