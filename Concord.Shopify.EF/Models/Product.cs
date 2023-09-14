using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductVariants = new HashSet<ProductVariant>();
            StoreOrderItems = new HashSet<StoreOrderItem>();
        }

        public long ProductId { get; set; }
        public string Title { get; set; }
        public string Vendor { get; set; }
        public string ProductType { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
        public string StoreName { get; set; }
        public string ProductJson { get; set; }

        public virtual ICollection<ProductVariant> ProductVariants { get; set; }
        public virtual ICollection<StoreOrderItem> StoreOrderItems { get; set; }
    }
}
