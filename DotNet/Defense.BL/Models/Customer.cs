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

        public void ValidateEmail(string email)
        {
            throw new NotImplementedException();
        }

        public string CalculatePercentOfGoalSteps(string goal, string steps)
        {
            string result;

            if (Int32.TryParse(goal, out var g) && Int32.TryParse(steps, out var s))
            {
                if (g > 0)
                {
                    decimal calculation = (Convert.ToDecimal(s) / Convert.ToDecimal(g)) * 100;
                    result = $"You have reached {calculation}% of your goal!";
                }
                else
                {
                    result = "Cannot divide by 0 or less than 0";
                }
            }
            else
            {
                result = "Invalid parameters";
            }

            return result;
        }
    }
}
