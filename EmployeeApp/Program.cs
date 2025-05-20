using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating an object of the class 'Person'
            Person person = new Person();

            // Prompting user for integer input for ID and assigning it to the person's Id property
            Console.Write(" Enter id :");
            person.Id = Convert.ToInt32(Console.ReadLine());

            // Prompting user for string input for name and storing it in a local variable
            Console.Write(" Enter name :");
            string name = Console.ReadLine();

            // Prompting user for string input for first name and assigning it to the person's Fname property
            Console.Write(" Enter Fname :");
            person.Fname = Console.ReadLine();

            // Prompting user for double input for salary and storing it in a local variable
            Console.Write(" Enter the salary :");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n"); // Printing a blank line for formatting

            // Displaying the entered and processed information

            // Displaying the ID value
            Console.WriteLine(" ID    : " + person.Id);

            // Displaying the name using the getName method (which also prints inside the method)
            person.getName(" Name  : " + name);

            // Displaying the first name
            Console.WriteLine(" Fname : " + person.Fname);

            // Displaying the salary using the getSalary method
            Console.WriteLine(" Salary : " + person.getSalary(salary));

        }
    }
}
