﻿using System;
using System.Threading;

namespace StaticConstructor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // The creation of this instance activates the static constructor.
            Bus bus1 = new Bus(71);

            // Create a second bus.
            Bus bus2 = new Bus(72);

            // Send bus1 on its way.
            bus1.Drive();

            // Wait for bus2 to warm up.
            Thread.Sleep(10000);

            // Send bus2 on its way.
            bus2.Drive();

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
/* Sample output:
    Static constructor sets global start time to 3:57:08 PM.
    Bus #71 is created.
    Bus #72 is created.
    71 is starting its route 6.00 minutes after global start time 3:57 PM.
    72 is starting its route 31.00 minutes after global start time 3:57 PM.
*/