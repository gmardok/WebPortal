using System;
using System.Collections.Generic;

#nullable disable

namespace Concord.Shopify.EF.Models
{
    public partial class EmailNotification
    {
        public int EmailNotificationId { get; set; }
        public string EmailSubject { get; set; }
        public string EmailRecipient { get; set; }
        public DateTimeOffset UpsertedDate { get; set; }
    }
}
