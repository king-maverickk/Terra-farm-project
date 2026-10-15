using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Terra_Farm_Project
{

    internal class Encounters
    {
        private static int badEnding = 0;

        //Chemical system
        public static readonly Dictionary<(string, string), string> Recipes = new Dictionary<(string, string), string>()
        {
            { ("Hydrogen", "Oxygen"), "Water" }, // Dictonary of chemicals
            { ("sodium", "Chlorine"), "salt" },
            { ("Water", "Carbon Dioxide"), "Carbonic acide" },
            { ("Sulfur", "Oxygen"), "Sulfur Dioxide" },
        };

        public static string CombinChems(string chemical1, string chemical2)
        {
            string chem1 = chemical1.Trim(); //Allows for uppercasing letters
            string chem2 = chemical2.Trim();

            string first = string.Compare(chem1, chem2, StringComparison.OrdinalIgnoreCase) < 0 ? chem1 : chem2;
            string second = (first == chem1) ? chem2 : chem1; //makes so that ordering doesn't matter


            if (Recipes.TryGetValue((first, second), out string result)) // This gets the elements from the dictionary and compares if
            {
                return $"Success! combining {first} and {second} created {result}!";
            }
            return $"Fizzle... Combing {first} and {second} caused a little puff of grey smoke.";




        }


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


            Console.Title = "potion book"; // the book that lets the player see their elements
            Console.ForegroundColor = ConsoleColor.Blue;

            string RecipeBook = @"_________________________________
    /                                 \
   |   |                           |   |
   |   |   kudzi studios           |   |
   |   |                           |   |
   |   |   The K game              |   |
   |   |                           |   |
   |   |   -- Potion Recipe Book --|   |
   |   |                           |   |
   |   |                           |   |
    \_________________________________/
       \_______________________________/";






            Console.Title = "potion room dramatic title"; //the title tha will always play when entering the potion room
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            string PotionRoom = @"
                                  ╔═══════════════════════════════════════════════════╗
                                  ║                                                   ║
                                  ║                                                   ║ 
                                  ║               ⚗️ POTION ROOM ⚗️                    +
                                  ║                                                     +
                                  ║    ""Brewing, Distillation & Alchemy ""           ║
                                  ║                                                   ║
                                  ╚═══════════════════════════════════════════════════╝";









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
            Console.Clear();
            Console.WriteLine("Presents..");
            Task.Delay(1000).Wait();
            Console.Clear();



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




            // list of elements
            string ElementList = "1 – Hydrogen (H)     11 – Sodium (Na)\r\n2 – Helium (He)       12 – Magnesium (Mg)\r\n3 – Lithium (Li)      13 – Aluminum (Al)\r\n4 – Beryllium (Be)    14 – Silicon (Si)\r\n5 – Boron (B)         15 – Phosphorus (P)\r\n6 – Carbon (C)        16 – Sulfur (S)\r\n7 – Nitrogen (N)      17 – Chlorine (Cl)\r\n8 – Oxygen (O)        18 – Argon (Ar)\r\n9 – Fluorine (F)      19 – Potassium (K)\r\n10 – Neon (Ne)        20 – Calcium (Ca)\r\n";







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
                                Console.WriteLine("You get lost in the ever expanding hallways");
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

                                Console.Clear();
                                Console.WriteLine("You are now entering...");
                                Task.Delay(100).Wait();

                                Console.WriteLine($"{PotionRoom}");// first time in the potion room 
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine("You enter and are met by a work bench with potions and viles of all sorts");
                                Console.WriteLine("You're amazed by all the magic around you...Magic");
                                Console.WriteLine("upon closer inspection you realize that these aren't potions filled with wonder and whimsy");
                                Console.WriteLine("They're all Labeled with elements from the periodic table!");
                                Console.WriteLine("You try to ask the portrait about whats going on but the door loses before you're able to get a word in");
                                Console.WriteLine("You remember what the village person said to you. You need to make water. ");


                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("CHAPTER 2: Let there be water");
                                Console.ReadLine();
                                Console.Clear();
                                Console.WriteLine("On the work bench you see a book called the Potion recipe book");
                                Console.Write($"{RecipeBook}"); // first time opening the book
                                Console.WriteLine("");
                                Console.WriteLine("press enter to continue");
                                Console.ReadLine();
                                Console.WriteLine($"");
                                Console.WriteLine("You open it ");
                                Console.WriteLine($"{ElementList}"); // The element list that can be added to
                                Console.WriteLine("");
                                Console.WriteLine("This is the recipebook. It shows you a list of all the elements present in the lab");
                                Console.WriteLine("you will have to find more and more elements along the course of the game.");

                                Console.WriteLine("Since the villiager requested for you to make water.");
                                Console.WriteLine("press enter to go to the workbench");
                                Console.ReadLine();


                                string combinationResult = string.Empty;
                                while (combinationResult != "Success! combining Hydrogen and Oxygen created Water!")
                                {  // Loop that will keep asking for elements until the player makes water
                                    Console.Clear();

                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine($"{ElementList}");
                                    Console.WriteLine("Tip: Capitalize the first letter of the element you are entering");
                                    Console.WriteLine("Please enter your first Element!");
                                    string chemInput1 = Console.ReadLine();
                                    Console.WriteLine("");
                                    Console.WriteLine("");
                                    Console.WriteLine("Please enter your second Element");
                                    string chemInput2 = Console.ReadLine();


                                    // Calls to the chemical system
                                    combinationResult = CombinChems(chemInput1, chemInput2);
                                    Console.WriteLine();
                                    Console.WriteLine(combinationResult); // first chemical reaction

                                }


                                Console.WriteLine("");
                                Console.WriteLine("WELL DONE!");
                                Console.WriteLine("You have made Water");
                                Console.WriteLine("You have saved the town from dying of thirst");
                                Console.WriteLine("Do you want to go outside?");
                                Console.WriteLine("Yes/No");
                                if (ReadYes())
                                {
                                    Console.Clear();// You save the town 
                                    Console.WriteLine("You go outside and see the man that you met when you woke up");
                                    Console.WriteLine("You approach him and he thanks you for helping him and the town");
                                    Console.WriteLine("You have completed the first steps");
                                    Console.WriteLine("The world of chemisty is vast and full of possibilities");
                                    Console.WriteLine("Are you ready?");
                                    Console.WriteLine("Yes/No");
                                    if (ReadYes())
                                    {
                                        Console.Clear();// You continue the game and get to the next chapter
                                        Console.WriteLine("You have chosen to continue your journey");
                                        Console.WriteLine("You will be faced with many challenges and obstacles");
                                        Console.WriteLine("But you are ready for them!");
                                        Console.WriteLine($"Good luck on your journey, {playerName}");
                                        Console.WriteLine("Please press enter to continue...");
                                        Console.ReadLine();
                                        Console.Clear();

                                        Console.WriteLine("CHAPTER 3: The world of chemistry");
                                        Console.WriteLine("press enter to continue...");
                                        Console.ReadLine();

                                        Console.Clear();
                                        Console.WriteLine("You have created water and saved the town from dying of thirst");
                                        Console.WriteLine("The town is extremely grateful for your actions");
                                        Console.WriteLine("You have proven yourself to be a worthy chemist");
                                        Console.WriteLine("You hve access to the entire lab and all the elements within it");
                                        Console.WriteLine("You have access to the recipe book");
                                        Console.WriteLine("Just go to the lab to use it");
                                        Console.WriteLine("You currently have the choice to go to the Lab, go around the Village or go to the Forest");
                                        Console.WriteLine("Where do you want to go?");
                                        Console.WriteLine("1. Lab");
                                        Console.WriteLine("2. Village");
                                        Console.WriteLine("3. Forest");
                                        string input = Console.ReadLine();// The player can choose where to go next
                                                                          // three options the player can choose 


                                        switch (input)
                                        {
                                            case "1":
                                                Console.Clear();
                                                Console.WriteLine("You have chosen to go to the Lab");
                                                Console.WriteLine("You have access to all the elements within it");
                                                Console.WriteLine("You can use the recipe book to create new elements");
                                                Console.WriteLine("press enter to continue...");
                                                Console.ReadLine();
                                                Console.Clear();
                                                Console.WriteLine(" you enter the lab ready to craeat things beyond your wildest dreams");
                                                Console.WriteLine("You have access to the recipe book and all the elements within it");
                                                Console.WriteLine("would you like to access your the recipe book? "); 
                                                Console.WriteLine("Yes/No");
                                                Console.ReadLine();
                                                if (ReadYes())
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("You have chosen to access the recipe book");
                                                    Console.WriteLine($"{RecipeBook}");
                                                    Console.WriteLine("press enter to continue...");
                                                    Console.ReadLine();
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine(" Thats odd, Why come to the lab then?");
                                                    Console.WriteLine("cause you're a silly goose?");
                                                    Console.WriteLine("Or maybe you just want to go to the forest or village?");
                                                    Console.ReadLine();
                                                }






                                                break;

                                            case "2":

                                                Console.Clear();
                                                Console.WriteLine("You have chosen to go to the Village");
                                                Console.WriteLine("You can talk to the villagers and learn more about them");
                                                Console.WriteLine("press enter to continue...");
                                                Console.ReadLine();
                                                break;

                                            case "3":
                                                Console.Clear();
                                                Console.WriteLine("You have chosen to go to the Forest");
                                                Console.WriteLine("You can explore the forest and find new elements");
                                                Console.WriteLine("press enter to continue...");
                                                Console.ReadLine();
                                                break;


                                        }






                                    }
                                    else
                                    {
                                        Console.Clear();// You end the game shortly 
                                        Console.WriteLine("You have chosen to end your journey here");
                                        Console.WriteLine("It is sad to see you go");
                                        Console.WriteLine("But the K game will always be there for you");
                                        Console.WriteLine($"Goodbye, {playerName}");
                                        Console.WriteLine("Please press enter to end the game...");
                                        Console.ReadLine();
                                        return;

                                    }

                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("You stay inside and the town dies of thirst");
                                    Console.WriteLine("You Were supposed to be the hero of the town, but you failed them");
                                    Console.WriteLine("shame on you"); // you don't go outside after making water
                                    badEnding++;







                                }
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