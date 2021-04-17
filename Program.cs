using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LAB2 \n Given two numbers, return true if the sum of both numbers is less than 100. Otherwise return false.");
           

            int num1;
            int num2;
            bool result1 = true; 
            bool result2 = false;

            Console.WriteLine("Enter first number ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            if(num1 + num2 < 100)
            {
                 Console.WriteLine(result1);
            }
            else
            {
                Console.WriteLine(result2);
            }


        }
    }
}
