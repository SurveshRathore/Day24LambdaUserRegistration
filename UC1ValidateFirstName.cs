using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day24LambdaUserReg
{
    internal class UC1ValidateFirstName
    {
        //first name regex
        String nameRegex = "^[A-Z][a-zA-Z]{2,}";
        //method to validate the first name
        public void CheckFirstName()
        {
            Console.Write("Enter the First Name: ");
            String userName = Console.ReadLine();
            //Display the result
            Console.WriteLine(ValidateRegex(userName));
        }
        //compare the name regex with the user entered first name using the lambda
        public bool ValidateRegex(string userValue) => (Regex.IsMatch(userValue, nameRegex));
    }
}
