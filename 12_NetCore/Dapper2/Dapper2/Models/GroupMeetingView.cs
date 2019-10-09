using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dapper2.Models
{
    public class GroupMeetingView
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string LeadName { get; set; }
        public string TeamLeadName { get; set; }
        public string Description { get; set; }
        public DateTime MeetingDate { get; set; }
    }
}
