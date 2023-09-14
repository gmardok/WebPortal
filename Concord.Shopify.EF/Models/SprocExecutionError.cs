using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class SprocExecutionError
    {
        public int ExecutionErrorId { get; set; }
        public Guid ExecutionBatchId { get; set; }
        public string SprocName { get; set; }
        public string SprocParameter { get; set; }
        public int ErrorNumber { get; set; }
        public int ErrorSeverity { get; set; }
        public int ErrorState { get; set; }
        public int ErrorLine { get; set; }
        public string ErrorMessage { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
