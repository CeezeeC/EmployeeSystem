using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class Person
    {

        // Public property to hold a unique identifier for an object
        // Private field to store the name; accessible only within this class
        // Protected field to store the surname; accessible within this class and derived classes
        // Private field to store the salary; accessible only within this class
        public int Id;  
        private string _name;
        protected string Surname;
        private double salary;


        // Method that takes a string parameter and returns void (no return value)
        // It assigns the passed name to the private field _name and prints it
        public void getName(string name)
        {
            _name = name;
            Console.WriteLine(_name);
        }

        //  property for getting and setting the value of Fname
        public string Fname { get; set; }

        // Method that takes a double parameter and returns a double value
        // It returns the value of the salary passed to it (note: doesn't use the private field 'salary')
        public double getSalary(double salary)
        {
            return salary;
        }

    }
}
