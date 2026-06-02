
using DataTransferObject.ModuleRole;
using DataTransferObject.Role;
using DataTransferObject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.User
{
    public class UserModel
    {
        public UserModel()
        {
            AuthList = new List<ModuleRoleDTO>();
            AccessToken = new AccessToken();
        }

        public int Id { get; set; }
        public int RolId { get; set; }
        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public string Username { get; set; }
        public string? FullName { get; set; }
        public string? BirthDate { get; set; }
        public string? SurgerySide { get; set; }
        public bool? HasRadiotherapy { get; set; }
        public bool? HasChemotherapy { get; set; }
        public string Phone { get; set; }
        public string? DeviceToken { get; set; }
        public AccessToken AccessToken { get; set; }
        public RoleDTO roleDTO  { get; set; }

        public List<ModuleRoleDTO> AuthList { get; set; }
    }
}
