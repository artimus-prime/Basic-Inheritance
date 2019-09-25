using System;
using System.Collections.Generic;
using System.Text;

namespace ClassClass
{
    class Employee : Person
    {
        private string employeeId;
        public string employerName;

        // default constructor
        public Employee()
        {
            employeeId = "undefined";
            employerName = "undefined";
            fname = "undefined";
            lname = "undefined";
            age = 0;
        }

        // here we overwrite the introduceOneself() method of the parent to include employer name
        new public string introduceOneself()
        {
            return "Hello, my name is " + fname + " " + lname + "! I'm " + age + " years old. I work for " + employerName + ".";
        }

    }
}
