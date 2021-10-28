using System;

namespace Deliverable_Two___Heather_Hankins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! My name is ChatBot. I hope you are doing well today.");
            Console.WriteLine();

            while ()
                Console.WriteLine("Is there something you would like to say to me?");
                Console.WriteLine();
                string userInput1 = Console.ReadLine();

                if (userInput1 == "bye")
                {
                    return;
                }

                if (userInput1 == "hello")
                {
                    Console.WriteLine();
                    Console.WriteLine("Hi good to see you");
                    Console.WriteLine();
                }

                else if (userInput1 == "sup")
                {
                    Console.WriteLine();
                    Console.WriteLine("I am good");
                    Console.WriteLine();
                }

                else (userInput1 == "hello there")
                {
                    Console.WriteLine();
                    Console.WriteLine("General Kenobi");
                    Console.WriteLine();
                }
        }
    }
}




        //Console.WriteLine("I'm sorry, but you have already said that. Is there something else you would like to say to me?");

      