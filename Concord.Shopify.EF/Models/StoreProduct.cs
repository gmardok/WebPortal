using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class StoreProduct
    {
        public int StoreProductId { get; set; }
        public string StoreName { get; set; }
        public string ProductJson { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
