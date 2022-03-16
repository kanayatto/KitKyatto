using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Octokit.Reactive;

namespace KitKyatto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            othermainthingy();
        }
        static void othermainthingy()
        {
            async_stuff asyncstuff = new async_stuff();
            asyncstuff.uwu();
            Thread.Sleep(5000);
            uwu();
        }

        static void uwu()
        {
            async_stuff asyncstuff = new async_stuff();

            Console.WriteLine("\n \nDo you want to search another user?");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            var search = Console.ReadLine();
            if (search == "yes")
            {
                othermainthingy();
            }
            else if (search == "Yes")
            {
                asyncstuff.uwu();
            }
            else if (search == "no")
            {
                Console.WriteLine("exiting");
                Environment.Exit(1);
            }
            else if (search == "No")
            {
                Console.WriteLine("exiting");
                Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Invalid response");
                uwu();
            }
        }
    }
}
