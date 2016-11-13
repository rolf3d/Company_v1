using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> ansatte = new List<Employee>();



            Employee person1 = new Employee("Peter Hansen", 100);
            Employee person2 = new Employee("Jesper Dinesen", 480);
            Employee person3 = new Employee("Jeppe Nielsen", 520);
            Director direktør1 = new Director("Hansen", 450000);

            List<Employee> ansatte = new List<Employee>() { person1, person2, person3 };

            //ArrayList theArraryList = new ArrayList() { 12, "brian", ansatte, person1,person2 };

            //ansatte.Add("brian");
            //theArraryList.Add("johnny");
            //theArraryList.Add(person1);

            ansatte.Add(direktør1);
            //ansatte.Add(person1);
            //ansatte.Add(person2);
            //ansatte.Add(person3);


            Console.WriteLine("Ansatte i virksomheden: ");
            foreach (Employee p in ansatte)
            {
                Console.WriteLine($"Navn: {p.name} Månedsløn: {p.salaryPerMonth}");
            }

            Worker arbejdsmand1 = new Worker("Handymand", "Jesper", 201);
            arbejdsmand1.SetSkill("Stillandsarbejder");
            arbejdsmand1.name = "fff";

            ansatte.Add(arbejdsmand1);

            Manager minManager = new Manager(500, "Peter", 450);
            minManager.HoursWorked = 150;
            Console.WriteLine($"Hours worked: {minManager.HoursWorked} Salary: {minManager.GetSalaryPerMonth()}");
            minManager.HoursWorked = 180;

            ansatte.Add(minManager);

            Console.WriteLine($"Hours worked: {minManager.HoursWorked} Salary: {minManager.GetSalaryPerMonth()}");

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
