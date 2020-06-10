﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EsportManagementApp.Model
{
    public class Player
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private int _experience;

        public int Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }
    }
}
