using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defense.BL
{
    /// <summary>
    /// Manages a single customer
    /// </summary>
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Tuple<bool, string> ValidateEmail()
        {
            Tuple<bool, string> result = Tuple.Create(true, "");
            var isValidFormat = true;
            var isRealDomain = true;

            if (string.IsNullOrWhiteSpace(Email))
            {
                result = Tuple.Create(false, "Email address is empty");
                //message = "Email address is empty";
                //throw new ArgumentException("Email address is empty");
            }

            if (result.Item1 == true)
            {
                //RegEx for format of email

                if (!isValidFormat)
                {
                    result = Tuple.Create(false, "Email address is empty");
                    //isValid = false;
                    //message = "Email address is not valid";
                    //throw new ArgumentException("Email address is not valid");
                }
            }

            if (result.Item1 == true)
            {
                // Verify domain exists

                if (!isRealDomain)
                {
                    result = Tuple.Create(false, "Email address is empty");
                    //isValid = false;
                    //message = "Email address does not include a valid domain";
                    //throw new ArgumentException("Email address does not include a valid domain");
                }
            } 

            return result;

        }

        public string CalculatePercentOfGoalSteps(string goal, string steps)
        {
            string result;

            if (Decimal.TryParse(goal, out var g) && Decimal.TryParse(steps, out var s))
            {
                if (g > 0)
                {
                    decimal calculation = CalculatePercentOfGoalSteps(g, s);
                    result = $"You have reached {calculation}% of your goal!";
                }
                else
                {
                    result = "You have reached 0% of your goal!";
                }
            }
            else
            {
                result = "Invalid parameters";
            }

            return result;
        }

        public decimal CalculatePercentOfGoalSteps(decimal goal, decimal steps)
        {
            return (steps / goal) * 100;
        }
    }
}
