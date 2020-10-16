using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueGame = true;

            Console.WriteLine("Welcome to the Pig Latin Translator.\n\n Please enter a word: ");

            while (continueGame)
            {
                
                string userWord = Console.ReadLine();
                int numLeadCons;

                //conditionals for translating only one word
                if (userWord[0] == 'a'|| userWord[0] == 'e' || userWord[0] == 'i'
                    || userWord[0] == 'o' || userWord[0] == 'u')
                {
                    userWord = userWord + "way";
                }
                else
                {
                    for(int i = 0; i<userWord.Length; i++)
                    {
                        if (userWord[0] == 'a' || userWord[0] == 'e' || userWord[0] == 'i'
                    || userWord[0] == 'o' || userWord[0] == 'u')
                        {
                            break;
                        }
                        else
                        {
                            userWord = userWord.Substring(1, userWord.Length - 1) + userWord[0];
                        }

                        

                    }
                    userWord = userWord + "ay";
                }

                Console.WriteLine($"\nYour new word is {userWord}");

                do
                {
                    Console.WriteLine("Would you like to continue (y/n)?");

                    ConsoleKey inputKey = Console.ReadKey().Key;

                    if (inputKey == ConsoleKey.Y)
                    {
                        break;
                    }
                    else if (inputKey == ConsoleKey.N)
                    {
                        continueGame = false;
                        break; //takes us out of the do while loop
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Please try again.");
                        continue;
                    }
                } while (true);


            }

        }
    }
}
