using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2CGraphShell
{
    public class User
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public List<Role> Roles { get; set; } = new List<Role>();
        public string EmailId { get; set; }
    }

    public class Role
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
    }
}
