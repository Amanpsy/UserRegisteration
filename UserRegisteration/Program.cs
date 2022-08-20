using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using System.Data;

namespace UserRegistration
{
    class Program
    {
    public  static void Main(string[] args)
        {
            TestUser.UserNameValidation User = new TestUser.UserNameValidation();
            User.Validation();
            Console.ReadLine();

        }
    }
}