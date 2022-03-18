using System;

namespace ConceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Date date1 = new Date(2024, 2, 29);
                Console.WriteLine(date1);
            }
            catch (Exception error)
            {

                Console.WriteLine(error.Message);
            }

            
        }
    }
}
