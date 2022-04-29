using AdminLogin.Models;
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
        FlightBookingDBContext _flightBookingDBContext;

        public AdminUserController(FlightBookingDBContext flightBookingDBContext)
        {
            _flightBookingDBContext = flightBookingDBContext;
        }
        [HttpGet]
        [Route("GetAdminUsers")]
        public IEnumerable<AdminUser> GetAdminUsers()
        {
            return _flightBookingDBContext.AdminUsers.ToList();
        }
    }
}
