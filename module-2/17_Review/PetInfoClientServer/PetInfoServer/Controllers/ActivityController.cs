using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetInfoServer.DAL.Interfaces;
using PetInfoServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PetInfoServer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class ActivityController : Controller
    {
        private IActivityDAO activityDAO;

        public ActivityController(IActivityDAO activityDAO)
        {
            this.activityDAO = activityDAO;
        }

        [HttpGet()]
        public ActionResult<List<Activity>> GetActivities()
        {
            string username = User.Identity.Name;
            string userId = User.FindFirst("sub").Value;

            List<Activity> activities = activityDAO.GetActivities();
            if (activities.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(activities);
            }
        }
    }
}
