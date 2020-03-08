using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert first Number");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numbers befor swaping num1={num1}, num2={num2}");

            num1 = num1 * num2;
            num2 = num1 / num2;
            num1 = num1 / num2;
            Console.WriteLine("After Swaping :");
            Console.WriteLine($"num1={num1}, num2={num2}");


            Console.ReadLine();
        }
    }
}
