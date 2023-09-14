using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class DimStore
    {
        public DimStore()
        {
            FactOrders = new HashSet<FactOrder>();
        }

        public int StoreKey { get; set; }
        public string StoreName { get; set; }

        public virtual ICollection<FactOrder> FactOrders { get; set; }
    }
}
