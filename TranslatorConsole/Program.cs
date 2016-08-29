using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorseCodeTranslator.Library;

namespace TranslatorConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            OutPut outPut = new OutPut();

            //Prompts the user to choose wich conversion type they want.
            Console.WriteLine("Enter 1 for Alpha to morse, or 2 for Morse to alpha: ");
            string userChoice = Console.ReadLine();

            //Picks the correct prompt and translator type depending upon the users choice of conversion type.
            switch (userChoice)
            {
                case "1":
                   Console.Write("Enter the charater to be converted to morse code: ");
                   string alphaInput = Console.ReadLine();
                   string morseOutPut = outPut.AlphaToMorseOutPut(alphaInput);
                   Console.WriteLine(morseOutPut);
                    break;

                default:
                   Console.Write("Enter the morse code to be converted to alpha characters: ");
                   string morseInput = Console.ReadLine();
                   char alphaOutPut = outPut.MorseToAlphaOutPut(morseInput);
                   Console.WriteLine(alphaOutPut);
                    break;
            }

            

        }
    }
}
