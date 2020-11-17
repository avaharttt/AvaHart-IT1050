using System;

namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
                if ((i % 2) == 0) //even
                {
                    Console.WriteLine(i);

                }
            int a = Convert.ToInt32(Console.ReadLine());
            {
                Console.WriteLine("Please enter a temperature.");
                if (a <= 10)
                {
                    Console.WriteLine("Polar Bear");
                }
                else if (a <= 20)
                {
                    Console.WriteLine("Penguin");
                }
                else if (a <= 40)
                {
                    Console.WriteLine("Moose");
                }
                else if (a <= 50)
                {
                    Console.WriteLine("Reindeer");

                }
                else if (a <= 60)
                {
                    Console.WriteLine("Deer");
                }
                else if (a <= 70)
                {
                    Console.WriteLine("Turtle");
                }
                else if (a <= 80)
                {
                    Console.WriteLine("Lion");
                }
                else if (a <= 90)
                {
                    Console.WriteLine("Fish");
                }
                else (a <= 100)
                        {
                    Console.WriteLine("Bug");//default
                }
                int i = 10;
                while (i < 21)
                {
                    i++;
                    Console.WriteLine(i);
                }
                for (int x = 0; x < 101; x++)
                {
                    Console.WriteLine(x);
                    Console.WriteLine("********");
                }
            }
        }
    }
}


// A counter controlled repetition includes a control variable, an inital value, an increment/decrement, and a loop-continuation condition
// For repition statements specify elements in a single line of code, whereas a while statement is executed repeatedly.
// Do while is useful when you want to execute soemthing just once, instead of continuously.