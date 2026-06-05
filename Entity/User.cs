using Core.DataAccess.Repositories;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }//nickname
        public string? FullName { get; set; }
        public string? OgrenciNo { get; set; }
        public string? Phone { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public int RoleId { get; set; }
        public bool KvkkApproved { get; set; } = false;
        public bool OnamApproved { get; set; } = false;
        public bool IlkGiris { get; set; } = false;
        public string? DeviceToken { get; set; }
        public bool SimulasyonTamamlandiMi { get; set; } = false;
        public bool CozumlemeTamamlandiMi { get; set; } = false;
        public int? ToplamPuan { get; set; }
        public Role Role { get; set; }
        public HashSet<ModuleRoles> ModuleRoles { get; set; }
        public HashSet<SoruUser> SoruUsers { get; set; }
        public HashSet<CozumlemeSoruUser> CozumlemeSoruUsers { get; set; }
    }
    
}

