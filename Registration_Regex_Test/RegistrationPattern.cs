using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Registration_Regex_Test
{
    public class RegistrationPattern
    {

        public static string firstName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string lastName = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string email = "^[a-z]{3,}([.]{1}[a-z]{2,})?[/@/][a-z]{2,5}[/./][a-z]{2,5}([.]{1}[a-z]{2})?$";
        public static string mobileNo = "^91[/ /][6-9]{1}[0-9]{9}$";
        public static string password = "^(?=.*[!@#$%^&*]{1})(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9@$!%*#?&]{8,}$";

        public bool ValidateFirstName(string data)
        {
            bool result = Regex.IsMatch(data, firstName) ? true : false;
            return result;
        }
        public bool ValidateLastName(string data)
        {
            bool result = Regex.IsMatch(data, lastName) ? true : false;
            return result;
        }
        public bool ValidateEmail(string data)
        {
            bool result = Regex.IsMatch(data, email) ? true : false;
            return result;
        }
        public bool ValidateMobileNo(string data)
        {
            bool result = Regex.IsMatch(data, mobileNo) ? true : false;
            return result;
        }
        public bool ValidatePassword(string data)
        {
            bool result = Regex.IsMatch(data, password) ? true : false;
            return result;
        }

    }
}
