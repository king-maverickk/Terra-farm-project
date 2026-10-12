using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Terra_Farm_Project
{
    
    internal class Encounters
    {
        private static int badEnding = 0;

        //Encounters
        public static readonly Dictionary<(string, string), string> Recipes = new Dictionary<(string, string), string>()
        {
            { ("Hydrogen", "Oxygen"), "Water" },
            { ("sodium", "Chlorine"), "salt" },
            { ("Water", "Carbon Dioxide"), "Carbonic acide" },
            { ("Sulfur", "Oxygen"), "Sulfur Dioxide" },
        };

        public static string CombinChems(string chemical1, string chemical2)
        {
            string chem1 = chemical1.Trim(); //Allows for uppercasing letters
            string chem2 = chemical2.Trim();

            string first = string.Compare(chem1, chem2, StringComparison.OrdinalIgnoreCase) < 0 ? chem1 : chem2;
            string second = first == chem1 ? chem1 : chem1; //makes so that ordering doesn't matter


            if (Recipes.TryGetValue((first, second), out string result )) // This gets the elements from the dictionary and compares if
            {
                return $"Success! combining{first} and {second} created {result}!";
            }
            return $"Fizzel... Combing {first} and {second} caused a little puff of grey smoke.";




        }

        //Chemicals
        public Encounters() { }

        static void Main(string[] args)
        {

            


            while (true)
            {
                PlayOnce();

                // Ask to play again and require a clear Y/N response (case-insensitive)
                if (!PromptYesNo($"Do you want to play again? Yes/No (Bad endings: {badEnding})"))
                    break; // exit the loop and end program

            }

                Console.Clear();
            }
        

        private static void PlayOnce()
        {
            string playerName;





            Console.Title = "Kudzi Studios - The K Game"; // stats the name of the game and the studio

            // Set Kudzi Studios to Blue
            Console.ForegroundColor = ConsoleColor.Blue;

            string kudziStudiosArt = @"
_              _     _         _            _ _ os 
 | |            | |   (_)       | |          | (_)   
 | | ___  _   _ | |___ _   ___| |_ _   _  __| |_ ___ 
 | |/ / | | |/ _` |_  / | / __| __| | | |/ _` | / _ \
 |   <| |_| | (_| |/ /| | \__ \ |_| |_| | (_| | | (_) |
 |_|\_\\__,_|\__,_/___|_| |___/\__|\__,_|\__,_|_|\___/
 ";

            Console.WriteLine(kudziStudiosArt);

            // Set The K Game to DarkBlue (or you can keep it Blue if you want them matching)
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            
            Task.Delay(1000).Wait();
            Console.Clear() ;
            Console.WriteLine("Presents..");
            Task.Delay(1000).Wait();
            Console.Clear() ;



            string theKGameArt = @"
  _______ _          _  __                              
 |__   __| |        | |/ /                              
    | |  | |__   ___| ' /    __ _  __ _ _ __ ___   ___  
    | |  | '_ \ / _ \  <    / _` |/ _` | '_ ` _ \ / _ \ 
    | |  | | | |  __/ . \  | (_| | (_| | | | | | |  __/ 
    |_|  |_| |_|\___|_|\_\  \__, |\__,_|_| |_| |_|\___| 
                             __/ |                      
                            |___/                       
";


            Console.WriteLine(theKGameArt);


            Console.ResetColor();
            Console.WriteLine("\nPress any key to start...");
            Console.ReadKey();
            Console.Clear();




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
                Console.WriteLine("You walk up to a massive and oddly shaped building that says ");
                Console.WriteLine("*********************************");
                Console.WriteLine("**                             **");
                Console.WriteLine("**  / \\  The house of   / \\    **");
                Console.WriteLine("**  | |       Magic     | |    **");
                Console.WriteLine("**                             **");
                Console.WriteLine("*********************************");
                Console.WriteLine("You look at it weirdly but pay it no mind");
                Console.WriteLine("Do you want to walk in?");
                Console.WriteLine("Yes/No"); // second choice of the game, if they say no, they get a bad ending
                if (ReadYes())
                {
                    
                    Console.WriteLine("You walk into the building and see a potrait of a man on the wall");
                    Console.WriteLine("He seems to be watching you, the portrait's line of site is directed at the door.");
                    Console.WriteLine("Do you want to approach the portrait?");
                    Console.WriteLine("Yes/No");
                    if (ReadYes())
                    {
                        Console.WriteLine("You walk up to the portrait and see that his name was Edward Elmore");
                        Console.WriteLine("He seems to be looking at you with a stern expression");
                        Console.WriteLine("Do you want to talk to him?");
                        Console.WriteLine("Yes/No");
                        if (ReadYes())
                        {
                            Console.WriteLine("You starting talking to it");
                            Console.WriteLine("The attendant standing behind you jugdes you and tells you to stop talking to it");
                            Console.WriteLine("She then tells you to follow her");
                            Console.WriteLine("do you want to?");
                            Console.WriteLine("Yes/No");
                            if (ReadYes())
                            {
                                Console.Clear();
                                Console.WriteLine("You follow the her and end up losing her along the way ");
                                Console.WriteLine("You get lost in the ever expanding haulways");
                                Console.WriteLine("you do not make it out.");
                                badEnding++;
                                Console.ReadLine();

                            }
                            else 
                            {
                                Console.Clear();
                                Console.WriteLine("You refuse to go with the her"); // first convo with the portraite
                                Console.WriteLine("She looks visuably annoyed and walks away");
                                Console.WriteLine("You go closer to the portrait and this time it starts talking to you");
                                Console.WriteLine("you are the one that was sent here to make this town prosperous");
                                Console.WriteLine("I was tasked with that same duty but I was umsuccessful.");
                                Console.WriteLine($"My dear child {playerName}");
                                Console.WriteLine("Please be careful in these halls. The stretch and turn and change.");
                                Console.WriteLine("Enough with the chit chat! let me show you to the postion room");
                                Console.WriteLine("please press enter to continue.");
                                Console.ReadLine();

                               



                            }
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("You ignore the man and start talking to the attendant that was waiting for you");
                            Console.WriteLine("You follow her and lose her");
                            Console.WriteLine("you are lost in the halls and don't make it out");
                            Console.WriteLine("please press enter to restart..."); // you get lot in the halls
                            Console.ReadLine();
                            badEnding++;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You ignore the man and start talking to the attendant that was waiting for you");
                        Console.WriteLine("You follow her and lose her");
                        Console.WriteLine("you are lost in the halls and don't make it out");
                        Console.WriteLine("please press enter to restart...");// you get lost in the halls
                        Console.ReadLine();
                        badEnding++;
                    }
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You sit on the steps of the building and the town dies of thirst");
                    Console.WriteLine("You Were supposed to be the hero of the town, but you failed them");
                    Console.WriteLine("shame on you"); // you don't enter the building
                    badEnding++;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Why are you dressed so weirdly then?"); // you don't agree to being the person they are looking for
                Console.WriteLine("Actually, just get out of here then!");
                badEnding++;
                Console.WriteLine("Please press enter");
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