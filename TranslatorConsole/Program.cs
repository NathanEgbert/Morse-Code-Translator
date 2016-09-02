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
            //creates a new translator instance 
            Translator translator = new Translator();

            Console.WriteLine("Enter intput: ");
            string userInput = Console.ReadLine();

            //saves the result from the translation
            string results = translator.ConvertInput(userInput);

            Console.WriteLine(results);

        }
    }
}
