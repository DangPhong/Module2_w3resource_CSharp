using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using GroupMeeting.Models.Domain.Reponse;
using GroupMeeting.Models.Domain.Request;

namespace GroupMeeting.DAL
{
    public class GroupMeetingReponsitory : BaseReponsitory
    {
        public GroupMeetingReponsitory() : base()
        {

        }

        public IEnumerable<GroupMeetingView> GetGroupMeetings()
        {
            List<GroupMeetingView> groupMeetingList = new List<GroupMeetingView>();
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                groupMeetingList = con.Query<GroupMeetingView>("GetGroupMeetingDetails").ToList();
            }
            return groupMeetingList;
        }

        public int CreateGroupMeeting(GroupMeetingCreate groupMeetingCreate)
        {
            int rowAffected = 0;
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ProjectName", groupMeetingCreate.ProjectName);
                parameters.Add("@GroupMeetingLeadName", groupMeetingCreate.GroupMeetingLeadName);
                parameters.Add("@TeamLeadName", groupMeetingCreate.TeamLeadName);
                parameters.Add("@Description", groupMeetingCreate.Description);
                parameters.Add("@GroupMeetingDate", groupMeetingCreate.GroupMeetingDate);

                rowAffected = con.Execute("InsertGroupMeeting", parameters, commandType: CommandType.StoredProcedure);
            }
            return rowAffected;
        }

        public int UpdateGroupMeeting(GroupMeetingUpdate groupMeetingUpdate)
        {
            int rowAffected = 0;
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Id", groupMeetingUpdate.Id);
                parameters.Add("@ProjectName", groupMeetingUpdate.ProjectName);
                parameters.Add("@GroupMeetingLeadName", groupMeetingUpdate.GroupMeetingLeadName);
                parameters.Add("@TeamLeadName", groupMeetingUpdate.TeamLeadName);
                parameters.Add("@Description", groupMeetingUpdate.Description);
                parameters.Add("@GroupMeetingDate", groupMeetingUpdate.GroupMeetingDate);

                rowAffected = con.Execute("InsertGroupMeeting", parameters, commandType: CommandType.StoredProcedure);
            }
            return rowAffected;
        }

        public GroupMeetingView GetGroupMeetingById (int? id)
        {
            GroupMeetingView groupMeeting = new GroupMeetingView();
            if (id == null)
            {
                return groupMeeting;
            }
            using (IDbConnection con = new SqlConnection(strConnectionString))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                DynamicParameters parameter = new DynamicParameters();
                parameter.Add("@Id", id);
                groupMeeting = con.Query<GroupMeetingView>("GetGroupMeetingByID", parameter, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
            return groupMeeting;
        }
    }
}
    

