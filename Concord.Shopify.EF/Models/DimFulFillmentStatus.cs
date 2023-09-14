using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class DimFulFillmentStatus
    {
        public DimFulFillmentStatus()
        {
            FactOrderItems = new HashSet<FactOrderItem>();
            FactOrders = new HashSet<FactOrder>();
        }

        public int FulFillmentStatusKey { get; set; }
        public string FulFillmentStatus { get; set; }

        public virtual ICollection<FactOrderItem> FactOrderItems { get; set; }
        public virtual ICollection<FactOrder> FactOrders { get; set; }
    }
}
