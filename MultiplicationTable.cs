using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=10; i++)
            {
                int result = i * num;
                Console.WriteLine(+ i + " * " + num + " = " + result);
            }


            Console.ReadLine();
        }
    }
}