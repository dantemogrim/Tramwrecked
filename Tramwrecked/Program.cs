using System;
using System.Collections.Generic;
using System.IO;


namespace Tramwrecked
{


    class Program
    {
        static void Main(string[] args)
        {
            gameIntro();

        }

        public static void gameIntro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            string introPrompt = @"
                 ___________  ___ ___  ____    _______ _____ _____ _   _____________ 
                |_   _| ___ \/ _ \|  \/  | |  | | ___ |  ___/  __ | | / |  ___|  _  \
                  | | | |_/ / /_\ | .  . | |  | | |_/ | |__ | /  \| |/ /| |__ | | | |
                  | | |    /|  _  | |\/| | |/\| |    /|  __|| |   |    \|  __|| | | |
                  | | | |\ \| | | | |  | \  /\  | |\ \| |___| \__/| |\  | |___| |/ / 
                  \_/ \_| \_\_| |_\_|  |_/\/  \/\_| \_\____/ \____\_| \_\____/|___/  

                  ,',                                   ,',
                 ', ,'                                 ', ,'
              ,----'--------------------------.     ,----'--------------------------.
              /''|```|```|```|```|```|```|``|` |    /''|```|```|```|```|```|```|``|``|
             |---'---'---'---'---'---'---'--'--|   |---'---'---'---'---'---'---'--'--|
             ,_    ______           ______     |=-=,_    ______           ______     |
              '---'(O)(O)'---------'(O)(O)'---'     '---'(O)(O)'---------'(O)(O)'---'


                                   Hit 'Enter/Return' to begin.

              The majority of content may or may not be based off of true accounts.
            ";
            Console.Write(introPrompt);
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            gameMenu();

        }

        public static void gameMenu()
        {
            string choice;
            string menuTitle = @"
 ____ ____ ____ ____ 
||M |||E |||N |||U ||
||__|||__|||__|||__||
|/__\|/__\|/__\|/__\|

        ";


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(menuTitle);
            

            var menuOptions = new List<string>()
            {
                "1. START",
                "2. INSTRUCTIONS",
                "3. CONTROLS",
                "4. QUIT",
            };


            foreach (var menuOption in menuOptions)
            {
                Console.WriteLine(menuOption);
            }

            Console.ResetColor();

            Console.Write("\nTYPE A NUMBER + HIT 'ENTER/RETURN': ");
            choice = Console.ReadLine();
            Console.Clear();

            while (true)
            {
                if (choice == "1" || choice == "1." || choice == "START" || choice == "start" || choice == "1. START")
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    string tinyTram = @"

         ,',                                   ,',
        ', ,'                                 ', ,'
     ,----'--------------------------.     ,----'--------------------------.
    ('''|```|```|```|```|```|```|``|` |   ('''|```|```|```|```|```|```|``|``|
    |---'---'---'---'---'---'---'--'--|   |---'---'---'---'---'---'---'--'--|
   =,_    ______           ______     |___,_    ______           ______     |= 
     '---'(O)(O)'---------'(O)(O)'---'     '---'(O)(O)'---------'(O)(O)'---' 


                          Σ(ノ°▽°)ノ Let's get moving!
                    ";
                    Console.Write(tinyTram);
                    Console.ReadKey();
                    Console.ResetColor();
                    Console.Clear();

                    playerPresets();
                }

                if (choice == "2" || choice == "2." || choice == "INSTRUCTIONS" || choice == "instructions" || choice == "2. INSTRUCTIONS")
                {
                    Console.WriteLine("As you might've guessed.. From here on out, are the tram driver.");
                    Console.WriteLine("Your mission is to get to your destination on time while trying");
                    Console.WriteLine("not to run over anyone coming your way and keeping your psyche in check.");
                    Console.WriteLine("Your will be driving the famous number 11 from Komettorget Bergsjön");
                    Console.WriteLine("all the way over to our final, coastal destination Saltholmen.");
                    Console.WriteLine("Make wise decisions and stay on time or the commuters with their");
                    Console.WriteLine("boat connection to Saltholmen will certainly have your head.");
                    Console.WriteLine("Good luck, amigo!");
                    Console.ReadKey();
                    Console.Clear();
                    gameMenu();
                }

                if (choice == "3" || choice == "3." || choice == "CONTROLS" || choice == "controls" || choice == "3. CONTROLS")
                {

                    Console.WriteLine("CONTROLS:\n");
                    Console.WriteLine("ANSWER: 'A', 'B' or 'C' + 'Enter/Return' key\n");
                    Console.WriteLine("CONTINUE: 'Enter/Return' key");
                    Console.ReadKey();
                    Console.Clear();
                    gameMenu();
                }

                else if (choice == "4" || choice == "4." || choice == "QUIT" || choice == "quit" || choice == "4. QUIT")
                {
                    Console.WriteLine("Good bye!");
                    Console.ReadKey();
                    Environment.Exit(-1);
                }

                else
                {
                    // If player types something else than the options above.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oops! Looks like you typed something funny there.");
                    Console.WriteLine("Type a number from the menu and hit 'Enter/Return'.");
                    Console.WriteLine("Try and get it right this time. You got this!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    gameMenu();
                }
            }

        }
        
        public static void playerPresets()
        {

            Random random = new Random();
            string[] catchphraseArray =  {
                "'Don't happy be worry!'",
                "'Computer says no..'",
                "'Life's a garden - dig it!'",
                "'Make it work!'",
                "'Yada, yada, yada.'",

            };


        int randomizer = random.Next(0, 4);
        string randomCatchphrase = catchphraseArray[randomizer];

        //string currentPlayerName;
            Console.WriteLine("First thing's first. What's your name?");
            Console.Write("NAME: ");
            var player = new Player(Console.ReadLine());
            Console.WriteLine($"That is a swell name, {player.name}, my friend!");
            Console.WriteLine("Here comes your official tram driving license:");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("=====[ * TRAM DRIVING LICENSE * ]=====");
            Console.WriteLine($"> DRIVER: #992 {player.name}");
            Console.WriteLine("¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨");
            Console.WriteLine("> LINE: 11 headed towards 'Saltholmen'");
            Console.WriteLine("¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨");
            Console.WriteLine("> TRAM: M31 #360 - 'Pompelina'");
            Console.WriteLine("¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨ ¨");
            Console.WriteLine($"> CATCHPHRASE: {randomCatchphrase}");
            Console.WriteLine("--------------------------------------");

            Console.ResetColor();
            Console.ReadLine();
            firstEncounter();
        }


        // 1ST
        public static void firstEncounter()
        {
            string choice;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. POSITION: Komettorget facing Rymdtorget.");
            Console.ResetColor();
            Console.WriteLine(
                "STATUS: You have 5 seconds until departure and you see a kid come running from 100 meters away.");
            Console.WriteLine("He seems to be in quite a hurry to get to your tram.\n");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - RED - Wait for him, of course.");
            Console.WriteLine("B - GREEN - Depart immediately!");
            Console.WriteLine("C - YELLOW - I can't give special treatment to everyone who is late.");
            Console.WriteLine("I'm departing as estimated with or without him.");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.Write("CHOICE: ");
            
            choice = Console.ReadLine();
            Console.Clear();
            

            switch (choice)
            {
                case "A":
                case "a":
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oh, no! Once the kid reaches you he parks himself by the door");
                    Console.WriteLine("waiting for his other friends to join too from half a mile away.");
                    Console.WriteLine("You depart 5 minutes late and your tardiness domino'es the rest of the way.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ResetColor();
                    Console.ReadLine();
                    gameOver();
                    break;
                }

                case "B":
                case "b":
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The kid is holding an ice cream in his hand.");
                    Console.WriteLine("As soon as he sees you're about to drive away from him, he chugs it towards you.");
                    Console.WriteLine("Your windshield now has a bunch of ice cream mush on it but hey, at least your in time!");
                    Console.ResetColor();
                    Console.ReadLine();
                    secondEncounter();
                    break;
                }

                case "C":
                case "c":
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Oh, no! You struggle a bit but you're hanging in there!");
                    Console.ResetColor();
                    Console.ReadLine();
                    secondEncounter();
                    break;

                }
                default:
                {
                    // If player types something else than the options above.
                    var deadEnd = @"

                                                       _                
                                                      /_\            
            Confused? Here's a hint.                 // \\      
            Type the letter of your answer          //   \\      
            then hit 'Enter/Return'.               //   .-.\   
            Try and get it right this time.       ///--//-')\   
            You got this!                        // \-//--' \\    
                                                ((   ((      ))      
                                                 \\  DEAD   //        
                                                  \\ END   //         
                                                   \\     //              
                                                    \\   //    ..--            
                                                     \\_//| -'                  
                                                ..--  \_/ |               
                                                       || |              
                                                       || |              
                                                       || |          
                                                       || |     ..-- 
                                                      )|| | _.-
                                                     (  .-'
                    ";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(deadEnd);
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    firstEncounter();
                    break;

                }
            }
        }

        
        // 2ND
        public static void secondEncounter()
        {
            Console.Clear();
            
            string choice;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2. POSITION: Galileis Gata facing Januarigatan.");
            Console.ResetColor();
            Console.WriteLine("STATUS: A runner gets on your tram through the front door and stops to ask you:");
            Console.WriteLine("'What tram number is this?'\n");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - 'You had me wait for you but you have no idea where I am going?'");
            Console.WriteLine("B - 'That's a good question. I have no idea, sorry.'");
            Console.WriteLine("C - Tell him number 11.");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.Write("CHOICE: ");
            choice = Console.ReadLine();
            Console.ReadKey();



            switch (choice)
            {
                case "A":
                case "a":
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Great job!");
                    Console.ResetColor();
                    Console.ReadLine();
                    gameOver();
                    break;
                }

                case "B":
                case "b":
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oh, no!");
                    Console.ResetColor();
                    Console.ReadLine();
                    thirdEncounter();
                    break;
                }

                case "C":
                case "c":
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Great job!");
                    Console.ResetColor();
                    Console.ReadLine();
                    gameWon();
                    break;

                }
                default:
                {
                    // If player types something else than the options above.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Confused? Here's a hint.");
                    Console.WriteLine("Type the capital letter of your answer and hit 'Enter/Return'.");
                    Console.WriteLine("Try and get it right this time. You got this!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    secondEncounter();
                    break;

                }


            }
        }

        // 3RD
        public static void thirdEncounter()
        {
            Console.Clear();
            string choice;


            Random random = new Random();
            string[] asciiArray =
            {@"
                ───▄▄▄
                ─▄▀░▄░▀▄
                ─█░█▄▀░█
                ─█░▀▄▄▀█▄█▄▀
                ▄▄█▄▄▄▄███▀

            TIME IS AN ILLUSION

            ",
            @"

            ─────█─▄▀█──█▀▄─█─────
            ────▐▌──────────▐▌────
            ────█▌▀▄──▄▄──▄▀▐█────
            ───▐██──▀▀──▀▀──██▌───
            ──▄████▄──▐▌──▄████▄──

            ", 
            @"

            ─▄▄█────────▄▄█
            ─▀▀█▄▄▄▄▄▄▀─▀▀█▄▄▄▄▄▄▀
            ───██████─────██████
            ──▄█───▄█────▄█───▄█

            ",
            @"

            ▄██████████████▄▐█▄▄▄▄█▌
            ██████▌▄▌▄▐▐▌███▌▀▀██▀▀
            ████▄█▌▄▌▄▐▐▌▀███▄▄█▌
            ▄▄▄▄▄██████████████▀

            

            ",

            @"

                  .-''''-,
                 / \____/ \_.99
              (_/__/____\_(____)
                //_//    \\_\

               I LOVE TURTLES

            ",


            }; 


            int randomizer = random.Next(0, 4);
            string randomArt = asciiArray[randomizer];

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("3. POSITION: Kortedala Torg facing Runstavsgatan.");
            Console.ResetColor();
            Console.WriteLine("STATUS: A shy looking passenger comes over and hands you a");
            Console.WriteLine("piece of paper with the following information written on it:");
            Console.WriteLine(randomArt);
            Console.WriteLine("The person looks deep into your eyes and awaits some kind of response.\n");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - Ask him politely to make a decision.");
            Console.WriteLine("B - Ask him what is going on.");
            Console.WriteLine("C - Pay him no mind and drive off without him.");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.Write("CHOICE: ");
            choice = Console.ReadLine();
            Console.ReadKey();


            if (choice == "A" || choice == "a")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oh, no!");
                Console.ResetColor();
                fourthEncounter();
            }
            if (choice == "B" || choice == "b")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("^⨀ᴥ⨀^");
                Console.ResetColor();
                fourthEncounter();
            }
            else if (choice == "C" || choice == "c")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oh, no!");
                Console.ResetColor();
                fourthEncounter();
            }
            else
            {
                // If player types something else than the options above.
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Confused? Here's a hint.");
                Console.WriteLine("Type the capital letter of your answer and hit 'Enter/Return'.");
                Console.WriteLine("Try and get it right this time. You got this!");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
                fourthEncounter();
            }
        }


            // 4TH
            public static void fourthEncounter()
        {
            Console.Clear();
            string choice;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("4. POSITION: SKF facing Gamlestadstorget.");
            Console.ResetColor();
            Console.WriteLine("SITUATION: A passenger gets onboard through the front door where she takes a seat with her dog.");
            Console.WriteLine("You inform all passengers through the speakers on allergies and how pets are allowed in the back.");
            Console.WriteLine("The woman who very much heard what you said is staying put in her seat, front and center, with the dog.\n");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - Next stop you ask the woman why she wouldn't listen, after you asked her nicely.");
            Console.WriteLine("B - (CONTINUE)");
            Console.WriteLine("C - (WIN)");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.Write("CHOICE: ");
            choice = Console.ReadLine();
            Console.ReadKey();



            switch (choice)
            {
                case "A":
                case "a":
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The woman looks up at you with disgust and blurts out:");
                    Console.WriteLine("'WIN!'");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ResetColor();
                    Console.ReadLine();
                    gameOver();
                    break;
                }

                case "B":
                case "b":
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Great job!");
                    Console.ResetColor();
                    Console.ReadLine();
                    fifthEncounter();
                    break;
                }

                case "C":
                case "c":
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oh, no!");
                    Console.ResetColor();
                    Console.ReadLine();
                    gameWon();
                    break;

                }
                default:
                {
                    // If player types something else than the options above.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Confused? Here's a hint.");
                    Console.WriteLine("Type the capital letter of your answer and hit 'Enter/Return'.");
                    Console.WriteLine("Try and get it right this time. You got this!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    fourthEncounter();
                    break;

                }


            }
            
            
            
        }
        
        
        // 5TH
        public static void fifthEncounter()
        {
            
            Console.Clear();
            
            string choice;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("5. POSITION: Centralstationen facing Brunnsparken.");
            Console.ResetColor();
            Console.WriteLine("STATUS: Everyone has exited and gotten onboard.");
            Console.WriteLine("Now you see old lady Agda giving you a wave and asking you to wait for her.\n");
            Console.WriteLine("What do you do?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - (WIN)");
            Console.WriteLine("B - (CONTINUE)");
            Console.WriteLine("C - (CONTINUE)");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.Write("CHOICE: ");
            choice = Console.ReadLine();
            Console.ReadKey();



            switch (choice)
            {
                case "A":
                case "a":
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oh, no!");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ResetColor();
                    Console.ReadLine();
                    gameOver();
                    break;
                }

                case "B":
                case "b":
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Great job!");
                    Console.ResetColor();
                    Console.ReadLine();
                    sixthEncounter();
                    break;
                }

                case "C":
                case "c":
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oh no!");
                    Console.ResetColor();
                    Console.ReadLine();
                    sixthEncounter();
                    break;

                }
                default:
                {
                    // If player types something else than the options above.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Confused? Here's a hint.");
                    Console.WriteLine("Type the capital letter of your answer and hit 'Enter/Return'.");
                    Console.WriteLine("Try and get it right this time. You got this!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    fifthEncounter();
                    break;

                }


            }
            
            
            
            
        }
        
        // 6TH
        public static void sixthEncounter()
        {
            
            Console.Clear();
            
            string choice;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("6. POSITION: Groensakstorget facing Hagakyrkan.");
            Console.ResetColor();
            Console.WriteLine("STATUS: You are at the tram stop with open doors. You look at your monitor");
            Console.WriteLine("and see a man trying to get on board with something that looks like");
            Console.WriteLine("your average shopping cart from Ica Maxi.\n");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - (WIN) ");
            Console.WriteLine("B - (GAME OVER)");
            Console.WriteLine("C - (WIN)");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.Write("CHOICE: ");
            choice = Console.ReadLine();
            Console.ReadKey();



            switch (choice)
            {
                case "A":
                case "a":
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oh, no!");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ResetColor();
                    Console.ReadLine();
                    gameOver();
                    break;
                }

                case "B":
                case "b":
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Great job!");
                    Console.ResetColor();
                    Console.ReadLine();
                    seventhEncounter();
                    break;
                }

                case "C":
                case "c":
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose!");
                    Console.ResetColor();
                    Console.ReadLine();
                    gameWon();
                    break;

                }
                default:
                {
                    // If player types something else than the options above.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Confused? Here's a hint.");
                    Console.WriteLine("Type the capital letter of your answer and hit 'Enter/Return'.");
                    Console.WriteLine("Try and get it right this time. You got this!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    sixthEncounter();
                    break;

                }


            }
            
        }

        // 7TH
        public static void seventhEncounter()
        {
            Console.Clear();

            // "Are you driving to the next stop?" - Same question but in different languages.
            Random random = new Random();
            string[] languageArray =
            {"'Vozite li se do sljedeće stanice?' o( ❛ᴗ❛ )o", // Bosnian.
            "'Stai guidando verso la prossima fermata?' ( ‾́ ◡ ‾́ )", // Italian.
            "'Rijd je naar de volgende halte?' (* ^ ω ^)", // Dutch.
            "'Miyaad gaadhi u wadaysaa joogsiga xiga?' ٩(◕‿◕｡)۶"}; // Somalian.


            int randomizer = random.Next(0, 3);
            string randomLanguage = languageArray[randomizer];

            
            string choice;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("7. POSITION: Masthuggstorget facing Stigbergstorget.");
            Console.ResetColor();
            Console.WriteLine("STATUS: A person gets on your tram and asks you the following question:");
            Console.WriteLine(randomLanguage);
            Console.WriteLine("");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - Answer ''");
            Console.WriteLine("B - Answer ''");
            Console.WriteLine("C - Pick up your jacket, leave and walk away from everything.");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.Write("CHOICE: ");
            choice = Console.ReadLine();
            Console.ReadKey();



            switch (choice)
            {
                case "A":
                case "a":
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Great job!");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ResetColor();
                    Console.ReadLine();
                    gameOver();
                    break;
                }

                case "B":
                case "b":
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oh, no!");
                    Console.ResetColor();
                    Console.ReadLine();
                    eigthEncounter();
                    break;
                }

                case "C":
                case "c":
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oh, no!");
                    Console.ResetColor();
                    Console.ReadLine();
                    gameWon();
                    break;

                }
                default:
                {
                    // If player types something else than the options above.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Confused? Here's a hint.");
                    Console.WriteLine("Type the capital letter of your answer and hit 'Enter/Return'.");
                    Console.WriteLine("Try and get it right this time. You got this!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    seventhEncounter();
                    break;

                }


            }
            
        }
        
        
        // 8TH
        public static void eigthEncounter()
        {
            
            Console.Clear();
            string choice;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("8. POSITION: Majvallen facing Ekedal.");
            Console.ResetColor();
            Console.WriteLine("STATUS: While driving 40km/h, the tram mysteriously stops for no apparent reason.");
            Console.WriteLine("Everybody lunged forward from the hard brake that kicked in. ");
            Console.WriteLine("A small red light goes off in your cabin but you can't find any no other indicators that something's wrong.\n");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - (GAME OVER) ");
            Console.WriteLine("B - I go and check for whatever rascal pulled one of the emergency breaks and reset it.");
            Console.WriteLine("C - (WIN) ");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.Write("CHOICE: ");
            choice = Console.ReadLine();
            Console.ReadKey();



            switch (choice)
            {
                case "A":
                case "a":
                {   // Final 'game over' pitfall.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You died!");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ResetColor();
                    gameOver();
                    break;
                }

                case "B":
                case "b":
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("B-i-n-g-o! A gold star to you!");
                    Console.WriteLine("Onwards and upwards, here we go!");
                    Console.ResetColor();
                    ninthEncounter();
                    break;
                }

                case "C":
                case "c":
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oh, no!");
                    Console.ResetColor();
                    ninthEncounter();
                    break;

                }
                default:
                {
                    // If player types something else than the options above.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Confused? Here's a hint.");
                    Console.WriteLine("Type the capital letter of your answer and hit 'Enter/Return'.");
                    Console.WriteLine("Try and get it right this time. You got this!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    eigthEncounter();
                    break;

                }


            }
            
        }
        
        // 9
        public static void ninthEncounter()
        {
            
            Console.Clear();
            
            
            string choice;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("9. POSITION: Sannaplan facing Sandarna.");
            Console.ResetColor();
            Console.WriteLine("STATUS: A grown man gets on your tram through the front door.");
            Console.WriteLine("He hasn't finished his cigarette yet. So before he gets on");
            Console.WriteLine("he stands still in the door and takes a last smoke and puts");
            Console.WriteLine("out his cigarette on your driver door and gives you a smile.\n");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - (WIN) ");
            Console.WriteLine("B - (WIN) ");
            Console.WriteLine("C - (WIN) ");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.Write("CHOICE: ");
            choice = Console.ReadLine();
            Console.ReadKey();



            while (true)
            {
                if (choice == "A" || choice == "a")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Great job!");
                    Console.ResetColor();
                    tenthEncounter();
                }

                if (choice == "B" || choice == "b")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Oh, no!");
                    Console.ResetColor();
                    tenthEncounter();
                }

                else if (choice == "C" || choice == "c")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Great job!");
                    tenthEncounter();
                }

                else
                {
                    // If player types something else than the options above.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Confused? Here's a hint.");
                    Console.WriteLine("Type the capital letter of your answer and hit 'Enter/Return'.");
                    Console.WriteLine("Try and get it right this time. You got this!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    ninthEncounter();
                }

       
            }
        }
        
        public static void tenthEncounter()
        {
            
            Console.Clear();
            
            string choice;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("10. POSITION: Hagen facing Tranered.");
            Console.ResetColor();
            Console.WriteLine("STATUS: Right before your about to depart from the tram stop");
            Console.WriteLine("from out of nowhere comes a parent with a stroller and as the doors");
            Console.WriteLine("are closing shut the parent takes charge and uses the stroller as a");
            Console.WriteLine("weapon of force to push through the narrow space that's left.");
            Console.WriteLine("The doors are now completely broken as a result. This means you won't");
            Console.WriteLine("be able to lock them and you won't be able to drive until they are fixed.\n");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - WIN ");
            Console.WriteLine("B - WIN ");
            Console.WriteLine("C - (WIN) ");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.Write("CHOICE: ");
            choice = Console.ReadLine();
            Console.ReadKey();



            switch (choice)
            {
                case "A":
                case "a":
                {   // Alternative ending 1.
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You died!");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ResetColor();
                    Console.ReadLine();
                    gameWon();
                    break;
                }

                case "B":
                case "b":
                {   // Alternative ending 2.
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("(ﾉ≧∀≦)ﾉ");
                    Console.ResetColor();
                    Console.ReadLine();
                    gameWon();
                    break;
                }

                case "C":
                case "c":
                {   // Alternative ending 3.
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ヽ/❀o ل͜ o|ﾉ");
                    Console.ResetColor();
                    Console.ReadLine();
                    gameWon();
                    break;

                }
                default:
                {
                    // If player types something else than the options above.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Confused? Here's a hint.");
                    Console.WriteLine("Type the capital letter of your answer and hit 'Enter/Return'.");
                    Console.WriteLine("Try and get it right this time. You got this!");
                    Console.ResetColor();
                    Console.ReadKey();
                    Console.Clear();
                    tenthEncounter();
                    break;

                }


            }
            
        }
        
        public static void gameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            var endTitle = @"


              ▄████  ▄▄▄       ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  
             ██▒ ▀█▒▒████▄    ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒
            ▒██░▄▄▄░▒██  ▀█▄  ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒
            ░▓█  ██▓░██▄▄▄▄██ ▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  
            ░▒▓███▀▒ ▓█   ▓██▒▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒
             ░▒   ▒  ▒▒   ▓▒█░░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░
              ░   ░   ▒   ▒▒ ░░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░
            ░ ░   ░   ░   ▒   ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░ 
                  ░       ░  ░       ░      ░  ░       ░ ░        ░     ░  ░   ░     
                                                                 ░                   


                                Better luck next time, pal!
                                Press 'Enter' to try again.

            ";
            Console.Write(endTitle);
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            gameIntro();
        }
        
        public static void gameWon()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            string winTitle = @"

             __  __   ______   __  __       __ __ __   ______   ___   __    __      
            /_/\/_/\ /_____/\ /_/\/_/\     /_//_//_/\ /_____/\ /__/\ /__/\ /__/\    
            \ \ \ \ \\:::_ \ \\:\ \:\ \    \:\\:\\:\ \\:::_ \ \\::\_\\  \ \\.:\ \   
             \:\_\ \ \\:\ \ \ \\:\ \:\ \    \:\\:\\:\ \\:\ \ \ \\:. `-\  \ \\::\ \  
              \::::_\/ \:\ \ \ \\:\ \:\ \    \:\\:\\:\ \\:\ \ \ \\:. _    \ \\__\/_ 
                \::\ \  \:\_\ \ \\:\_\:\ \    \:\\:\\:\ \\:\_\ \ \\. \`-\  \ \ /__/\
                 \__\/   \_____\/ \_____\/     \_______\/ \_____\/ \__\/ \__\/ \__\/


            Wow, you actually made it to Saltholmen in time! Passengers even got to their boat connection.
            You even almost had enough time before your next departure to go to the bathroom.
            Almost that is. What a great day to be a tram driver! Lucky you!
            Press 'Enter' to play again.

             ";
            Console.Write(winTitle);
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            gameIntro();
        }

    }

}