using System;
using System.Collections.Generic;

namespace ConceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new SalaryEmployee()
            {
                Id = 1011,
                FirstName = "Jr",
                LastName = "Sf",
                BirthDate = new Date(1990, 2, 8),
                HiringDate = new Date(2020, 5, 9),
                IsActive= true,
                Salary = 4235.89M
            };
            Employee employee2 = new CommissionEmployee()
            {
                Id = 1012,
                FirstName = "La",
                LastName = "Oc",
                BirthDate = new Date(1992, 2, 8),
                HiringDate = new Date(2021, 5, 9),
                IsActive = true,
                CommissionPercentaje = 0.037f,
                Sales = 122000M                
            };
            Employee employee3 = new HourlyEmployee()
            {
                Id = 1013,
                FirstName = "Churri@",
                LastName = "Bonit@",
                BirthDate = new Date(2022, 08, 12),
                HiringDate = new Date(2023, 08, 15),
                IsActive = true,
                Hours = 120,
                HourValue = 12
            };
            Employee employee4 = new BaseCommissionEmployee()
            {
                Id = 1014,
                FirstName = "La1",
                LastName = "Oc1",
                BirthDate = new Date(1992, 2, 8),
                HiringDate = new Date(2021, 5, 9),
                IsActive = true,                
                Base = 9000M,
                CommissionPercentaje = 0.015f,
                Sales = 102000M,
            };

            ICollection<Employee> employees = new List<Employee>()
            { employee1, employee2, employee3, employee4 };

            decimal payroll = 0;
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
                payroll += employee.GetValueToPay();
            }
            Console.WriteLine("                                ===================");
            Console.WriteLine($"TOTAL                          {$"{payroll:C2}", 20}");

            //Console.WriteLine(employee1);
            //Console.WriteLine(employee2);
            //Console.WriteLine(employee3);
            //Console.WriteLine(employee4);
            Invoice invoice1 = new Invoice()
            {
                Id = 1,
                Description = "Xiaomi Mi9",
                Price = 2230M,
                Quantity = 5
            };
            Invoice invoice2 = new Invoice()
            {
                Id = 2,
                Description = "Chuleton",
                Price = 130M,
                Quantity = 4.7f
            };
            Console.WriteLine(invoice1);
            Console.WriteLine(invoice2);


        }
    }
}
