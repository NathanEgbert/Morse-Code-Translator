using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorseCodeTranslator.Library;

namespace TranslatorConsole
{
    public class OutPut
    {

        /// <summary>
        /// Translates the users input to Morse code,
        /// and returns the morse code output.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string AlphaToMorseOutPut(string input)
        {

            Translator translator = new Translator();

            string outPut = translator.ConvertALphaToMorse(input);

            return outPut;

        }

        /// <summary>
        /// Translates the users input to a alpha character,
        /// and returns the character output.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public char MorseToAlphaOutPut(string input)
        {

            Translator translator = new Translator();


            char outPut = translator.ConvertMorseToAlpha(input);

            return outPut;

        }

    }
}
