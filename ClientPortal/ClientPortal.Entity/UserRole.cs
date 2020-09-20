using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace ClientPortal.Entities
{
    public partial class UserRole:IdentityUserRole<string>
    {
        [ForeignKey("Users")]
        public override string UserId { get; set; }
        public virtual User User { get; set; }
        [ForeignKey("Roles")]
        public override string RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}
