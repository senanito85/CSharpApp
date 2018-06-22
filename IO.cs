using System;


namespace HelloApp
{
    class IO
    { 
        public void Arthmetic()
        {
            int num1, num2;
            int add, sub, mul;
            float div;

            Console.Write("Enter first number\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nEnter second number\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            // '+' operator for adding
            add = num1 + num2;
            // '-'
            sub = num1 - num2;
            // '*'
            mul = num1 * num2;
            // '/'
            div = num1 / num2;

            //Displaying Output
            Console.WriteLine("Addition\t\t{0}", add);
            Console.WriteLine("Subtraction\t\t{0}", sub);
            Console.WriteLine("Multiplication\t\t{0}", mul);
            Console.WriteLine("Division\t\t{0}", div);
            //Console.ReadKey();


        }
    }
}
