using BAL.Interface;
using DAL.Interface;
using Domain;
using System;
using System.Collections.Generic;

namespace BAL
{
    public class UserService : IUserService
    {
        
        IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetAllUser()
        {
            return _userRepository.GetAllUser();
        }

        public User GetUserById(int userId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
