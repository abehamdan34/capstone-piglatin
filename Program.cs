using System;

namespace Pig_Latin_Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            //Labeled the vowels under char so it could be used later in the program because its single characters.
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            //labeling the input as userWord and using the method I created to make it lowercase while asking the question.
            string userWord = GetUserWord("Hello please enter a line!");

            //displaying the output
            Console.WriteLine($"you typed {userWord} I will try to convert it to Pig Latin!");


            // take in a word, if the word starts with a vowel, add way to it
            // if it doesnt start with a vowel, find the first vowel in the word, move the consonants 
            // before the first vowel to the end of the word and then add ay to it.

            // creates an array of words from the input and knows to SPLIT each word by looking for " " which is a space.
            //for loop that uses the string words that has an array using " " to identify each word starting at the first word with i = 0 and keeps going until is has all the words.
            string[] words = userWord.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                // now we will go thru the letters of each word, and find the first vowel
  
                if (words[i].IndexOfAny(vowels) == 0)
                {
                    // if the word starts with a vowel, add way to it
                    words[i] += "way";
                } 
                else
                {
                    // if the word doesnt start with a vowel.. find the vowel
                    if (words[i].IndexOfAny(vowels) > 0)
                    {
                        // create a variable that stores the amount of letters we need to move to the end
                        int index = words[i].IndexOfAny(vowels);
                        // now.. take the letters before the vowel at index and move it to the end
                        for (int j = 0; j < index; j++)
                        {
                            // go thru each letter before vowel
                            char letter = words[i].ToCharArray()[j];
                            // add letter to word
                            words[i] += letter;
                        }
                        // remove all the letters before the vowel
                        words[i] = words[i].Remove(0, index);
                        // add ay to the end of the word
                        words[i] += "ay";
                    }
                }
            }
            // Display the modified words. 
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");
            }

        }
        //method to take the users input and make it lowercase
        public static string GetUserWord(string userWord)
        {
            Console.WriteLine(userWord);
            string input = Console.ReadLine().ToLower();
            return input;
        }
    }
}

