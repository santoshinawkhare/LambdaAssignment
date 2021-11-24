using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day_24_Assign_lambda
{
     public class CheckPattern
    {
        public const string FNamePattern = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string LNamePattern = "^[A-Z]{1}[A-Za-z]{2,}$";
        public const string EmailPattern = "^[a-z]{3,}([!@#$%^+&*._-]?[a-z]+)?[@]{1}[a-z]{2,}[.]{1}[a-z]{2,}([.]?[a-z]+)?$";
        public const string PhoneNumberPattern = "^[1-9]{2}\\s[6-9]{1}[0-9]{9}$";
        public const string PasswordPattern1 = "^[A-za-z0-9!@#$%^+&*._-]{8,}$";
        public const string PasswordPattern2 = "^[A-z]{1,}[A-za-z0-9!@#$%^+&*._-]{7,}$";
        public const string PasswordPattern3 = "^[A-z]{1,}[0-9]{1,}[A-za-z0-9!@#$%^+&*._-]{6,}$";
        public const string PasswordPattern4 = "^[A-z]{1,}[0-9]{1,}[!@#$%^+&*._-]{1}[A-Za-z0-9]{5,}$";
        public const string AllEmailPattern = "^[a-z]{3,}([!@#$%^+&*._-]?[0-9]+)?[@]{1}[0-9a-z]{1,}[.]{1}[a-z]{2,}([.]?[a-z]+)?$";

        Dictionary<string, string> Pattern = new Dictionary<string, string>()
        {
            { "FNamePattern", CheckPattern.FNamePattern.ToString() },
            { "LNamePattern", CheckPattern.LNamePattern.ToString() },
            { "EmailPattern", CheckPattern.EmailPattern.ToString() },
            { "PhoneNumberPattern", CheckPattern.PhoneNumberPattern.ToString() },
            { "PasswordPattern3 ", CheckPattern.PasswordPattern3.ToString() },
        };
        public string FirstNameValidation(string FirstName)
        {
            try
            {
                var fNamePattern = Pattern.FirstOrDefault(x => x.Key == "patternForFName").Value.ToString();
                if (Regex.IsMatch(FirstName, fNamePattern))
                {
                    return "True";
                }
                else
                {
                    throw new CheckCustomExceptionPattern(CheckCustomExceptionPattern.ExceptionType.ENTERED_INVALIDFIRSTNAME, "Invalid First Name,First letter should be upper case");

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string LastNameValidation(string LastName)
        {
            try
            {
                var lNamePattern = Pattern.FirstOrDefault(x => x.Key == "patternForLName").Value.ToString();
                if (Regex.IsMatch(LastName, lNamePattern))
                {
                    return "True";
                }
                else
                {
                    throw new CheckCustomExceptionPattern(CheckCustomExceptionPattern.ExceptionType.ENTERED_INVALIDLASTNAME, "Invalid Last Name,First letter should be upper case");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string EmailValidation(string Email)
        {
            try
            {
                var emailPattern = Pattern.FirstOrDefault(x => x.Key == "patternForEmail").Value.ToString();
                if (Regex.IsMatch(Email, emailPattern))
                {
                    return "True";
                }
                else
                {
                    throw new CheckCustomExceptionPattern(CheckCustomExceptionPattern.ExceptionType.ENTERED_INVALIDEMAIL, "Invalid Email Address Format");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string PhoneNoValidation(string PhoneNo)
        {
            try
            {
                var phonePattern = Pattern.FirstOrDefault(x => x.Key == "patternForPhoneNo").Value.ToString();
                if (Regex.IsMatch(PhoneNo, phonePattern))
                {
                    return "True";
                }
                else
                {
                    throw new CheckCustomExceptionPattern(CheckCustomExceptionPattern.ExceptionType.ENTERED_INVALIDMOBILE, "Invalid Phone Number");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string UC_5_PasswordValidation(string Password)
        {
            return Regex.IsMatch(Password, PasswordPattern1).ToString();
        }

        public string UC_6_PasswordValidation(string Password)
        {
            return Regex.IsMatch(Password, PasswordPattern2).ToString();
        }

        public string UC_7_PasswordValidation(string Password)
        {
            return Regex.IsMatch(Password, PasswordPattern3).ToString();
        }
        public string UC_8_PasswordValidation(string Password)
        {
            try
            {
                var passPattern = Pattern.FirstOrDefault(x => x.Key == "patternForPaswd").Value.ToString();
                if (Regex.IsMatch(Password, passPattern))
                {
                    return "True";
                }
                else
                {
                    throw new CheckCustomExceptionPattern(CheckCustomExceptionPattern.ExceptionType.ENTERED_INVALIDPASSWORD, "Invalid Password");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string allEmailValidation(string Email)
        {
            return Regex.IsMatch(Email, AllEmailPattern).ToString();
        }

    }
}
