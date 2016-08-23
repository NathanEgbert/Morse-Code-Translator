using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MorseCodeTranslator
{
    class AlphaToMorse : ITranslation
    {

        Dictionary<char, string> morseCode;


        /// <summary>
        /// fills the morse code values and letters
        /// </summary>
        public AlphaToMorse()
        {
            
            morseCode = new Dictionary<char, string>()
            {
                {'a',".-"},{'b',"-..."},{'c',"-.-."},{'d',"-.."},{'e',"."},{'f',"..-."},
                {'g',"--."},{'h',"...."},{'i',".."},{'j',".---"},{'k',"-.-"},{'l',".-.."},
                {'m',"--"},{'n',"-."},{'o',"---"},{'p',".--."},{'q',"--.-"},{'r',".-."},
                {'s',"..."},{'t',"-"},{'u',"..-"},{'v',"...-"},{'w',".--"},{'x',"-..-"},
                {'y',"-,--"},{'z',"--.."}
            };
        }

       
        /// <summary>
        /// gets the word or phrase and translates it to morse code by adding the code value to a list and prints the list at the end.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("Enter your word/Phrase: ");
            string input = Console.ReadLine().ToLower();

            // takes the white space out of the string.
            input = Regex.Replace(input, @"\s", "");
            
            // stores the morse code values 
            List<string> outPut = new List<string>();


            for (int i = 0; i < input.Length; i++)
            {

                if (morseCode.ContainsKey(input[i]))
                {
                    outPut.Add(morseCode[input[i]]);
                }
                Console.Write(outPut[i] + "  ");
            }
            Console.WriteLine();


        }




    }
}
