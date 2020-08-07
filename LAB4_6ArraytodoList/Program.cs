using System;
using System.Collections.Generic;

namespace LAB4_6ArraytodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] Task = new string[7];
            for (int i = 0; i < Days.Length; i++)
            {
                Console.WriteLine("Type a new Task for " + Days[i]);
                Task[i] = Days[i] + " : " + Console.ReadLine();

            }

            for (int i = 0; i < Days.Length; i++)
            {
                Console.WriteLine(Task[i]);

            }

        }

    }
}
