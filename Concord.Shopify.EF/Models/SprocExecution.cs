using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class SprocExecution
    {
        public long ExecutionId { get; set; }
        public Guid ExecutionBatchId { get; set; }
        public string SprocName { get; set; }
        public string SprocParameter { get; set; }
        public int TimeElapsedMillisecond { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
