using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class UserProfile : Person
    {
        public UserProfile(String username, String password) :base(name,dob,email,facebook,linkedin,interests,phoneNumber)
        {
            base.Email = "test@test.dk";
            base.PhoneNumber = "3425";
            base.Facebook = "wt3";
            base.Interests = "34234,234";
            base.Linkedin = "234";
            base.Name = "tes";
            base.Dob = "wef";
            Person("234","34","34","43","234","32", "4");
        }





    }
}
