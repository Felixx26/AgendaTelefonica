using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Directory
    {
        public Directory()
        {

        }

        public Directory(string name, string lastname, short age, string dateBirth, string address, string province, string country, string phone, string mobile)
        {
            Name = name;
            Lastname = lastname;
            Age = age;
            DateBirth = dateBirth;
            Address = address;
            Province = province;
            Country = country;
            Phone = phone;
            Mobile = mobile;

        }

        public string Name { get; set; }
        public string Lastname { get; set; }
        public short Age { get; set; }
        public string DateBirth { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }

    }
}
