using System;
using System.ComponentModel.DataAnnotations;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueGame = true;

            Console.WriteLine("Welcome to the Pig Latin Translator.");

            while (continueGame)
            {

                Console.WriteLine("\nPlease enter a word: ");

                string userWord = Console.ReadLine();
                bool titleCase = false; //a check for words with leading consonants

                if (char.IsUpper(userWord[0]) && char.IsLower(userWord[1])){
                    titleCase = true;
                }
                

                //conditionals for translating only one word
                //can we simplify the below comparison
                if (userWord[0] == 'a' || userWord[0] == 'A'|| 
                    userWord[0] == 'e' || userWord[0] == 'E'|| 
                    userWord[0] == 'i' || userWord[0] == 'I'||
                    userWord[0] == 'o' || userWord[0] == 'O'|| 
                    userWord[0] == 'u' || userWord[0] == 'U')
                {
                    //userWord = userWord + "way";

                    //HOW CAN I ADJUST to make the output consistent with how the user input
                    //i.e. input = OUT; translate into OUTWAY (instead of OUTway)

                    if (char.IsUpper(userWord[0]) && char.IsUpper(userWord[1])) //all uppper
                    {
                        userWord = userWord + "WAY";

                    }
                    else
                    {
                        userWord = userWord + "way"; //all lower case
                    }

                }
                else
                {
                    for(int i = 0; i<userWord.Length; i++)
                    {
                        if (userWord[0] == 'a' || userWord[0] == 'A' ||
                            userWord[0] == 'e' || userWord[0] == 'E' ||
                            userWord[0] == 'i' || userWord[0] == 'I' ||
                            userWord[0] == 'o' || userWord[0] == 'O' ||
                            userWord[0] == 'u' || userWord[0] == 'U')
                        {
                            break;
                        }
                        else
                        {
                            userWord = userWord.Substring(1, userWord.Length - 1) + userWord[0];
                        }
                    }

                    if (char.IsUpper(userWord[0])) 
                    //check if this was an all upper case - this assumes that if the second letter (now index 0) is upper, then entire word was upper
                    {
                        userWord = userWord + "AY";

                    }
                    else if (titleCase) 
                    //title case - if the consonant 
                    {
                        userWord = userWord.Substring(0, 1).ToUpper() + userWord.Substring(1, userWord.Length - 1).ToLower() + "ay";

                    }
                    else //all lower case
                    {
                        userWord = userWord + "ay";
                    }
                    //userWord = userWord + "ay";
                }

                Console.WriteLine($"\nYour new word is {userWord}");

                //conditionals for translating a sentence

                do
                {
                    Console.WriteLine("\nWould you like to translate other words (y/n)?");

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
