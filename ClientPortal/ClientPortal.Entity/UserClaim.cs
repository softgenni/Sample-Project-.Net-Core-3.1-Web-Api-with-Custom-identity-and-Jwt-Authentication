using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace ClientPortal.Entities
{
    public partial class UserClaim:IdentityUserClaim<string>
    {
    }
}
