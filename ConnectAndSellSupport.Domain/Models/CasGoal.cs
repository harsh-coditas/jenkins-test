using System;
using System.Collections.Generic;

#nullable disable

namespace ConnectAndSellSupport.Domain.Models
{
    public partial class CasGoal
    {
        public int GoalId { get; set; }
        public int CompanyId { get; set; }
        public string GoalName { get; set; }
        public string GoalType { get; set; }
        public string GoalTimeFrame { get; set; }
        public string GoalAgainstType { get; set; }
        public string GoalAgainst { get; set; }
        public int GoalTarget { get; set; }
        public string EmailList { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModDate { get; set; }
        public string GoalIndividualTeam { get; set; }
        public DateTime? StartLimitofGoal { get; set; }
        public DateTime? EndLimitofGoal { get; set; }
        public string GoalConditionType { get; set; }

        public virtual TCompany Company { get; set; }
    }
}
