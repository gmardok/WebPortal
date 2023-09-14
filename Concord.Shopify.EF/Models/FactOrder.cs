using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class FactOrder
    {
        public FactOrder()
        {
            FactOrderItems = new HashSet<FactOrderItem>();
            FactOrderRefunds = new HashSet<FactOrderRefund>();
            FactOrderShippings = new HashSet<FactOrderShipping>();
        }

        public long OrderKey { get; set; }
        public string OrderNumber { get; set; }
        public int OrderDateKey { get; set; }
        public int StoreKey { get; set; }
        public int FinancialStatusKey { get; set; }
        public int FulFillmentStatusKey { get; set; }
        public int CurrencyKey { get; set; }
        public decimal OrderAmount { get; set; }
        public decimal OrderDiscountAmount { get; set; }
        public decimal OrderShippingAmount { get; set; }
        public decimal OrderTaxAmount { get; set; }
        public decimal OrderTotalAmount { get; set; }

        public virtual DimCurrency CurrencyKeyNavigation { get; set; }
        public virtual DimFinancialStatus FinancialStatusKeyNavigation { get; set; }
        public virtual DimFulFillmentStatus FulFillmentStatusKeyNavigation { get; set; }
        public virtual DimDate OrderDateKeyNavigation { get; set; }
        public virtual DimStore StoreKeyNavigation { get; set; }
        public virtual ICollection<FactOrderItem> FactOrderItems { get; set; }
        public virtual ICollection<FactOrderRefund> FactOrderRefunds { get; set; }
        public virtual ICollection<FactOrderShipping> FactOrderShippings { get; set; }
    }
}
