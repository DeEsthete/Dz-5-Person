﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(int id, string firstName, string lastNAme, int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastNAme;
            Age = age;
        }
    }
}
