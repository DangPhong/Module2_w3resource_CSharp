using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper2.Models;
using Dapper2.DAL;
namespace Dapper2.Controllers
{
    public class GroupMeetingController : Controller
    {
        private readonly GroupMeetingService groupMeetingService = new GroupMeetingService();

        public IActionResult Index()
        {
            return View(groupMeetingService.GetGroupMeetings());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(GroupMeetingCreateModel model)
        {
            var createResult = groupMeetingService.AddGroupMeeting(new GroupMeeting()
            {
                Description = model.Description,
                GroupMeetingDate = model.GroupMeetingDate,
                GroupMeetingLeadName = model.GroupMeetingLeadName,
                ProjectName = model.ProjectName,
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
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int id, GroupMeeting groupMeeting)
        {
            var deleteResult = groupMeetingService.GetGroupMeetingById(id);
            if (groupMeetingService.DeleteGroupMeeting(id) > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var group = groupMeetingService.GetGroupMeetingById(id);
            var detailResult = new GroupMeetingView()
            {
                Id = group.Id,
                Description = group.Description,
                TeamLeadName = group.TeamLeadName,
                MeetingDate = group.GroupMeetingDate,
                LeadName = group.GroupMeetingLeadName,
                ProjectName = group.ProjectName
            };
            return View(detailResult);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var group = groupMeetingService.GetGroupMeetingById(id);
            var editResult = new GroupMeetingEditModel()
            {
                Description = group.Description,
                GroupMeetingDate = group.GroupMeetingDate,
                GroupMeetingLeadName = group.GroupMeetingLeadName,
                ProjectName = group.ProjectName,
                TeamLeadName = group.TeamLeadName
            };
            return View(editResult);
        }
        [HttpPost]
        public IActionResult Edit(int id, GroupMeeting group)
        {
            if (id != group.Id)
                return NotFound();
            if (ModelState.IsValid)
            {
                groupMeetingService.UpdateGroupMeeting(group);
                return RedirectToAction("Index");
            }
            return View(group);
        }
    }
}
