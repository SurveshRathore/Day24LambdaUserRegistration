using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day24LambdaUserReg
{
    internal class UC8PassSpecialChar
    {
        //one character in uppercase + one number + one special character password regex
        String nameRegex = "(?=.*\\W)(?=.*[A-Z])(?=.*[0-9]).{8}";
        //here \\w for non-word character
        public void CheckSpecialCharInPassword()
        {          
            Console.Write("Enter the password with minimum 8 characters: ");
            String passChar = Console.ReadLine();
            //compare the password regex with the user entered password
            Console.WriteLine(ValidateRegex(passChar));
        }
        //compare the name regex with the user entered first name using the lambda
        public bool ValidateRegex(string userValue) => (Regex.IsMatch(userValue, nameRegex));
    }
}
