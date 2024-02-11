using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TransportReservationSystem.Core.Models;
using TransportReservationSystem.Core.ViewModels;

namespace TransportReservationSystem.Core.Constants
{
    public class Validation
    {
        public static ValidationResult PassengerValidation(PassengerVm passenger) {
            ValidationResult validationResult = new ValidationResult();

            bool IsValidPhone(string phone)
            {
                string pattern = @"^[+]{1}(?:[0-9\\-\\(\\)\\/" +
                          "\\.]\\s?){6,15}[0-9]{1}$";


                return Regex.IsMatch(phone, pattern);
            }

            bool IsValidEmail(string email)
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return Regex.IsMatch(email, pattern);
            }

            //Method to validate password using regular expression
            bool IsValidPassword(string password)
            {
                string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
                
                return Regex.IsMatch(password, pattern);
            }


            if (string.IsNullOrEmpty(passenger.Email))
            {
                validationResult.MessageError = "Email must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (!IsValidEmail(passenger.Email))
            {
                validationResult.MessageError = "Please enter a valid email address ..!!";
                validationResult.IsValid = false;
            }
            else if (string.IsNullOrEmpty(passenger.Password))
            {
                validationResult.MessageError = "Password must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (!IsValidPassword(passenger.Password))
            {
                validationResult.MessageError = "Please enter a valid password (at least 8 characters)";
                // ", containing at least one uppercase letter, one lowercase letter, one digit, and one special character ..!!";
                validationResult.IsValid = false;
            }

            else if(string.IsNullOrEmpty(passenger.Gender))
            {
                validationResult.MessageError = "Gender must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (string.IsNullOrEmpty(passenger.Phone))
            {
                validationResult.MessageError = "Phone must be required ..!!";
                validationResult.IsValid = false;
            }
            else if (IsValidPhone(passenger.Phone)==true)
            {
                validationResult.MessageError = "Please enter a valid phone number ..!!";
                validationResult.IsValid = false;
            }
            else
            {
                validationResult.IsValid = true;

            }
            return validationResult;
        }
    }
}
