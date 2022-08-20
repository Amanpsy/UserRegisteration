﻿using System;
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
                Console.WriteLine(" Entered pattern is Valid\n");
            }
            else
            {
                Console.WriteLine("Entered pattern is Invalid\n");
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
    }
}
