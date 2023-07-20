using System;
using System.Threading;

namespace Cronometro
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("Hello, I'm Marcella! \r\nThis is a stopwatch with C# \r\n");

            Menu();
        }

        static void Start(int time, char type)
        {
            const int ONE_SECOND = 1000;
            const int ONE_MINUTE = 60 * 1000;
            int currentTime = 0;
            int timeToSleep = 0;

            if (type == char.Parse("m"))
            {
                timeToSleep = time * ONE_MINUTE;
            }
            else
            {
                timeToSleep = time * ONE_SECOND;
            }
            Console.WriteLine(timeToSleep);

            while (currentTime != time)
            {
                currentTime++;
                Console.Clear();
                Console.WriteLine(currentTime);
                Thread.Sleep(timeToSleep);
            }
            Console.Clear();
            Console.WriteLine("Your time it's over!|\r\n");

            Menu();
        }

        static void Menu()
        {
            try
            {
                Console.WriteLine("S = Seconds --> 10s \r\nM = Minutes --> 10m |\r\n0 = Exit");
                Console.WriteLine("How much time do you need?");
                string data = Console.ReadLine().ToLower();
                while (data == "")
                {
                    data = Console.ReadLine().ToLower();
                }

                if (data.Equals("0"))
                {
                    Environment.Exit(0);
                }

                char typeOfTime = char.Parse(data.Substring(data.Length - 1, 1));
                int time = int.Parse(data.Substring(0, data.Length - 1));

                Start(time, typeOfTime);
            }
            catch
            {
                Console.Error.WriteLine("\r\nError: Program finished \r\nPlease, check if the data has been entered correctly.");
            }
        }
    }
}
// See https://aka.ms/new-console-template for more information
