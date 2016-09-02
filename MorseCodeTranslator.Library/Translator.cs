using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MorseCodeTranslator.Library
{
    public class Translator
    {

        Dictionary<char, string>
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
                {'y',"-.--"},
                {'z',"--.."}
            };

        Dictionary<string, char>
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

            /* searches if the alphaToMorse Dictionary contains the alphaChar key,
             * and if it does it returns the morse code representation of that alpha character
             */
            if (alphaToMorse.ContainsKey(alphaChar))
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
        /// and returns the Alpha translation as a string.
        /// </summary>
        /// <param name="morseInput"></param>
        /// <returns></returns>
        public string ConvertMorseToAlpha(string morseInput)
        {
            //Searches for the Morse Code key and returns the alpha character version of it
            if (morseToAlpha.ContainsKey(morseInput))
            {
                string result = morseToAlpha[morseInput].ToString();
                return result;
            }
            else
            {
                return string.Empty;
            }

        }

        /// <summary>
        /// Takes the users input and decides which conversion type to use Alpha to Morse,
        /// or Morse to Alpha.
        /// Calls the appropriate method and then returns the converted results.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string ConvertInput(string input)
        {

            

            bool charMatch = Regex.IsMatch(input, "[a-zA-Z]");
            bool morseMatch = Regex.IsMatch(input, "^[.-]*$");

            // checks if charMatch is true
            if (charMatch)
            {
                string morseResult = ConvertALphaToMorse(input);

                if (morseResult == string.Empty)
                {
                    return "No match found.";
                }
                else
                {
                    return morseResult;
                }

            }
            
            //checks if morseMatch is true
            else if (morseMatch)
            {
                string alphaResult = ConvertMorseToAlpha(input);


                if (alphaResult == string.Empty)
                {
                    return "No match found.";
                }
                else
                {
                    return alphaResult;
                }
            }

            else
            {
                return "Invalid input";
            }
        }
    }
}
