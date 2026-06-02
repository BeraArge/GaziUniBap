using BusinessLogicLayer.Abstracts;
using Core.ResultType;
using DataAccessLayer.EntityFramework.Abstracts;
using DataTransferObject.UserDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concretes
{
    public class UserDetailBL : IUserDetailBL
    {
        private readonly IUserRepository _userRepository;

        public UserDetailBL( IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

    }
}
