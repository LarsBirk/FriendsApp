using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Person
    {

        public string Name { get; set; }
        public string Dob { get => Dob; set => Dob = value; }
        public string Email { get => Email; set => Email = value; }
        public string Facebook { get => Facebook; set => Facebook = value; }
        public string Linkedin { get => Linkedin; set => Linkedin = value; }
        public string Interests { get => Interests; set => Interests = value; }
        public string PhoneNumber { get => PhoneNumber; set => PhoneNumber = value; }


    
    public Person(string name, string dob, string email, string facebook, string linkedin, string interests, string phoneNumber)
    {
        Name = name;
        Dob = dob;
        Email = email;
        Facebook = facebook;
        Linkedin = linkedin;
        Interests = interests;
        PhoneNumber = phoneNumber;

    }
}
}
