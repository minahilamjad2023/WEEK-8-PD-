using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD_8_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Fajar","Lahore" );
            Staff staff = new Staff("PIPS", 3500, "Fajar","Lahore");
            Student student = new Student("CS",4,9000,"Fajar","Lahore");
            Console.WriteLine("Person Details:");
            Console.WriteLine(person.ToString());
            Console.WriteLine("\nStaff Details:");
            Console.WriteLine(staff.ToString());
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine(student.ToString());
            Console.ReadKey();
        }
    }
}
