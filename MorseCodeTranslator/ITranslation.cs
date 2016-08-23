using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    interface ITranslation
    {

        /// <summary>
        /// calls the execute method in either MorseToAlpha or AlphaToMorse class
        /// </summary>
        void Execute();

    }
}
