using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    class MorseToAlpha : ITranslation
    {

        Dictionary<string, char> morseCode;

        /// <summary>
        /// populates the morseCode dictionary with the "code" as the key and the letter as the value
        /// </summary>
        public MorseToAlpha()
        {
            morseCode = new Dictionary<string, char>()
            {
                {".-",'a'},{"-...",'b'},{"-.-.",'c'},{"-..",'d'},{".",'e'},{"..-.",'f'},
                {"--.",'g'},{"....",'h'},{"..",'i'},{".---",'j'},{"-.-",'k'},{".-..",'l'},
                {"--",'m'},{"-.",'n'},{"---",'o'},{".--.",'p'},{"--.-",'q'},{".-.",'r'},
                {"...",'s'},{"-",'t'},{"..-",'u'},{"...-",'v'},{".--",'w'},{"-..-",'x'},
                {"-.--",'y'},{"--..",'z'}
            };
        }

        /// <summary>
        /// executes the main program to enter one code letter at a time.
        /// then adds the character to the outPut list and prints the list.
        /// </summary>
        public void Execute()
        {
            bool stop = false;
            List<string> input = new List<string>();
            List<char> outPut = new List<char>();

            // gets one code letter at a time.
            while(!stop)
            {
                Console.WriteLine("Enter the code one letter at a time: ");
                input.Add(Console.ReadLine());
                Console.WriteLine("Add another letter? y/n");
                if(Console.ReadLine().ToLower() == "n")
                {
                    stop = true;
                }
            }

            Console.Write("The word is: "); 

            for(int i=0;i<input.Count;i++)
            {
                if(morseCode.ContainsKey(input[i]))
                {
                    outPut.Add(morseCode[input[i]]);
                }
                Console.Write(outPut[i]);
            }
            Console.WriteLine();

        }
    }
}
