using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class StoreOrderMetafield
    {
        public int StoreOrderMetafieldId { get; set; }
        public string StoreName { get; set; }
        public string OrderMetafieldJson { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
