using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUser
{
    class UserNameValidation
    {
        public void User_Regex(string input, string pattern)
        {
            if (Regex.IsMatch(input, pattern))
            {
                Console.WriteLine("Valid\n");
            }
            else
            {
                Console.WriteLine("Invalid\n");
            }
        }
        public void ValidateFirstName(string firstName)
        {
            string pattern = "^[A-Z][a-z]{3}$";
            User_Regex(firstName, pattern);
        }
        public void ValidateLastName(string lastName)
        {
            string pattern = "^[A-Z][a-z]{3}$";
            User_Regex(lastName, pattern);
        }

        public void ValidateEmail(string emailID)
        {
            string pattern = "^[a-z]+(.[a-z]+)?(@[a-z]+[.][a-z]+)(.[a-z]+)?";
            User_Regex(emailID, pattern);
        }
        public void ValidateMobileNumber(string mobileNumber)
        {
            string pattern = "^[0-9]{2}[ ][0-9]{10}";
            User_Regex(mobileNumber, pattern);
        }
    }
}
