using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupMeeting.Models.Domain.Reponse
{
    public class GroupMeetingView
    {
        public int ID { get; set; }
        public string ProjectName { get; set; }
        public string GroupMeetingLeadName { get; set; }
        public string TeamLeadName { get; set; }
        public string Description { get; set; }
        public DateTime GroupMeetingDate { get; set; }
    }
}
