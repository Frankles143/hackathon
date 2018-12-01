using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Pac_man
{
    class Program
    {
        //Delcare variables - attemot to ignore they're global
        static string[,] screenArray;
        static int score = 0;
        static bool gameRunning = false;

        static void Main(string[] args)
        {
            //Create 2D array for the grid
            screenArray = new string[18,36]
            {
                {"_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_","_"},
                {"|"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","█"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"},
                {"|"," ","■","■","■","■","■","■","■","■"," ","■","■","■","█","█","█","█","█","█","█","■","■","■"," "," ","■","■","■","■","■","■","■","■"," ","|"},
                {"|"," "," "," "," "," "," "," "," "," "," "," "," "," ","█","█","█","█","█","█","█"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"},
                {"|"," ","■","■","■","■","■","■","■","■","■"," ","█"," "," "," "," "," "," "," "," "," ","█"," ","■","■","■","■","■","■","■","■","■","■"," ","|"},
                {"|"," "," "," "," "," "," "," "," "," "," "," ","█"," ","■","■","■","■","■","■","■"," ","█"," "," "," "," "," "," "," "," "," "," "," "," ","|"},
                {"¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","|"," ","█"," "," "," "," ","█"," "," "," "," ","█"," ","|","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯"},
                {"_","_","_","_","_","_","_","_","_","_","|"," ","█","■","■","■"," ","█"," ","■","■","■","█"," ","|","_","_","_","_","_","_","_","_","_","_","_"},
                {"|"," "," "," "," "," "," "," "," "," "," "," ","█"," "," "," "," "," "," "," "," "," ","█"," "," "," "," "," "," "," "," "," "," "," "," ","|"},
                {"|"," "," "," "," "," "," "," "," "," "," "," "," "," ","█","■","■","-","■","■","█"," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"},
                {"¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","|"," ","█"," ","█"," "," "," "," "," ","█"," ","█"," ","|","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯"},
                {"_","_","_","_","_","_","_","_","_","_","|"," ","█"," ","█","■","■","■","■","■","█"," ","█"," ","|","_","_","_","_","_","_","_","_","_","_","_"},
                {"|"," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," "," ","|"},
                {"|"," ","■","■","■","■","■","■","■","■","■","■"," ","█","■","■","■"," ","■","■","■","█"," ","■","■","■","■","■","■","■","■","■","■","■"," ","|"},
                {"|"," "," "," "," "," "," "," "," "," "," "," "," ","█"," "," "," "," "," "," "," ","█"," "," "," "," "," "," "," "," "," "," "," "," "," ","|"},
                {"|"," "," "," "," "," "," "," "," "," "," "," "," ","█"," "," "," "," "," "," "," ","█"," "," "," "," "," "," "," "," "," "," "," "," "," ","|"},
                {"|"," ","■","■","■","■","■","■","■","■","■","■"," "," "," ","■","■","■","■","■"," "," "," ","■","■","■","■","■","■","■","■","■","■","■"," ","|"},
                {"¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯","¯"},
            };

            //Call method to call every other method
            NewGame(ref score, ref screenArray);

            //if (gameRunning == true)
            //{
            //    Timer t = new Timer(TimerCallback, null, 0, 1000);
            //}

            Console.ReadLine();
        }

        static void NewGame(ref int score, ref string[,] screenArray)
        {
            int playerX = 17, playerY = 32;
            string keyInputString;

            //Using consoleKeyInfo to find keypress
            ConsoleKeyInfo keyInput;


            //call screen setup here and reset score etc
            score = 0;
            PacmanOut();
            Console.WriteLine("\nUse WASD or Arrow Keys keys to play, try to collect all the ¤");
            Console.WriteLine("\nGet ready to play! Please press enter to start a new game!");
            Console.ReadLine();
            Console.WriteLine("");
            //ScoreOut();
            SetUpScreen();
            gameRunning = true;

            //Set starting char
            Console.SetCursorPosition(playerX, playerY);
            Console.Write("Ö");

            Console.SetCursorPosition(0, 13);
            //If statement to check which key has been pressed
            while (gameRunning == true)
            {
                keyInput = Console.ReadKey();
                keyInputString = keyInput.Key.ToString();

                if (keyInputString == "W" || keyInputString == "A" || keyInputString == "S" || keyInputString == "D" || keyInputString == "LeftArrow" || keyInputString == "RightArrow" || keyInputString == "UpArrow" || keyInputString == "DownArrow")
                {               
                    Console.SetCursorPosition(0, 13);
                    MovePlayer(keyInputString, ref playerX, ref playerY);
                    ScoreOut();
                }
                else
                {
                    Console.Write("Please use arrow keys or WASD!                                           ");
                    
                }
                Console.SetCursorPosition(0, 13);
            }
        }

        static void MovePlayer(string inputChar, ref int playerX, ref int playerY)
        {
            if (inputChar == "W" || inputChar == "UpArrow")
            {
                Console.SetCursorPosition(playerX, playerY);
                Console.Write(" ");
                playerY--;
                if (CheckCollision(ref playerX, ref playerY) == false)
                {
                    playerY++;
                }
            }
            if (inputChar == "S" || inputChar == "DownArrow")
            {
                Console.SetCursorPosition(playerX, playerY);
                Console.Write(" ");
                playerY++;
                if (CheckCollision(ref playerX, ref playerY) == false)
                {
                    playerY--;
                }
            }
            if (inputChar == "A" || inputChar == "LeftArrow")
            {
                Console.SetCursorPosition(playerX, playerY);
                Console.Write(" ");
                playerX--;
                if (CheckCollision(ref playerX, ref playerY) == false)
                {
                    playerX++;
                }
            }
            if (inputChar == "D" || inputChar == "RightArrow")
            {
                Console.SetCursorPosition(playerX, playerY);
                Console.Write(" ");
                playerX++;
                if (CheckCollision(ref playerX, ref playerY) == false)
                {
                    playerX--;
                }
            }
            Console.SetCursorPosition(playerX, playerY);
            Console.Write("Ö");
            Console.SetCursorPosition(0,13);
        }

        static bool CheckCollision(ref int playerX, ref int playerY)
        {
            int playerYCorrect = playerY - 17;
            bool aWall = screenArray[playerYCorrect, playerX] == " ";
            bool aBall = screenArray[playerYCorrect, playerX] == "¤";
            if (aWall || aBall)
            {
                if (aBall == true)
                {
                    score++;
                }
                return true;
            }
            else
            {
                return false;
            }
            //Console.WriteLine(screenArray[playerX, playerYCorrect]);
            //Console.WriteLine($"{playerX}, {playerYCorrect}");
        }

        private static void TimerCallback(Object o)
        {
            SetUpScreen();

            // Force a garbage collection after each call
            GC.Collect();
        }

        static void ScoreOut()
        {
            Console.WriteLine($"            Score: {score}");
        }

        static void SetUpScreen()
        {
            //double for to output both x and y
            for (int rows = 0; rows < 18; rows++)
            {
                for (int cols = 0; cols < 36; cols++)
                {
                    if (screenArray[rows, cols] == " ")
                    {
                        screenArray[rows, cols] = "¤";
                    }
                    Console.Write(screenArray[rows,cols]);
                }
                Console.WriteLine();
            }

            //using: █ ■ _ - | Ö

            //          |
            //Original \ /

            //NOT A GOOD IDEA

            //Console.WriteLine($"           Score:                  ");
            //Console.WriteLine("                                    ");
            //Console.WriteLine("___________________________________ ");
            //Console.WriteLine("|                 █                |");
            //Console.WriteLine("| ■■■■■■■■ ■■■■███████■■■ ■■■■■■■■ |");
            //Console.WriteLine("|              ███████             |");
            //Console.WriteLine("| ■■■■■■■■■  █         █ ■■■■■■■■■ |");
            //Console.WriteLine("|            █ ■■■■■■■ █           |");
            //Console.WriteLine(" ¯¯¯¯¯¯¯¯¯¯| █    █    █ |¯¯¯¯¯¯¯¯¯¯"); 
            //Console.WriteLine("___________| █■■■ █ ■■■█ |__________"); 
            //Console.WriteLine("             █         █            "); 
            //Console.WriteLine("               █■■-■■█              "); 
            //Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯| █ █     █ █ |¯¯¯¯¯¯¯¯¯¯"); 
            //Console.WriteLine("___________| █ █■■■■■█ █ |__________"); 
            //Console.WriteLine("|                                  |"); 
            //Console.WriteLine("| ■■■■■■■■■■■ █■■■ ■■■█ ■■■■■■■■■■ |"); 
            //Console.WriteLine("|             █       █            |"); 
            //Console.WriteLine("| ■■■■■■■■■■■   ■■■■■   ■■■■■■■■■■ |"); 
            //Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");
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
