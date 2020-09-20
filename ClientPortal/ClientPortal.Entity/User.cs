using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace ClientPortal.Entities
{
    public partial class User:IdentityUser<string>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<UserRole> UserRole { get; }
    }
}
