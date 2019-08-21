using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using HeThongQuanLySdt.Models;
namespace HeThongQuanLySdt
{
    class PhoneBook : Phone
    {
        // luu du lieu
       public  ArrayList PhoneLists = new ArrayList();
        public override void InsertPhone(string name, string phone)
        {
            if (PhoneLists != null && UserIsExited(name))
            {
                foreach (PhoneItem phoneItem in PhoneLists)
                {
                    if (phoneItem.Name == name)
                    {
                        if (phoneItem.PhoneNumber != phone)
                        {
                            phoneItem.PhoneNumber += ":" + phone;
                        }
                    }
                }
            }
            else
            {
                // cach 1
                var phoneItem = new PhoneItem();
                phoneItem.Name = name;
                phoneItem.PhoneNumber = phone;
                PhoneLists.Add(phoneItem);
            }
            // cach 2
            //var phone2 = new PhoneItem()
            //{
            //    Name = name,
            //    PhoneNumber = phone
            //};
            //PhoneLists.Add(phone2);

            // Cach 3
            //PhoneLists.Add(new PhoneItem()
            //{
            //    Name = name,
            //    PhoneNumber = phone
            //});
        }

        public override void RemovePhone(string name)
        {
            if (PhoneLists != null)
            {
                foreach (PhoneItem phoneItem in PhoneLists)
                {
                    if (phoneItem.Name == name)
                    {
                        PhoneLists.Remove(phoneItem);
                        break;
                    }
                }
            }
        }

        public override void UpdatePhone(string name, string newPhone)
        {
            if (PhoneLists != null)
            {
                foreach (PhoneItem phoneItem in PhoneLists)
                {
                    if (phoneItem.Name == name)
                    {
                        phoneItem.PhoneNumber = newPhone;
                    }
                }
            }
        }

        public override void SearchPhone(string name)
        {
            if (PhoneLists != null)
            {
                foreach (PhoneItem phoneItem in PhoneLists)
                {
                    if (phoneItem.Name == name)
                    {
                        Console.WriteLine("Phone number's {0} is: {1}", name, phoneItem.PhoneNumber);
                        break;
                    }
                }
            }
        }

        public override void Sort()
        {
            PhoneLists.Sort();
        }

        private bool UserIsExited(string userName)
        {
            if (PhoneLists != null)
            {
                foreach (PhoneItem item in PhoneLists)
                {
                    if (item.Name == userName)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

