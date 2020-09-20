using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace ClientPortal.Entities
{
    public partial class Role:IdentityRole<string>
    {
        public virtual ICollection<UserRole> UserRole { get; }
    }
}
