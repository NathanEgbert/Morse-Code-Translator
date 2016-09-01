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
            
            Translator translator = new Translator();

            Console.WriteLine("Enter intput: ");
            string userInput = Console.ReadLine();

            string results = translator.ChooseConversionType(userInput);

            Console.WriteLine(results);

        }
    }
}
