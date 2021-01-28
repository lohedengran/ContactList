using System;
using System.Collections.Generic;
using System.Text;

namespace ContactList
{
    class Person
    {
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }

        public Person(string firstName, string phoneNumber, string eMail)
        {
            FirstName = firstName;
            PhoneNumber = phoneNumber;
            EMail = eMail;
        }


    }
}
