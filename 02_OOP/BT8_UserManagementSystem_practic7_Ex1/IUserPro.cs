using System;
using System.Collections.Generic;
using System.Text;

namespace BT8_UserManagementSystem_practic7_Ex1
{
    interface IUserPro
    {
        int ID { get; set; }
        string Name { get; set; }
        string Password { get; set; }
       
    }
}
