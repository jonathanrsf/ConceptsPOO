using System;

namespace ConceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new SalaryEmployee()
            {
                Id = 1010,
                FirstName = "Jr",
                LastName = "Sf",
                BirthDate = new Date(1990, 2, 8),
                HiringDate = new Date(2020, 5, 9),
                IsActive= true,
                Salary = 4235.89M
            };
            Employee employee2 = new CommissionEmployee()
            {
                Id = 1011,
                FirstName = "La",
                LastName = "Oc",
                BirthDate = new Date(1992, 2, 8),
                HiringDate = new Date(2021, 5, 9),
                IsActive = true,
                CommissionPercentaje = 0.03f,
                Sales = 122000M                
            };

            Console.WriteLine(employee1);
            Console.WriteLine(employee2);


        }
    }
}
