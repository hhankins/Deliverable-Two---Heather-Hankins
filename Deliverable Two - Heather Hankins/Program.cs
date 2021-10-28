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

            do
            {
                Console.WriteLine("Is there something you would like to say to me?");
                string userInput = Console.ReadLine();
                string userInput1 = userInput.ToLower();

                if (userInput1 == "bye")
                {
                    return;
                }

                if (userInput1 == "hello")
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

            } while (somethingElse);

            Console.WriteLine("Is there something you would like to say to me?");
            string somethingElse1 = Console.ReadLine();

            if (somethingElse1.ToLower() == "hello" || somethingElse1.ToLower() == "sup" || somethingElse1.ToLower() == "hello there")
            {
                somethingElse = true;
            }
            else
            {
                somethingElse = false;
            }

        } 
    }
}
        //Console.WriteLine("I'm sorry, but you have already said that."); 