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

            //Maybe use a 2D array later?
            //string[,] screenArray;

            SetUpScreen( ref score);

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

            PacmanOut();

            //Not a good idea
            Console.WriteLine($"                         Score: {score}                       ");
            Console.WriteLine("                                                               ");
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine("|                              █                              |");
            Console.WriteLine("| ■■■■■■■■ ■■■■■■              █               _____    __    |");
            Console.WriteLine("|                              █              |_____|  |__|   |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|____                                                     ____|");
            Console.WriteLine("                                                               ");
            Console.WriteLine(" ____                                                     ____ ");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|_____________________________________________________________|");


        }

        static void PacmanOut()
        {

            Console.WriteLine(@"                                                              _____           ");
            Console.WriteLine(@"                                                          ,-~       ~-.       ");
            Console.WriteLine(@"                                                        ,^ ___     ___ ^.     ");
            Console.WriteLine(@"                                                       / .^   ^. .^   ^. \    ");
            Console.WriteLine(@"                                                      Y  l    O! l    O!  Y   ");
            Console.WriteLine(@" _ __   __ _  ___ _ __ ___   __ _ _ __                l_ `.___.' `.___.' _[   ");
            Console.WriteLine(@"| '_ \ / _` |/ __| '_ ` _ \ / _` | '_ \               l^~ ------------ -~^I   ");
            Console.WriteLine(@"| |_) | (_| | (__| | | | | | (_| | | | |              !\,               ,/!   ");
            Console.WriteLine(@"| .__/ \__,_|\___|_| |_| |_|\__,_|_| |_|               \ ~-.,_______,.-~ /    ");
            Console.WriteLine(@"| |                                                     ^.             .^     ");
            Console.WriteLine(@"|_|                                                        -.._____., -       ");
















        }
    }
}
