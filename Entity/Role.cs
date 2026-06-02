using Core.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Role : BaseEntity
    {
        public string Name { get; set; }
        public HashSet<User> Users { get; set; }
        public HashSet<ModuleRoles> ModuleRoles { get; set; }
    }
}
