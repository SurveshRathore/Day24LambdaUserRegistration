using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day24LambdaUserReg
{
    internal class UC4ValidateMobile
    {
        //mobile number regex
        String nameRegex = "^([0-9]{2})\\s[6-9]{1}[0-9]{9}$";
        //here \\s for space $ to fix the size
        //^([0-9]{2}) fix first 2 digit
        public void CheckMobileNumber()
        {
            
            Console.Write("Enter the Mobile number with the country code: ");
            String mobileNumber = Console.ReadLine();
            //compare the mobile regex with the user entered mobile number
            Console.WriteLine(ValidateRegex(mobileNumber));
        }
        //compare the name regex with the user entered first name using the lambda
        public bool ValidateRegex(string userValue) => (Regex.IsMatch(userValue, nameRegex));
    }
}
