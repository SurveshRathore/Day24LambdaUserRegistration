using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day24LambdaUserReg
{
    internal class UC3ValidateEmail
    {
        //email regex
        String nameRegex = "^[A-Za-z][A-Za-z0-9]{2,}([.]([A-Za-z0-9]{3,}))?@[a-z]{2,}[.][a-z]{2,}([.][a-z]{2,})?";
        //starts with A-Za-z then must have two or more A-Za-z0-9
        //([.]([A-Za-z0-9]{3,}))? optional
        //([.][a-z]{2})? optional
        public void CheckEmail()
        {
            
            Console.Write("Enter the Email: ");
            String email = Console.ReadLine();
            //compare the email regex with the user entered email
            Console.WriteLine(ValidateRegex(email));
        }
        //compare the name regex with the user entered first name using the lambda
        public bool ValidateRegex(string userValue) => (Regex.IsMatch(userValue, nameRegex));
    }
}
