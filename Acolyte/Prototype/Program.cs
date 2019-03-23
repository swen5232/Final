using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var runningApps = Process.GetProcesses();
            List<Application> apps = new List<Application>();
            foreach (var app in runningApps)
            {
                apps.Add(new Application(app));
            }

            Console.WriteLine("This is a prototype for the Acolyte application");
            Console.WriteLine("For SWEN 5232, by Erik Whiting and Adriana Arzola");
            Console.WriteLine("The only functionality currently available is listing all running applications");
            Console.WriteLine("Please press 'a' and then 'Enter' to see all running applications");
            
            switch (Console.ReadLine())
            {
                case "a":
                    foreach (var app in apps)
                    {
                        Console.WriteLine(app.returnName());
                        Thread.Sleep(500);
                    }
                    break;
                default:
                    Console.WriteLine("I said press a, and you didn't. Application will now quit");
                    Thread.Sleep(2000);
                    break;
            }

        }
    }
}
