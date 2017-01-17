using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RandomOutputSoccerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Menu();
        }

        private void Menu()
        {
            int menuOpen = 1;

            try
            {
                while (menuOpen == 1)
                {
                    Console.Clear();
                    Console.WriteLine("====================");
                    Console.WriteLine("= EAL SOCCER MANAGER =");
                    Console.WriteLine("====================");
                    Console.WriteLine("=== MONEY: $205 ===");
                    Console.WriteLine("====================");
                    Console.WriteLine("<1> - PLAY MATCH");
                    Console.WriteLine("<2> - BUY PACKS");
                    Console.WriteLine("<3> - TEAM MANAGEMENT");
                    Console.WriteLine("<4> - TABLE");
                    Console.WriteLine("====================");
                    Console.WriteLine("<0> - EXIT");
                    //var endresult = Console.ReadLine();
                    var endresult = Console.ReadKey().Key;

                    switch (endresult)
                    {
                        case ConsoleKey.D0:
                            menuOpen = 0;

                            break;
                        case ConsoleKey.D1:
                            Console.Clear();
                            Console.WriteLine("====================");
                            Console.WriteLine("==== PLAY MATCH ====");
                            Console.WriteLine("====================");
                            Console.WriteLine("<1> - PLAY NEXT MATCH");
                            Console.WriteLine("<2> - PLAY TOURNAMENT");
                            Console.WriteLine("<3> - PLAY CUP");
                            Console.WriteLine("====================");
                            Console.WriteLine("Press any key to return to main menu");
                            Console.ReadKey();
                            break;
                        case ConsoleKey.D2:
                            Console.Clear();
                            Console.WriteLine("====================");
                            Console.WriteLine("==== BUY PACKS ====");
                            Console.WriteLine("====================");
                            Console.WriteLine("<1> - BUY 3-PLAYER PACK - $100");
                            Console.WriteLine("====================");
                            Console.WriteLine("Press any key to return to main menu");

                            var endresult2 = Console.ReadKey().Key;

                            if (endresult2 != ConsoleKey.D1)
                            {
                                Menu();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                Console.WriteLine("====================");
                                Console.WriteLine("=== OPENING PACK ===");
                                Console.WriteLine("====================");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Thread.Sleep(500);
                                Console.WriteLine("#1 - Cavani E (Rating: 82) [PSG] (URU)");
                                Thread.Sleep(500);
                                Console.WriteLine("#2 - Lacazette A (Rating: 78) [Lyon] (FRA)");
                                Thread.Sleep(500);
                                Console.WriteLine("#3 - Waris M (Rating: 73) [Lorient] (GHA)");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("====================");
                                Console.WriteLine("NEW BALANCE: $105");
                                Console.WriteLine("====================");
                                Console.WriteLine("Press any key to return to main menu");

                                Console.ReadLine();
                            }

                            break;

                        default:
                            Menu();
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                //
            }
            finally
            {
                //
            }
        }

        private void GenerateNewMatch(string team1, string team2)
        {
            Random Rnd = new Random();
            int teamscoreone = Rnd.Next(0, 5);
            int teamscoretwo = Rnd.Next(0, 5);
            List<string> list = new List<string>();
            list.Add("Steven Gerrard");
            list.Add("Coutinho");
            if (teamscoreone == teamscoretwo)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("========");
                Console.WriteLine("NEW MATCH");
                Console.WriteLine("{0} vs {1}", team1, team2);
                Console.WriteLine("========");
                Console.WriteLine("FINAL RESULT:");
                Console.WriteLine("{0} - {1}", teamscoreone, teamscoretwo);
                Console.WriteLine("========");
                for (int i = 0; i < teamscoreone; i++)
                {
                    int minutes = Rnd.Next(1, 91);
                    Console.WriteLine("'" + minutes + " - Goal for " + team1);
                }
                for (int i = 0; i < teamscoretwo; i++)
                {
                    int minutes = Rnd.Next(1, 91);
                    Console.WriteLine("'" + minutes + " - Goal for " + team2);
                }
            }
            if (teamscoreone > teamscoretwo)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("========");
                Console.WriteLine("NEW MATCH");
                Console.WriteLine("{0} vs {1}", team1, team2);
                Console.WriteLine("========");
                Console.WriteLine("FINAL RESULT:");
                Console.WriteLine("{0} - {1}", teamscoreone, teamscoretwo);
                Console.WriteLine("========");
                for (int i = 0; i < teamscoreone; i++)
                {
                    int minutes = Rnd.Next(1, 91);
                    Console.WriteLine("'" + minutes + " - Goal for " + team1);
                }
                for (int i = 0; i < teamscoretwo; i++)
                {
                    int minutes = Rnd.Next(1, 91);
                    Console.WriteLine("'" + minutes + " - Goal for " + team2);
                }
            }
            if (teamscoreone < teamscoretwo)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("========");
                Console.WriteLine("NEW MATCH");
                Console.WriteLine("{0} vs {1}", team1, team2);
                Console.WriteLine("========");
                Console.WriteLine("FINAL RESULT:");
                Console.WriteLine("{0} - {1}", teamscoreone, teamscoretwo);
                Console.WriteLine("========");
                for (int i = 0; i < teamscoreone; i++)
                {
                    int minutes = Rnd.Next(1, 95);
                    Console.WriteLine("'" + minutes + " - Goal for " + team1);
                }
                for (int i = 0; i < teamscoretwo; i++)
                {
                    int minutes = Rnd.Next(1, 95);
                    Console.WriteLine("'" + minutes + " - Goal for " + team2);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}

