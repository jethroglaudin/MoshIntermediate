using System;

namespace StopWatch
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("STOPWATCH APP");
            Console.WriteLine("Press Enter to start and stop the Stop Watch!");

            var stopWatch = new StopWatch();

            while (true)
            {
                var userInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    stopWatch.Start();
                    Console.ReadLine();
                    stopWatch.Stop();

                    Console.WriteLine("Duration: {0}:{1}:{2}:{3}", stopWatch.GetTime().Hours, stopWatch.GetTime().Minutes, stopWatch.GetTime().Seconds, stopWatch.GetTime().Milliseconds);

                    continue;

                }

                break;
            }


        }
    }
}
