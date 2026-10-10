using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terra_Farm_Project
{
    internal class Encounters
    {
        //Encounters
        public static void Encounter1()
        {
            Console.WriteLine("You walk toward the door of an oddly shaped building that says house of magic on the side");
        }

        //Chemicals
        public Encounters() { }

        static void Main(string[] args)
        {
            while (true)
            {
                PlayOnce();

                // Ask to play again and require a clear Y/N response (case-insensitive)
                if (!PromptYesNo("Do you want to play again? Yes/No"))
                {
                    break; // exit the loop and end program
                }

                Console.Clear();
            }
        }

        private static void PlayOnce()
        {
            string playerName;
            int badEnding = 0;

            // start of the game
            Console.WriteLine("Hello friend");
            Console.WriteLine("What is your name?");
            playerName = Console.ReadLine();
            if (playerName == "")
            {
                Console.WriteLine("YOU KINDA HAVE TO PICK A NAME THERE, BUCKO");
                return;
            }
            Console.WriteLine($"Well...{playerName}, weird name but okay.");

            Console.WriteLine("We need you to make water for our village");
            Console.WriteLine("You are the person that was sent here for that, right?");
            Console.WriteLine("Yes/No"); // first choice of the game, if they say no, they get a bad ending
            if (ReadYes())
            {
                Console.WriteLine("Well of course you are, look at you");
                Console.WriteLine("Now hurry along to the lab");
                Console.WriteLine("Please press enter...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("You walk up to an oddly shaped building that says house of magic on the side of it");
                Console.WriteLine("You look at it weirdly but pay it no mind");
                Console.WriteLine("Do you want to walk in?");
                Console.WriteLine("Yes/No"); // second choice of the game, if they say no, they get a bad ending
                if (ReadYes())
                {
                    Console.WriteLine("You walk into the building and see a potrait of a man on the wall");
                    Console.WriteLine("You look at it and see that it is");
                    Console.WriteLine("");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You sit on the steps of the building and the town dies of thirst");
                    Console.WriteLine("You Were supposed to be the hero of the town, but you failed them");
                    Console.WriteLine("shame on you");
                    badEnding++;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Why are you dressed so weirdly then?");
                Console.WriteLine("Actually, just get out of here then!");
                badEnding++;
                Console.WriteLine("Please press enter and reset the game");
                Console.ReadLine();
            }
        }

        // Helper that asks a prompt and returns true for Yes, false for No.
        private static bool PromptYesNo(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                var input = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
                if (input == "y" || input == "yes") return true;
                if (input == "n" || input == "no") return false;
                Console.WriteLine("Please answer 'Yes' or 'No' (Y/N).");
            }
        }

        // Small convenience to reuse Yes/No read where prompt already printed
        private static bool ReadYes()
        {
            var input = (Console.ReadLine() ?? string.Empty).Trim().ToLowerInvariant();
            return input == "y" || input == "yes";
        }
    }
}