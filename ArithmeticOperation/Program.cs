using System;

namespace ArithmeticOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator: ");
            string opt = Console.ReadLine();

            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (opt == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (opt == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (opt == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (opt == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }


            //Console.WriteLine("Hello World!");
        }
    }
}
