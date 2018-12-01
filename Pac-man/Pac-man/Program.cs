using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pac_man
{
    class Program
    {

        static void Main(string[] args)
        {
            int score = 0;

            SetUpScreen(ref score);

            Console.ReadLine();
        }

        static void NewGame()
        {
            //call screen setup here and reset score etc.
        }

        static void SetUpScreen(ref int score)
        {
            //16 tabs long
            //score at the top
            Console.WriteLine($"                    Score: {score}                          ");
            Console.WriteLine("                                                             ");
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|_____________________________________________________________|");
        }
    }
}
