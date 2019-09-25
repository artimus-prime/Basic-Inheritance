using System;
using System.Collections.Generic;
using System.Text;

namespace ClassClass
{
    class Person
    {

        // fields:
        public static string fname;
        public static string lname;
        public static int age;

        // Constructor - default
        public Person()
        {
            fname = "undefined";
            lname = "undefined";
            age = 0;
        }
        // Constructor Parametrized
        public Person(string fname, string lname, int age)
        {
            Person.fname = fname;
            Person.lname = lname;
            Person.age = age;
        }

        public string introduceOneself()
        {
            return "Hello, my name is " + fname + " " + lname + "! I'm " + age + " years old.";
        }

    }
}
