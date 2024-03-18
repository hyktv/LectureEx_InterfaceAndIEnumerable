﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureEx_InterfaceAndIEnumerable
{
    internal class Student
    {
        string _firstName;
        string _lastName;

        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public override string ToString()
        {
            return $"{_firstName}{_lastName}";
        }

    }
}
