using System;

namespace HelloApp
{
    class Compare
    {
        public void Method()
        {
            int num1, num2;
            Console.WriteLine("Enter first number\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nEnter Second number\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2)
            {
                Console.Write("num1 is less than num2\t");
            }

            else if (num1 == num2)
            {
                Console.Write("num1 is equal to num2\t");
            }

            else
            {
                Console.Write("num1 is more than num2\t");
            }

            Console.ReadKey();


        }
    }
}