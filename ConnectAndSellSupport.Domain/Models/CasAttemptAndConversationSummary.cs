using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasAttemptAndConversationSummary
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? Attempts { get; set; }
        public int? Conversations { get; set; }
        public int? AttemptsWithoutConversion { get; set; }
        public int? ConversationsWithoutConversion { get; set; }
        public int? ConversationsWithoutPositiveDisposition { get; set; }
        public DateTime? Date { get; set; }
    }
}
