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

                //Console.WriteLine("\n\nPlease enter a word: ");

                Console.WriteLine("\n\nPlease enter a word or phrase: ");

                string sentence = Console.ReadLine();

                //verify the user entered text!

                if (sentence.Equals(""))
                {
                    Console.WriteLine("Please input text: ");
                    continue;
                }


                string[] userWord = sentence.Split(' ');

                bool titleCase = false; //a check for words with leading consonants

                //this assumes if first character is upper and second is lower than this is title case

                //for a whole sentence, you'll need to put the below in a loop and change to [i][j]
                //if (char.IsUpper(userWord[0]) && char.IsLower(userWord[1])){
                //    titleCase = true;
                //}

                //conditionals for translating only one word
                //can we simplify the below comparison???

                //add for loop to look at all words individually within a sentence?? 
                //should we turn (split) the sentence into a string array, run the loop then use the join method?

                for (int j= 0; j < userWord.Length; j++)
                {

                    if (char.IsUpper(userWord[j][0]) && char.IsLower(userWord[j][1]))
                    {
                        titleCase = true;
                    }

                    if (userWord[j][0] == 'a' || userWord[j][0] == 'A' ||
                            userWord[j][0] == 'e' || userWord[j][0] == 'E' ||
                            userWord[j][0] == 'i' || userWord[j][0] == 'I' ||
                            userWord[j][0] == 'o' || userWord[j][0] == 'O' ||
                            userWord[j][0] == 'u' || userWord[j][0] == 'U')
                    {
                        //userWord = userWord + "way";

                        //HOW CAN I ADJUST to make the output consistent with how the user input
                        //i.e. input = OUT; translate into OUTWAY (instead of OUTway)

                        if (char.IsUpper(userWord[j][0]) && char.IsUpper(userWord[j][1])) //all uppper
                        {
                            userWord[j] = userWord[j] + "WAY";

                        }
                        else
                        {
                            userWord[j] = userWord[j] + "way"; //all lower case
                        }

                    }
                    else
                    {
                        for (int i = 0; i < userWord.Length; i++)
                        {
                            if (userWord[j][0] == 'a' || userWord[j][0] == 'A' ||
                                userWord[j][0] == 'e' || userWord[j][0] == 'E' ||
                                userWord[j][0] == 'i' || userWord[j][0] == 'I' ||
                                userWord[j][0] == 'o' || userWord[j][0] == 'O' ||
                                userWord[j][0] == 'u' || userWord[j][0] == 'U')
                            {
                                break;
                            }
                            else
                            {
                                userWord[j] = userWord[j].Substring(1, userWord[j].Length - 1) + userWord[j][0];
                            }
                        }

                        if (char.IsUpper(userWord[j][0]))
                        //check if this was an all upper case - this assumes that if the second letter (now index 0) is upper, then entire word was upper
                        {
                            userWord[j] = userWord[j] + "AY";

                        }
                        else if (titleCase)
                        //title case - if the consonant 
                        {
                            userWord[j] = userWord[j].Substring(0, 1).ToUpper() + userWord[j].Substring(1, userWord[j].Length - 1).ToLower() + "ay";

                        }
                        else //all lower case
                        {
                            userWord[j] = userWord[j] + "ay";
                        }
                        //userWord = userWord + "ay";
                    }
                }

                //need to join the items in the array back into a string
                //string s1 = string.Join(", ", array);

                sentence = string.Join(" ", userWord);

                //Console.WriteLine($"\nYour new word is {userWord}");

                Console.WriteLine($"\nYour new word or phrase is:\n\n{sentence}");

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
