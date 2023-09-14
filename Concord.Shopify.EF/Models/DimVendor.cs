using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class DimVendor
    {
        public DimVendor()
        {
            FactOrderItems = new HashSet<FactOrderItem>();
        }

        public int VendorKey { get; set; }
        public string VendorName { get; set; }

        public virtual ICollection<FactOrderItem> FactOrderItems { get; set; }
    }
}
