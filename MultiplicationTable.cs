using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number: ");
            int num = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= 10; i++)
            {
                bool flag = true;
                while (flag)
                {
                    Console.Write(+i + " * " + num + " = ");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == (i * num))
                    {
                        Console.WriteLine("Well done!");
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }

                }
            }

            Console.ReadLine();


        }
    }
}

