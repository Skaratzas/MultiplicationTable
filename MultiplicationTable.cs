using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Give a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool exit = true;

            do
            {
                bool flag = true;
                int randomNum = random.Next(1, 10);
                while (flag)
                {
<<<<<<< HEAD

                    Console.Write(+ randomNum + " * " + num + " = ");
                    String answer = Console.ReadLine();
                    if(answer == "exit")
                    {
                        exit = false;
                        flag = false;
                        Console.WriteLine("Well done, we are done for today!");
                    }
                    else if (Convert.ToInt32(answer) == (randomNum * num))
=======
                    Console.Write(+ i + " * " + num + " = ");
                    int answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == (i * num))
>>>>>>> f072063c896f314131930094d6637c0ce340e662
                    {
                        Console.WriteLine("Well done!");
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("Try again");
                    }

                }
<<<<<<< HEAD
            } while (exit);

=======
            }
>>>>>>> f072063c896f314131930094d6637c0ce340e662
            Console.ReadLine();
        }
    }
}

