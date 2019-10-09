using DAL.Interface;
using Dapper;
using Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class UserRepository : BaseRepository, IUserRepository
    {
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
            IList<User> customerList = SqlMapper.Query<User>(con, "GetAllUsers", commandType: CommandType.StoredProcedure).ToList();
            return customerList;
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
