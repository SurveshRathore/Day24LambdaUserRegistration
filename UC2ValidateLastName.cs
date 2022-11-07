using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day24LambdaUserReg
{
    internal class UC2ValidateLastName
    {
        //last name regex
        String nameRegex = "^[A-Z][a-zA-Z]{2,}";
        public void CheckLastName()
        {
            
            Console.Write("Enter the Last Name: ");
            String LastName = Console.ReadLine();
            //Display the result
            Console.WriteLine(ValidateRegex(LastName));
        }
        //compare the name regex with the user entered first name using the lambda
        public bool ValidateRegex(string userValue) => (Regex.IsMatch(userValue, nameRegex));
    }
}
