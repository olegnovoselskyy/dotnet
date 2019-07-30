﻿using System;

namespace ACM.BL
{
    public class Customer
    {

        #region Fields

        private string _firstName;
        private string _lastName;

        #endregion

        #region Properties

        public int CustomerID { get; private set; }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }


        #endregion

    }
}