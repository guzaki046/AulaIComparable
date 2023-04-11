﻿using System.Globalization;

namespace AulaIComparable.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(string csvEmployee)
        {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Salary.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
