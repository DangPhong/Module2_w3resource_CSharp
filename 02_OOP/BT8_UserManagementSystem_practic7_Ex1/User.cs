using System;
using System.Collections.Generic;
using System.Text;

namespace BT8_UserManagementSystem_practic7_Ex1
{
    class User : IUser
    {
        public int id;
        private string name, password;
        private List<int?> phoneList = new List<int?>();
        public int ID { get => id; set => id = value; }
       
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public List<int?> PhoneList { get => phoneList; set => phoneList = value; }

        public string DisplayInfor()
        {
            if (PhoneList == null || PhoneList.Count == 0)
                return $"Id: {id} Name: {name} Password: {password}";
            else
                return $"Id: {id} Name: {name} Password: {password} Phone list: {string.Join(" - ", PhoneList)}";
        }
    }
}
