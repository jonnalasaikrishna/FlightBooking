using AirlinesAdminUser.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLogin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminUserController : ControllerBase
    {
        Flight_Booking_DBContext _flight_Booking_DBContext;

        public AdminUserController(Flight_Booking_DBContext flight_Booking_DBContext)
        {
            _flight_Booking_DBContext = flight_Booking_DBContext;
        }
        [Authorize]
        [HttpGet]
        [Route("GetAdminUsers")]
        public IActionResult GetAdminUsers()
        {
           
            try
            {
                var AdminUsers = _flight_Booking_DBContext.AdminUsers.ToList();
                return new OkObjectResult(AdminUsers);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
