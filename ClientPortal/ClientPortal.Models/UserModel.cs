using System;
using System.Collections.Generic;
using System.Text;

namespace ClientPortal.Models
{
    public partial class UserModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmation { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public string Role { get; set; }
    }
}
