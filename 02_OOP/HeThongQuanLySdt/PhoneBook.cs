using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HeThongQuanLySdt
{
    class PhoneBook : Phone
    {
        // luu du lieu
        ArrayList PhoneLists = new ArrayList();
        public override void InsertPhone(string name, string phone)
        {
            foreach (string phoneList in PhoneLists)
            {
                if (name != phoneList || name == phoneList && phone != )
                {
                    PhoneLists.Add(phone);
                }
            }
        }

        public override void RemovePhone(string name)
        {
            throw new NotImplementedException();
        }

        public override void searchPhone(string name)
        {
            throw new NotImplementedException();
        }

        public override void sort()
        {
            throw new NotImplementedException();
        }

        public override void updatePhone(string name, string newPhone)
        {
            throw new NotImplementedException();
        }


    }
}
