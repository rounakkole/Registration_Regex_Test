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
        public static string email = "^[a-z]{3,}(([.|+]{1})?([-]{1})?[0-9]{1,})?@[a-z0-9]{1,}.[a-z]{3}(.[a-z]{2,4})?$";
        public static string mobileNo = "^91[/ /][6-9]{1}[0-9]{9}$";
        public static string password = "^(?=.*[!@#$%^&*]{1})(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9@$!%*#?&]{8,}$";

        public string ValidateFirstName(string data)
        {
            bool result = Regex.IsMatch(data, firstName);
            if (result)
            {
                return "valid firstName";
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_FIRSTNAME, "invalid firstName");
            }
        }
        public string ValidateLastName(string data)
        {
            bool result = Regex.IsMatch(data, lastName);
            if (result)
            {
                return "valid lastName";
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_LASTNAME, "invalid lastName");
            }
        }
        public string ValidateEmail(string data)
        {
            bool result = Regex.IsMatch(data, email);
            if (result)
            {
                return "valid email";
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_EMAIL, "invalid email");
            }
        }
        public string ValidateMobileNo(string data)
        {
            bool result = Regex.IsMatch(data, mobileNo);
            if (result)
            {
                return "valid mobileNo";
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_MOBILE_NO, "invalid mobileNo");
            }
        }
        public string ValidatePassword(string data)
        {
            bool result = Regex.IsMatch(data, password);
            if (result)
            {
                return "valid password";
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.INVALID_PASSWORD, "invalid password");
            }
        }

    }
}
