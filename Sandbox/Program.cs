using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> ansatte = new List<Employee>();

            Employee person1 = new Employee("Peter Hansen", 100);
            Employee person2 = new Employee("Jesper Dinesen", 480);
            Employee person3 = new Employee("Jeppe Nielsen", 520);

            ansatte.Add(person1);
            ansatte.Add(person2);
            ansatte.Add(person3);

            Console.WriteLine("Ansatte i virksomheden: ");
            foreach (Employee p in ansatte)
            {
                Console.WriteLine($"Navn: {p.name} Månedsløn: {p.salaryPerMonth}");
            }


            Console.WriteLine();
            Console.WriteLine("Press any key to close the program...");

            Console.ReadKey();
        }
    }
}
