using System;
using System.Collections.Generic;

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

                 Some content may or may not be based off of true accounts. PG-13
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
                    Console.WriteLine("In this game you will play the roll of tram driver #992 at the Gothenburg Tramway.");
                    Console.WriteLine("Your mission is to get to your destination on time while trying");
                    Console.WriteLine("not to run over anyone coming your way and keeping your psyche in check.");
                    Console.WriteLine("Your will be driving the famous number 11 from Komettorget Bergsjön");
                    Console.WriteLine("all the way over to the final destination Saltholmen.");
                    Console.WriteLine("Make wise decisions and stay on time or the hot headed commuters with their");
                    Console.WriteLine("boat connection to Saltholmen will certainly have you running for the hills.");
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
                    string goodBye = @"Good bye.. ಥ_ಥ";
                    Console.WriteLine(goodBye);
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
                "'Hasta la vista, baby!'",
                "'Computer says no..'",
                "'Sashay away!'",
                "'You talkin' to me?'",
                "'I've made a huge mistake.'",

            };

            int randomizer = random.Next(0, 4);
            string randomCatchphrase = catchphraseArray[randomizer];

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
            Console.WriteLine("STATUS: You have 5 seconds until departure and you see a kid come running from 100 meters away.");
            Console.WriteLine("He seems to be in quite a hurry to get to your tram.\n");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - Wait for him, of course.");
            Console.WriteLine("B - Depart immediately!");
            Console.WriteLine("C - I can't give special treatment to everyone who is late.");
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
                        // Sudden Game Over 1.
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Oh, no! Once the kid reaches you he parks himself by the door");
                        Console.WriteLine("waiting for his other friends to join from half a mile away.");
                        Console.WriteLine("You depart 5 minutes late and your tardiness dominoes the rest of the way.");
                        Console.WriteLine("No chance you can make it on time and your boss questions your capability.");
                        Console.WriteLine("What a bummer. :(");
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
                        Console.WriteLine("You don't pay attention to the automatic doors and their sensors.");
                        Console.WriteLine("Right as the kid steps in the doors decide to shut and squeeze him.");
                        Console.WriteLine("Those on board seem to think that you did it on purpose and you feel like jerk.");
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
                                                     (. .-'
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
            string choice;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("2. POSITION: Galileis Gata facing Januarigatan.");
            Console.ResetColor();
            Console.WriteLine("STATUS: A runner gets on your tram through the front door and stops to ask you:");
            Console.WriteLine("'What tram number is this?'\n");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - 'Number 11.'");
            Console.WriteLine("B - 'You mean you had me wait for you but you have no idea where I am going?'");
            Console.WriteLine("C - 'That's a really good question. I have no idea, sorry.'");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.ResetColor();
            Console.Write("CHOICE: ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "A":
                case "a":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("It takes alot of patience to pull that one off. Great job!");
                        Console.WriteLine("*-(￣▽￣)-*");
                        Console.ResetColor();
                        Console.ReadLine();
                        thirdEncounter();
                        break;
                    }
                case "B":
                case "b":
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("The runner hulks out in an awkward rage（╬ಠ益ಠ) and thinks your being");
                        Console.WriteLine("a 'wise punk'. He demands your name and wants to talk to your supervisor.");
                        Console.WriteLine("You try and shake it off but it takes a while.");
                        Console.ResetColor();
                        Console.ReadLine();
                        thirdEncounter();
                        break;
                    }
                case "C":
                case "c":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The passenger looks confused and sceptically takes a seat. Great job!");
                        Console.ResetColor();
                        Console.ReadLine();
                        thirdEncounter();
                        break;
                    }
                default:
                    {
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
                        secondEncounter();
                        break;
                    }
            }
        }


        // 3RD
        public static void thirdEncounter()
        {
            string choice;
            Console.Clear();

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
            ──▒▒▒▒▒▒▒▒───▒▒▒▒▒▒▒▒
            ─▒▐▒▐▒▒▒▒▌▒─▒▒▌▒▒▐▒▒▌▒
            ──▒▀▄█▒▄▀▒───▒▀▄▒▌▄▀▒
            ─────██─────────██
            ░░░▄▄██▄░░░░░░░▄██▄░░░

               PLATO WAS RIGHT
            ",
            @"
            ─▄▄█────────▄▄█
            ─▀▀█▄▄▄▄▄▄▀─▀▀█▄▄▄▄▄▄▀
            ───██████─────██████
            ──▄█───▄█────▄█───▄█

          THE MEANING OF LIFE IS 42
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
            Console.WriteLine("piece of paper with the following drawing on it:");
            Console.WriteLine(randomArt);
            Console.WriteLine("The person looks deep into your eyes and awaits some kind of response.\n");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - You take a disappointed glance at the drawing and throw it in the trash.");
            Console.WriteLine("B - You smile and say that you have a surprise for them at the next stop.");
            Console.WriteLine("C - You barely look at it, stare at the passenger, chew it up and swallow it.");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.Write("CHOICE: ");
            choice = Console.ReadLine();
            Console.Clear();

            if (choice == "A" || choice == "a")
            {
                var answerDrawing = @"
                ───▄█▌─▄─▄─▐█▄
                ───██▌▀▀▄▀▀▐██
                ───██▌─▄▄▄─▐██
                ───▀██▌▐█▌▐██▀
                ▄██████─▀─██████▄

                     7 DAYS
                ";
    
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Oh, no! The passenger did not take this very well.");
                Console.WriteLine("On his way out you got handed a final drawing:");
                Console.Write(answerDrawing);
                Console.WriteLine("Now you have to change your address + phone number. Yikes.");
                Console.ResetColor();
                Console.ReadKey();
                fourthEncounter();
            }
            if (choice == "B" || choice == "b")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("On the next stop you bring up your notepad and write: ^⨀ᴥ⨀^");
                Console.WriteLine("You hand him the drawing through the small slot.");
                Console.WriteLine("He looks pleased. He looks happy. Great job!");
                Console.ResetColor();
                Console.ReadKey();
                fourthEncounter();
            }
            else if (choice == "C" || choice == "c")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Oh, no! He mirrors you and picks up a random piece of paper to chew up.");
                Console.WriteLine("He starts choking but you quickly save him with some good ole heimlich. Phew!");
                Console.ResetColor();
                Console.ReadKey();
                fourthEncounter();
            }
            else
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
                thirdEncounter();
            }
        }
    

        // 4TH
        public static void fourthEncounter()
        {
            string choice;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("4. POSITION: SKF facing Gamlestadstorget.");
            Console.ResetColor();
            Console.WriteLine("STATUS: A passenger gets onboard through the front door where she takes a seat with her dog.");
            Console.WriteLine("You inform all passengers through the speakers on allergies and how pets are allowed in the back.");
            Console.WriteLine("The woman who very much heard what you said is ignoring you, front and center, with the dog.\n");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - You tell her that you don't get very far in life with an ignorant attitude.");
            Console.WriteLine("Especially on this tram and that she needs to get off.");
            Console.WriteLine("B - Bite your tongue and try to think of kittens.");
            Console.WriteLine("C - Next stop you go and ask the woman why she wouldn't listen, after you asked her nicely.");
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
                        // Sudden Win 1.
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Your outburst makes you loose your job but you win in life!");
                        Console.WriteLine("At least a few years where your personality would've deteriorated, anyway.");
                        Console.WriteLine("Now you can take time to stress out about other stuff instead!");
                        Console.WriteLine("Press 'Enter' to continue.");
                        Console.ResetColor();
                        Console.ReadLine();
                        gameWon();
                        break;
                    }
                case "B":
                case "b":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Great job! *meow*");
                        Console.ResetColor();
                        Console.ReadLine();
                        fifthEncounter();
                        break;
                    }
                case "C":
                case "c":
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Oh, no! She dramatically looks up at you with fire in her eyes and yells out:");
                        Console.WriteLine("'WHAT'S YOUR PROBLEM, HUH? GO TO H*LL WITH YOU!!!'");
                        Console.WriteLine("This is gonna be a looong day. ⊙︿⊙");
                        Console.ResetColor();
                        Console.ReadLine();
                        fifthEncounter();
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
                        fourthEncounter();
                        break;
                    }
            }
        }


        // 5TH
        public static void fifthEncounter()
        {
            string choice;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("5. POSITION: Centralstationen facing Brunnsparken.");
            Console.ResetColor();
            Console.WriteLine("STATUS: It's a beautiful, hot summer's day in Gothenburg! Ahead of you");
            Console.WriteLine("you can see that the rail has turned into a wobbly so called 'sun curve'.");
            Console.WriteLine("It reminds you of what a kids drawing of waves would look like.\n");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - Drive past it in 5km/h. Slow and easy like.");
            Console.WriteLine("B - Stay put and send out an alarm to Tram Management.");
            Console.WriteLine("C - Drive on as usual. It's just an aestheticly cool effect.");
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
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You got lucky this time, bubba!");
                        Console.WriteLine("You took a risk and you should have derailed.. Weird.");
                        Console.WriteLine("The laws of physics must like you a whole lot. Well done!");
                        Console.ResetColor();
                        Console.ReadLine();
                        sixthEncounter();
                        break;
                    }
                case "B":
                case "b":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Somebody has to fix this asap but it's not gonna be you.");
                        Console.WriteLine("One of the traffic managers waves you over and guides you slowly over,");
                        Console.WriteLine("the rails. If go south, at least it's not going to be");
                        Console.WriteLine("your own butt that's going to be toast. Bravo!");
                        Console.ResetColor();
                        Console.ReadLine();
                        sixthEncounter();
                        break;
                    }
                case "C":
                case "c":
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Wow! You did that without going off the rails completely? I'm stunned.");
                        Console.WriteLine("The driver after you who did the same thing was not as lucky as you.");
                        Console.WriteLine("The other driver derails and 'causes total chaos right in the middle of rush hour.");
                        Console.WriteLine("All of Brunnsparken turns into one gigantic mess but not for you because");
                        Console.WriteLine("you miraculously passed (until you turn the other way back that is).");
                        Console.ResetColor();
                        Console.ReadLine();
                        sixthEncounter();
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
                        fifthEncounter();
                        break;

                    }
            }
      }


        // 6TH
        public static void sixthEncounter()
        {
            string choice;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("6. POSITION: Groensakstorget facing Hagakyrkan.");
            Console.ResetColor();
            Console.WriteLine("STATUS: You are at the tram stop with open doors. You look at your monitor");
            Console.WriteLine("and see an older man trying to get on board with something that looks like");
            Console.WriteLine("your average large, metallic, 2x1 meter shopping cart from Ica Maxi.\n");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - 'Sorry, this is not happening today, good sir! No! No! Off you go. Thank you and good luck.'");
            Console.WriteLine("B - He has a hard time walking. In exchange for the cart you offer him a track switching cain instead.");
            Console.WriteLine("C - You let him get on 'unnoticed' + you're secretly a tiny bit curious as to what might happen.");
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
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Another passenger confronts you afterwards and questions what your problem is.");
                        Console.WriteLine("'Uh! He actually had a hard time walking and he was using the cart as a crutch! You monster!'");
                        Console.WriteLine("¯|_(ツ)_/¯");
                        Console.ResetColor();
                        Console.ReadLine();
                        seventhEncounter();
                        break;
                    }
                case "B":
                case "b":
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The man frowns because he wanted to go to the supermarket but you did your best. Great job!");
                        Console.ResetColor();
                        Console.ReadLine();
                        seventhEncounter();
                        break;
                    }
                case "C":
                case "c":
                    {
                        // Sudden Game Over 2.
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Uh, oh! He 'parks' it where passengers usually put strollers. Once you drive off,");
                        Console.WriteLine("so does the shopping cart and smahes into several other innocent passengers.");
                        Console.WriteLine("Needless to say, after this gory story, you lost your job over inattentive recklessness.");
                        Console.ResetColor();
                        Console.ReadLine();
                        gameOver();
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
                        sixthEncounter();
                        break;

                    }
            }

        }

        // 7TH
        public static void seventhEncounter()
        {
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

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("7. POSITION: Masthuggstorget facing Stigbergstorget.");
            Console.ResetColor();
            Console.WriteLine("STATUS: A passenger comes up and says to you:");
            Console.WriteLine(randomLanguage);
            Console.WriteLine("");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - Nod politely.");
            Console.WriteLine("B - 'No!'");
            Console.WriteLine("C - Hide and pretend it's not happening.");
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
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("What a pro! Great job!");
                        Console.ResetColor();
                        Console.ReadLine();
                        eigthEncounter();
                        break;
                    }
                case "B":
                case "b":
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("( ⚆ _ ⚆ )");
                        Console.WriteLine("The person silently and akwardly exits.");
                        Console.WriteLine("You try not to overthink it.");
                        Console.ResetColor();
                        Console.ReadLine();
                        eigthEncounter();
                        break;
                    }
                case "C":
                case "c":
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Well this is awkward. You wait in silence until they leave you alone.");
                        Console.WriteLine("( ɵ̥̥ ˑ̫ ɵ̥̥)");
                        Console.ResetColor();
                        Console.ReadLine();
                        eigthEncounter();
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
                        ninthEncounter();
                        break;
                    }
            }

        }


        // 8TH
        public static void eigthEncounter()
        {
            string choice;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("8. POSITION: Majvallen facing Ekedal.");
            Console.ResetColor();
            Console.WriteLine("STATUS: While driving 40km/h, the tram mysteriously stops for no apparent reason.");
            Console.WriteLine("Everybody lunged forward from the hard brake that kicked in. ");
            Console.WriteLine("A small red light goes off in your cabin but you can't find any no other indicators that something's wrong.\n");
            Console.WriteLine("WHAT DO YOU DO?");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("----------------");
            Console.WriteLine("A - You get up on the roof of the tram and fix a wire.");
            Console.WriteLine("B - You check for the rascal who pulled one of the emergency breaks and reset that sucker.");
            Console.WriteLine("C - You slam your fist on the red light indicator. ");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.Write("CHOICE: ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "A":
                case "a":
                    {   // Final sudden Game Over 3.
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That thing is packed with a lethal amount of electricity! What are you doing?");
                        Console.WriteLine("You get rushed to the emergency room and they manage to save your crazy butt.");
                        Console.WriteLine("No more tram driving for you!");
                        Console.ReadKey();
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
                        Console.ReadKey();
                        ninthEncounter();
                        break;
                    }
                case "C":
                case "c":
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("What good did that do? No good really. Now your hand hurts.");
                        Console.WriteLine("You realize someone pulled an emergency break and you reset it");
                        Console.WriteLine("and go on with your day.");
                        Console.ResetColor();
                        Console.ReadKey();
                        ninthEncounter();
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
            Console.WriteLine("A - You leave the doors open and go out and have a smoke with the guy.");
            Console.WriteLine("B - You force shut the doors in his face.");
            Console.WriteLine("C - 'Yes, this is the tram to h*ll! Are you getting on, good sir?' Final call!");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.Write("CHOICE: ");
            choice = Console.ReadLine();
            Console.Clear();

            while (true)
            {
                if (choice == "A" || choice == "a")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You needed that! Great job! ( ͡° ͜ʖ ͡°)");
                    Console.ReadKey();
                    Console.ResetColor();
                    tenthEncounter();
                }
                if (choice == "B" || choice == "b")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("The door managed to squeeze away the cigarette from his hand");
                    Console.WriteLine("and he stumbled off, out on the sidewalk. Right as you close the");
                    Console.WriteLine("door he karate kicks the door and punches his fist on your driver cabin window.");
                    Console.WriteLine("He looks at you and spits and makes a cold Sweeney Todd gesture.");
                    Console.WriteLine("- 'Someday, a real rain will come and wash all this scum off the streets.' /Taxi Driver (1976)");
                    Console.ReadKey();
                    Console.ResetColor();
                    tenthEncounter();
                }
                else if (choice == "C" || choice == "c")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The smoker had self esteem issues and ran far, far away. Great job!");
                    Console.ReadKey();
                    tenthEncounter();
                }
                else
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
                    ninthEncounter();
                    break;
                }
            }
        }


        public static void tenthEncounter()
        {
            Console.Clear();
            string choice;
            Console.ForegroundColor = ConsoleColor.Yellow;
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
            Console.WriteLine("A - 'Strollers are baby carriers, not weapons of mass destruction. What's the number to Bris?'");
            Console.WriteLine("B - You can't hear the sound of all the ruckus over the sound of you winning this console game.");
            Console.WriteLine("C - You shut down the door control fuse and hustle all the way to Saltholmen in full speed.");
            Console.WriteLine("----------------");
            Console.ResetColor();
            Console.Write("CHOICE: ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "A":
                case "a":
                    {   // Alternative ending 1.
                        var angel = @"
     _      
   (\o/)   
    /_\
";
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("You went to heaven and now you're an angel! Wow!");
                        Console.WriteLine("That man did not share your sense of humour, I'll tell you that!");
                        Console.WriteLine("The commuters to Saltholmen might not have had your head today but unfortunately");
                        Console.WriteLine("this man sure darn diddly did. It was the city's infamous wanted 'stroller serial killer'.");
                        Console.WriteLine("At least you don't have to drive people around anymore 'cause wings are so fetch in heaven.");
                        Console.Write(angel);
                        Console.ResetColor();
                        Console.ReadLine();
                        gameWon();
                        break;
                    }

                case "B":
                case "b":
                    {   // Alternative ending 2.
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Clear();
                        Console.WriteLine("Oh yeah! ᕕ( ᐛ )ᕗ");
                        Console.WriteLine("You did it my friend! There was no stopping you now!");
                        Console.WriteLine("In some mysterious way you pulled it off and made it just in time!");
                        Console.WriteLine("The passengers even got to their boat connection. You even almost");
                        Console.WriteLine("had time to go to the bathroom and refill your water bottle before your next departure.");
                        Console.WriteLine("Almost that is. You pass from dehydration but you're not much of a complainer.");
                        Console.WriteLine("What a day to be a tram driver! Lucky you!");
                        Console.ResetColor();
                        Console.ReadLine();
                        gameWon();
                        break;
                    }

                case "C":
                case "c":
                    {   // Alternative ending 3.
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("ヽ/❀o ل͜ o|ﾉ");
                        Console.WriteLine("Wow, you actually made it to Saltholmen in time!");
                        Console.WriteLine("The passengers even got to their boat connection. You almost");
                        Console.WriteLine("had time to go to the bathroom before your next departure.");
                        Console.WriteLine("Almost that is. What a great day to be a tram driver! Lucky you!");
                        Console.ResetColor();
                        Console.ReadLine();
                        gameWon();
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

                              Press 'Enter/Return' to try again.

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


                            Press 'Enter/Return' to play again.
                                                                                ";
            Console.Write(winTitle);
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            gameIntro();
        }
    }
}