using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Both single-selection and while statements have to figure out is something is true or false. Contrarily, a single-selection only does what is being asked of the program, while a while loop keeps executing over and over until the loop is terminated.

            int speedLimit;
            int speed;

            speedLimit = 35;
            speed = 42;

            if (speed > speedLimit)
                Console.Write("SLOW NOW");

            int istrue = 10;

            if (istrue <= 60)
                Console.WriteLine("It is True");
            else
                Console.WriteLine("It is False");


            {
                Console.WriteLine("Input Temperature in Fahrenheit:");

                double fahrenheit = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                double Celsius = (fahrenheit - 32d) * 5d / 9d;

                Console.WriteLine("Temperature in Celsius is {0}:", Celsius);

                Console.ReadLine();

                if (fahrenheit >= 90)

                    Console.WriteLine("It is hot");

                if (fahrenheit <= 40)
                {

                    int i = 1;

                    while (i < 11)
                    {
                        Console.Write("While Output:");
                        Console.WriteLine(i);
                        i++;
                    }

                    int x = 60;

                    while (x >= 20)
                    {
                        Console.Write("While Output:");
                        Console.WriteLine(i);
                        i--;
                    }

                    int y = 10;

                    while (y <= 20)
                    {
                        Console.Write("While Output:");
                        Console.WriteLine(i);
                        i++;
                    }
                }
            }
        }
    }
}


