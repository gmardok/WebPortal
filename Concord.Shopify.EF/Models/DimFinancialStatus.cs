using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class DimFinancialStatus
    {
        public DimFinancialStatus()
        {
            FactOrders = new HashSet<FactOrder>();
        }

        public int FinancialStatusKey { get; set; }
        public string FinancialStatus { get; set; }

        public virtual ICollection<FactOrder> FactOrders { get; set; }
    }
}
