using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class StoreOrder1
    {
        public int StoreOrderId { get; set; }
        public string StoreName { get; set; }
        public string OrderJson { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
