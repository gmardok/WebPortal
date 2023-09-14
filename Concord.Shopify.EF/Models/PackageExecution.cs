using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class PackageExecution
    {
        public int PackageExecutionId { get; set; }
        public string MachineName { get; set; }
        public string PackageName { get; set; }
        public string ComponentName { get; set; }
        public string ComponentMessage { get; set; }
        public string MessageType { get; set; }
        public bool IsDelivered { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
