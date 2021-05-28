using System;
using System.Collections.Generic;
using course_csharp.Entities;
using System.Globalization;

namespace course_csharp
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();
            Console.WriteLine();
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine($"\nEMPLOYEE #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char osd = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (osd == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valueHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valueHour));
                }
            
            }
            Console.WriteLine();
            Console.Write("PAYMENTS: \n");
            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.Name}: R$ {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
