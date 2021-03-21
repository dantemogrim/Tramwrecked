using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = "";
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nWelcome to the world famous console game - Tramwrecked!");
            Console.WriteLine("Glad you could make it! Tell me, what's your name, kiddo?");
            Console.ResetColor();
            string name = Console.ReadLine();
            Console.WriteLine($"That is one badass name, {name}!");
            Console.WriteLine($"Tell me {name}.. Have you played Tramwrecked before? Answer 'yes' or 'no'.");

            while (true)
            {
                answer = Console.ReadLine();

                if (answer == "yes")
                {
                    break;
                }

                if (answer == "no")
                {
                    break;
                }


                Console.WriteLine("404 error. Please, try typing your answer again.");
            }


            if (answer == "yes")
            {
                while (true)
                {

                    Console.WriteLine("Still want to read the instructions? Answer 'yes' or 'no'.");

                    var instructions = Console.ReadLine();

                    if (instructions == "yes")
                    {
                        break;
                    }

                    if (instructions == "no")
                    {
                        break;
                    }

                    Console.WriteLine("Try typing 'yes' or 'no', would ya?");

                }
            }
            
                    Console.WriteLine($"The yes, yes answerer needs to end up here as well.");
                    Console.WriteLine($"Let me explain to you how this works.. You are the tram driver, {name}");
                    Console.Clear();
                    Console.WriteLine("Excellent. Let's get going!");

                }
            }
        }