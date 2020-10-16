using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueGame = true;

            while (continueGame)
            {
                Console.WriteLine("Welcome to the Pig Latin Translator.\n Please enter a word: ");

                string userWord = Console.ReadLine();

                //string[] words = userWord.Split(' ');

               
                //assume first character is not a space
                for(int i = 0; i<userWord.Length-1; i++)
                {

                    string x; 

                    if(userWord[i] == ' ')
                    {
                      
                    }


                }

                //array ["this", "is", "a", "list"]
                //arrayName[0]


                //switch (words[i][0])
                //{
                //    case 'a':
                //        words[i] = words[i] + "way";
                //        break;
                //    case 'e':
                //        words[i] = words[i] + "way";
                //        break;
                //    case 'i':
                //        words[i] = words[i] + "way";
                //        break;
                //    case 'o':
                //        words[i] = words[i] + "way";
                //        break;
                //    case 'u':
                //        words[i] = words[i] + "way";
                //        break;
                //    default:
                //        words[i] = words[i].Substring(1, words.Length - 1) + words[i][0] + "ay";
                //        break;
                //}

                //switch (userWord[0])
                //{
                //    case 'a':
                //        userWord = userWord + "way";
                //        break;
                //    case 'e':
                //        userWord = userWord + "way";
                //        break;
                //    case 'i':
                //        userWord = userWord + "way";
                //        break;
                //    case 'o':
                //        userWord = userWord + "way";
                //        break;
                //    case 'u':
                //        userWord = userWord + "way";
                //        break;
                //    default:
                //        userWord = userWord.Substring(1, userWord.Length - 1) + userWord[0] + "ay";
                //        break;
                //}

                //Console.WriteLine(userWord);

                do
                {
                    Console.WriteLine("Would you like to continue (y/n)?");

                    ConsoleKey inputKey = Console.ReadKey().Key;

                    if (inputKey == ConsoleKey.Y)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (inputKey == ConsoleKey.N)
                    {
                        continueGame = false;
                        break; //takes us out of the do while loop
                    }
                    else
                    {
                        Console.WriteLine("invalid input. Please try again.");
                        Console.Clear();
                        continue;
                    }
                } while (true);


            }

        }
    }
}
