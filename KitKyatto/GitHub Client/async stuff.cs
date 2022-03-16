using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;

namespace KitKyatto
{
    class async_stuff
    {
        
        public async void uwu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            var client = new GitHubClient(new ProductHeaderValue("uwu"));
            var creds = new Credentials("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");
            client.Credentials = creds;
            Console.Clear();
            Console.WriteLine("Enter The Username You Want To Search");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            var search = Console.ReadLine();
            var user = await client.User.Get(search);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0} has {1} public repositories", search, user.PublicRepos);
            Console.WriteLine("\n\n" + search + " Has " + user.Followers + " Followers");
            Console.WriteLine("\n\n" + search + " Is Following " + user.Following + " Users");
            Console.WriteLine("\n\n" + search + "'s Bio: " + user.Bio);
            Console.WriteLine("\n\n" + search + "'s Account was created at " + user.CreatedAt.DateTime);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
