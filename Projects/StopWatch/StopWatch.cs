using System;
using System.Collections.Generic;
namespace StopWatch
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private TimeSpan _duration;
        private bool isRunning;

        public void Start()
        {
            try
            {
                Console.WriteLine("Timer is running");

                _startTime = DateTime.UtcNow;
                isRunning = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Stopwatch is already running", ex);
            }
        }

        public void Stop()
        {
            try
            {
                _stopTime = DateTime.UtcNow;
                isRunning = false;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Stopwatch is not running", ex);
            }
        }

        public TimeSpan GetTime()
        {
            _duration = _stopTime - _startTime;
            return _duration;
        }
    }

   

    
}
