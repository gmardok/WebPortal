using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class DimCurrency
    {
        public DimCurrency()
        {
            FactOrders = new HashSet<FactOrder>();
        }

        public int CurrencyKey { get; set; }
        public string Currency { get; set; }

        public virtual ICollection<FactOrder> FactOrders { get; set; }
    }
}
