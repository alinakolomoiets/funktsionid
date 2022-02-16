using System;

namespace funktsionid
{
	class Program
	{
		static void Main(string[] args)
		{
            ConsoleKeyInfo click;
            do
            {
                int frequency = 1000;

                int duration = 200;
                Console.WriteLine("Vajuta mingi klahv!!");
                click = Console.ReadKey(true);
                Console.Beep(frequency, duration);
            } while (click.Key != ConsoleKey.Escape);
            Environment.Exit(0);

            ConsoleKeyInfo click1;
            do
            {
                int frequency = 3400;

                int duration = 200;
                Console.WriteLine("Vajuta mingi klahv!!");
                click1 = Console.ReadKey(true);
                Console.Beep(frequency, duration);
            } while (click1.Key != ConsoleKey.Escape);
            Environment.Exit(0);

            ConsoleKeyInfo click2;
            do
            {
                int frequency = 8000;

                int duration = 200;
                Console.WriteLine("Vajuta mingi klahv!!");
                click2 = Console.ReadKey(true);
                Console.Beep(frequency, duration);
            } while (click2.Key != ConsoleKey.Escape);
            Environment.Exit(0);

            ConsoleKeyInfo click3;
            do
            {
                int frequency = 6324;

                int duration = 200;
                Console.WriteLine("Vajuta mingi klahv!!");
                click3 = Console.ReadKey(true);
                Console.Beep(frequency, duration);
            } while (click3.Key != ConsoleKey.Escape);
            Environment.Exit(0);
        }
	}
}
