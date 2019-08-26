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

        public void DisplayInfor()
        {
            Console.WriteLine("id: { 0} \t\tName: {1} \t\t Password: {2} \t\t PhoneList: {3}"
                , ID, Name, Password, PhoneList);
        }

       
    }
}
