using System;
namespace HMW_Design_Patterns
{
    public class Clock
    {
        private Clock()
        {
        }

        private static Clock newClock;
        private readonly static object key = new object();

        public static Clock GetClock()
        {
            if (newClock == null)
            {
                lock (key)
                {
                    if (newClock == null)
                    {
                        newClock = new Clock();
                    }
                }

            }
            return newClock;
        }


        public void GetTime()
        {
            Console.WriteLine("Current Time Is: " + DateTime.Now.Hour);
        }

    }
}
