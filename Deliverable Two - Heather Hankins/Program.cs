using System;

namespace Deliverable_Two___Heather_Hankins
{
    class Program
    {
        static void Main(string[] args)
        {
            bool somethingElse = true;


            Console.WriteLine("Hello! My name is ChatBot. I hope you are doing well today.");
            Console.WriteLine();
            string storedInput = "";

            do
            {
                Console.WriteLine("Is there something you would like to say to me?");
                string userInput = Console.ReadLine();
                string userInput1 = userInput.ToLower();

                if (userInput1 == "bye")
                {
                    return;
                }

                else if (userInput == storedInput)
                {
                    Console.WriteLine();
                    Console.WriteLine("I'm sorry, but you have already said that.");
                    Console.WriteLine();
                    Console.WriteLine();
                }

                else if (userInput1 == "hello")
                {
                    Console.WriteLine();
                    Console.WriteLine("Hi good to see you");
                    Console.WriteLine();
                    Console.WriteLine();
                }


                else if (userInput1 == "sup")
                {
                    Console.WriteLine();
                    Console.WriteLine("I am good");
                    Console.WriteLine();
                    Console.WriteLine();
                }

                else if (userInput1 == "hello there")
                {
                    Console.WriteLine();
                    Console.WriteLine("General Kenobi");
                    Console.WriteLine();
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine();
                    Console.WriteLine("I'm sorry - I don't understand.");
                    Console.WriteLine();
                    Console.WriteLine();
                }

                    storedInput = userInput1;

                } while (somethingElse) ;
            
       
        }
    }
}
