using System;
using System.Collections.Generic;

#nullable disable

namespace AirlinesAdminUser.Models
{
    public partial class AdminUser
    {
        public int Id { get; set; }
        public int? AdminId { get; set; }
        public string Password { get; set; }
        public string AdminName { get; set; }
        public string EmailAddres { get; set; }
        public int? PhoneNumber { get; set; }
        public string Country { get; set; }
    }
}
