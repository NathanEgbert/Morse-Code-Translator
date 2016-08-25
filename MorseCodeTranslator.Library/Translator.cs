using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorseCodeTranslator.Library
{
    public class Translator
    {

        Dictionary<char,string>
        alphaToMorse = new Dictionary<char, string>()
            {
                {'a',".-"},
                {'b',"-..."},
                {'c',"-.-."},
                {'d',"-.."},
                {'e',"."},
                {'f',"..-."},
                {'g',"--."},
                {'h',"...."},
                {'i',".."},
                {'j',".---"},
                {'k',"-.-"},
                {'l',".-.."},
                {'m',"--"},
                {'n',"-."},
                {'o',"---"},
                {'p',".--."},
                {'q',"--.-"},
                {'r',".-."},
                {'s',"..."},
                {'t',"-"},
                {'u',"..-"},
                {'v',"...-"},
                {'w',".--"},
                {'x',"-..-"},
                {'y',"-,--"},
                {'z',"--.."}
            };

        Dictionary<string,char>
        morseToAlpha = new Dictionary<string, char>()
            {
                {".-",'a'},
                {"-...",'b'},
                {"-.-.",'c'},
                {"-..",'d'},
                {".",'e'},
                {"..-.",'f'},
                {"--.",'g'},
                {"....",'h'},
                {"..",'i'},
                {".---",'j'},
                {"-.-",'k'},
                {".-..",'l'},
                {"--",'m'},
                {"-.",'n'},
                {"---",'o'},
                {".--.",'p'},
                {"--.-",'q'},
                {".-.",'r'},
                {"...",'s'},
                {"-",'t'},
                {"..-",'u'},
                {"...-",'v'},
                {".--",'w'},
                {"-..-",'x'},
                {"-.--",'y'},
                {"--..",'z'}
            };

        
        /// <summary>
        /// Converts Alpha Characters to Morse Code,
        /// and returns the morse code translation as a string.
        /// </summary>
        /// <param name="alphaInput"></param>
        /// <returns></returns>
        public string ConvertALphaToMorse(string alphaInput)
        {
            //converts the string input into a char
            char alphaChar = Convert.ToChar(alphaInput);

            /*searchs if the alphaToMorse Dictionary contains the alphaChar key,
             * and if it does it returns the morse code representation of that alpha character
             */
            if(alphaToMorse.ContainsKey(alphaChar))
            {
                return alphaToMorse[alphaChar];
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Converts Morse Code to its Alpha Character,
        /// and returns the Alpha translation as a character.
        /// </summary>
        /// <param name="morseInput"></param>
        /// <returns></returns>
        public char ConvertMorseToAlpha(string morseInput)
        {
            //Searches for the Morse Code key and returns the alpha character version of it
            if(morseToAlpha.ContainsKey(morseInput))
            {
                return morseToAlpha[morseInput];
            }
            else
            {
                return char.MinValue;
            }
            
        }
    }
}
