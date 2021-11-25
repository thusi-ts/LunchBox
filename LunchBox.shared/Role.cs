using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBox.Shared
{
    public static class Role
    {
        public const string SuperAdmin = "Has authority of users and roles and permissions.";
        public const string StorAdmin = "Has full authority of own store";
        public const string User = "Customer of the system";
    }
}
