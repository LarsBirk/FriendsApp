using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VennerBekendte.Logic
{
    class Tools
    {
        
        public bool isPasswordEqual(PasswordBox password, PasswordBox confirmedPassword)
        {
            if (password.Equals(confirmedPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
