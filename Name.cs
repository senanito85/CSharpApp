using System;


namespace HelloApp
{
    class Name
    {
        public void Method()
        {
            Console.WriteLine("Please Enter Your Family Name");
            string name1 = Console.ReadLine();
            Console.WriteLine("Please Enter Your Given Name");
            string name2 = Console.ReadLine();
            //Console.WriteLine("Your name is " + name2 + " " + name1);
            //Console.WriteLine("Your name is {0} {1}", name2,name1);

            Console.WriteLine("Your name: {0} {1}", name2, name1);
        }
    }
}