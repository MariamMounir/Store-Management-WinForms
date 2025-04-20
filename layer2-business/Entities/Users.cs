using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer2_business.Entities
{
    public class Users
    {
        public int UserId { get; set; }
        public  string Username { get; set; }
        public  string PasswordHash { get; set; }
        public  string Email { get; set; }
        public bool IsAdmin { get; set; } = false;
        public bool IsActive { get; set; } = false;

    }
}
