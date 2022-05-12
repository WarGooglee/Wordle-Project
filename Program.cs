using System;
using System.Collections.Generic;
using System.IO;

namespace Wordle_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fsr = new FileStream(@".\words.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsr);

            List<string> Words = new List<string>();
            string line = sr.ReadLine();
            while(line != null)
            {
                Words.Add(line);
                line = sr.ReadLine();
            }
            
            //Random Number Gen
            Random numberGen = new Random();

            int random = 0;
            //Game Start
            Console.WriteLine("Start the game? Yes or no to proceed.");
            string answer = Console.ReadLine().ToUpper();

            if(answer == "YES")
            {
                //Choosing word from list
                random = numberGen.Next(0, 163);
                string theWord = (Words[random]);
                Console.WriteLine("Type your first guess (lowercase only)");

                //Game loop
                for (int i = 0; i < 6; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    string guess = Convert.ToString(Console.ReadLine().ToLower());

                    char a = theWord[0];
                    char b = theWord[1];
                    char c = theWord[2];
                    char d = theWord[3];
                    char e = theWord[4];

                    char aa = guess[0];
                    char bb = guess[1];
                    char cc = guess[2];
                    char dd = guess[3];
                    char ee = guess[4];

                    if (a == aa)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(aa);
                    }
                    else if (!theWord.Contains(aa))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(aa);
                    }
                    else if (theWord.Contains(aa) && (b == aa || c == aa || d == aa || e == aa))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(aa);
                    }

                    if (b == bb)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(bb);
                    }
                    else if (!theWord.Contains(bb))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(bb);
                    }
                    else if (theWord.Contains(bb) && (a == bb || c == bb || d == bb || e == bb))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(bb);
                    }

                    if (c == cc)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(cc);
                    }
                    else if (!theWord.Contains(cc))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(cc);
                    }
                    else if (theWord.Contains(cc) && (b == cc || a == cc || d == cc || e == cc))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(cc);
                    }

                    if (d == dd)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(dd);
                    }
                    else if (!theWord.Contains(dd))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(dd);
                    }
                    else if (theWord.Contains(dd) && (b == dd || c == dd || a == dd || e == dd))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(dd);
                    }

                    if (e == ee)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(ee);

                    }
                    else if (!theWord.Contains(ee))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ee);

                    }
                    else if (theWord.Contains(ee) && (b == ee || c == ee || d == ee || a == ee))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(ee);

                    }

                    if (guess == theWord)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("You did it!");
                        i = 999;
                    }

                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The Word Was: " + theWord);
            }

            else if(answer == "NO")
            {
                Console.WriteLine("End of game..");
            }
        }

    }
}
