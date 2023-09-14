using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class ProductVariant
    {
        public ProductVariant()
        {
            StoreOrderItems = new HashSet<StoreOrderItem>();
        }

        public long VariantId { get; set; }
        public bool? IsActive { get; set; }
        public long ProductId { get; set; }
        public string Title { get; set; }
        public string Sku { get; set; }
        public string Barcode { get; set; }
        public string FulfillmentService { get; set; }
        public decimal Price { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<StoreOrderItem> StoreOrderItems { get; set; }
    }
}
