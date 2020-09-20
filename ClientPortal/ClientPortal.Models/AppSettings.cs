using System;
using System.Collections.Generic;
using System.Text;

namespace ClientPortal.Models
{
    public class AppSettings
    {
        public string JWT_Secret { get; set; }
        public string Client_URL { get; set; }
    }
}
