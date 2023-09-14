using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class Exception
    {
        public int ExceptionId { get; set; }
        public string TableName { get; set; }
        public string BusinessKey { get; set; }
        public string BusinessKeyValue { get; set; }
        public string ErrorMessage { get; set; }
        public string ExtendedMessage { get; set; }
        public bool AllowWhitelist { get; set; }
        public bool Whitelist { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
