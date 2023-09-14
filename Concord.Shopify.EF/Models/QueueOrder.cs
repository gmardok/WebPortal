using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class QueueOrder
    {
        public int QueueId { get; set; }
        public long OrderId { get; set; }
        public string OrderJson { get; set; }
    }
}
