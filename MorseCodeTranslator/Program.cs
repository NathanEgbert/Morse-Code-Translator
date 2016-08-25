using MorseCodeTranslator.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {

            Translator translator = new Translator();

            Console.WriteLine("To translate to morse code press 1. \nTo translater from morse code press 2.");
            string input = Console.ReadLine();

            // chooses the correct class in which to call the correct execute method.
            switch(input)
            {
                case "1":
                   // translate = new AlphaToMorse();
                    break;

                default:
                    //translate = new MorseToAlpha();
                    break;

            }



            
        }
      
    }
}
