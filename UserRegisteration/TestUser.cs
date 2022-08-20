using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUser
{
   public class UserNameValidation
    {
        public void Regex_User(string input, string pattern)
        {

            if (Regex.IsMatch(input, pattern))
            {
                Console.WriteLine("Entered pattern is Valid");
            }
            else
            {
                Console.WriteLine("  Entered pattern is Invalid");
            }
        }
        public void Validation()
        {
            Console.WriteLine("Enter the user name");
            string input = Console.ReadLine();
            string pattern = "^[A-Z][a-z]{3}$";
            Regex_User(input , pattern);
        }
    }
}
