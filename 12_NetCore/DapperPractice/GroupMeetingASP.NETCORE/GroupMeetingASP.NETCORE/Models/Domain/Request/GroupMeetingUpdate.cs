using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupMeetingASP.NETCORE.Models.Domain.Request
{
    public class GroupMeetingUpdate
    {
        public string ProjectName { get; set; }
        public string GroupMeetingLeadName { get; set; }
        public string Description { get; set; }
        public DateTime GroupMeetingDate { get; set; }
    }
}
