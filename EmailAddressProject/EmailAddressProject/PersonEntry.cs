using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailAddressProject
{
    class PersonEntry
    {
        public string Name;
        public string Email;
        public string Phone;

        public PersonEntry(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}
