using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace LunchBox.Shared
{

    public class RolesStore
    {
        public const string SuperAdministrator = "Super Administrator";
        public const string Administrator = "Administrator";
        public const string CompanyAdministrator = "Company administrator";
        public const string Customer = "Customer";
        public const string Visitor = "Visitor";

        public RolesStore() 
        {
            this.allRolesStore = new List<String>()
            {
                Administrator,
                CompanyAdministrator,
                Customer,
                Visitor
            };
        }
        public IList<string> allRolesStore { get; set; }

    }
}
