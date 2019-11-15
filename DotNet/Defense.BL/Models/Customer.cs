﻿using System;
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

        public decimal CalculatePercentOfGoalSteps(string goal, string steps)
        {
            return (Convert.ToDecimal(steps) / Convert.ToDecimal(goal)) * 100;
        }
    }
}
