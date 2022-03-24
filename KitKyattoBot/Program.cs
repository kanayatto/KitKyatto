using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitKyatto;
using KitKyattoBot;

namespace KitKyattoBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static async void Start()
        {
            Discord_Client_Stuffs discord = new Discord_Client_Stuffs();
            Console.WriteLine("Start?\nType 'y' to start or type 'n' to exit..");
            string startkey = Console.ReadLine();
            if(startkey == null)
            {
                Console.WriteLine("Invalid");
                Console.Clear();
                Start();
            }
            else if(startkey == "y")
            {
                await discord.Main();
            }
            else if (startkey == "n")
            {
                Environment.Exit(1);
            }
        }
    }
}
