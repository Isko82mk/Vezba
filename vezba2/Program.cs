using System;

namespace vezba2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
         

            Console.WriteLine("Enter first num");
            double doublefirst = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second num");
            double doubleSecond = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter third num");
            double doubleThird = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter forth num");
            double doubleForth = Convert.ToDouble(Console.ReadLine());

            double averageNumber = (doublefirst + doubleSecond + doubleForth + doubleThird) / 4;

            Console.WriteLine( $"The average number is => {averageNumber}");
            Console.ReadLine();



        }
    }
}
