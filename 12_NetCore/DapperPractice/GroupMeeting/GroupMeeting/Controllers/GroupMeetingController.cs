using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GroupMeeting.Models;
using GroupMeeting.DAL;
using GroupMeeting.Models.Domain.Request;

namespace GroupMeeting.Controllers
{
    public class GroupMeetingController : Controller
    {
        private readonly GroupMeetingReponsitory groupMeetingReponsitory = new GroupMeetingReponsitory();
        public IActionResult Index()
        {
            return View(groupMeetingReponsitory.GetGroupMeetings());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(GroupMeetingCreate model)
        {
            var createResult = groupMeetingReponsitory.CreateGroupMeeting(new GroupMeetingCreate()
            {
                Description = model.Description,
                GroupMeetingLeadName = model.GroupMeetingLeadName,
                ProjectName = model.ProjectName,
                GroupMeetingDate = model.GroupMeetingDate,
                TeamLeadName = model.TeamLeadName
            });
            if (createResult > 0)
            {
                TempData["Success"] = "Group meeting has been created success";
            }
            else
            { 
                TempData["Error"] = "Something went wrong, please try again later";
            }
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {

        }
    }
}