using Core.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ModuleRoles : BaseEntity
    {
        public int ModuleId { get; set; }
        public int RolId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Module Module { get; set; }
        public Role Role { get; set; }
    }
}
