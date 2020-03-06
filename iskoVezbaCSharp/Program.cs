using System;

namespace iskoVezbaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

  
            string num1, num2, oper;

            Console.WriteLine("Enter first num");
            num1 = Console.ReadLine();
            double doubleNum1 = Convert.ToDouble(num1);

            Console.WriteLine("Enter operator(+-*/)");
            oper = Console.ReadLine();


            Console.WriteLine("Enter sec num");
            num2 = Console.ReadLine();
            double doubleNum2 = Convert.ToDouble(num2);

            if (oper == "+") Console.WriteLine($" The result is => {doubleNum1 + doubleNum2}");
            if (oper == "-") Console.WriteLine($" The result is => {doubleNum1 - doubleNum2}");
            if (oper == "*") Console.WriteLine($" The result is => {doubleNum1 * doubleNum2}");
            if (oper == "/") Console.WriteLine($" The result is => {doubleNum1 / doubleNum2}");


            Console.ReadLine();


        }
    }
}
