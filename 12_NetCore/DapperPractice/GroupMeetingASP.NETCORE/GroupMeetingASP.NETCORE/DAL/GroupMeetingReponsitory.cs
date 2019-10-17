using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using GroupMeetingASP.NETCORE.Models;

namespace GroupMeetingASP.NETCORE.DAL
{
    public class GroupMeetingReponsitory : BaseReponsitory
    {
        public GroupMeetingReponsitory() : base()
        {
            
        }

        public IEnumerable<GroupMeeting> GetGroupMeetings()
        {
            List<GroupMeeting> groupMeetingList = new List<GroupMeeting>();
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                groupMeetingList = con.Query<GroupMeeting>("GetGroupMeetingDetails").ToList();
            }
            return groupMeetingList;
        }

    }
}
