using System;

namespace HelloApp
{
    class Menu
    {
        public void method()
        {
            bool con = true;
            while (con)
            {
                try
                {
                    Console.Write("===================");
                    Console.Write("\n1. Create the name");
                    Console.Write("\n2. Addition");
                    Console.Write("\n3. Calculation");
                    Console.Write("\n4. Comparsion");
                    Console.Write("\n5. Show the Path");
                    Console.Write("\n6. Exit");
                    Console.Write("\nPlease Enter the Menu Number\n");
                    int num = int.Parse(Console.ReadLine());

                    switch (num)
                    {
                        case 1:
                            Name name = new Name();
                            name.Method();
                            //Console.ReadKey();
                            break;

                        case 2:
                            Console.WriteLine("Please Enter Your Number One");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please Enter Your Number Two");
                            int y = int.Parse(Console.ReadLine());

                            int z = x + y;
                            Console.WriteLine("Numbers are \nNo1:{0} \nNo2:{1} \nThe Sum is {2}", x, y, z);
                            break;

                        case 3:
                            Console.WriteLine("\nNow this is the Arthmetic Caculation.\nEnter two numbers:");
                            IO io = new IO();
                            io.Arthmetic();
                            break;

                        case 4:
                            Console.WriteLine("\nNow this is the Comparation.\nEnter two numbers:");
                            Compare compare = new Compare();
                            compare.Method();
                            break;

                        case 5:
                            string path = @"C:\Users\Professional\Desktop\picture.jpg";
                            Console.WriteLine(path);
                            //Console.ReadKey();  //222
                            break;

                        case 6:
                            con = false;
                            Console.WriteLine("Good Bye");
                            //Console.ReadKey();
                            break;


                        default:
                            Console.WriteLine("Please Enter the Valiad Value");
                            //Console.ReadKey();
                            break;
                    }

                }catch (FormatException e)
                 {
                    throw new FormatException("Error....", e);
                 }
            }
        }


    }
}
