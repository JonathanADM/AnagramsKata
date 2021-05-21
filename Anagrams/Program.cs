using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            ManageFile manageFile = new ManageFile();
            ManageAnagrams manageAnagrams = new ManageAnagrams();
            
            Stopwatch timer = new Stopwatch();
            timer.Start();

            manageFile.GetPath(args);

            timer.Stop();
            Console.WriteLine($"Cantidad de tiempo: {timer.Elapsed}");
        }
    }
}
