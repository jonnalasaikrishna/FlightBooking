﻿using Authenticate.Interfaces;
using Authenticate.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authenticate.Controllers
{   
        [Route("api/[controller]")]
        [ApiController]
        public class UsersController : ControllerBase
        {
            private readonly IJWTManagerRepository iJWTManager;

            public UsersController(IJWTManagerRepository jWTManager)
            {
                iJWTManager = jWTManager;
            }

            [HttpGet]
            [Route("get-all-users")]
            public List<string> Get()
            {
                var users = new List<string> { "Krishna", "Sai", "Balu" };
                return users;
            }
            [AllowAnonymous]
            [HttpPost]
            [Route("authenticate")]
            public IActionResult Authenticate(Users userdata)
            {
                var token = iJWTManager.Authenticate(userdata);
                if (token == null)
                {
                    return Unauthorized();
                }
                return Ok(token);
            }
        }
    }
