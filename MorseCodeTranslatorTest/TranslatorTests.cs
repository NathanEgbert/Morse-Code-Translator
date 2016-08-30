using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorseCodeTranslator.Library;
using TranslatorConsole;



namespace MorseCodeTranslatorTest
{
    [TestClass]
    public class TranslatorTests
    {
        [TestMethod]
        public void AlphaToMorse()
        {

            Translator translator = new Translator();

            string alphaInput = "s";

            string morseConversion = translator.ConvertALphaToMorse(alphaInput);

            Assert.AreEqual("...",morseConversion);

        }

        [TestMethod]
        public void MorseToAlpha()
        {
            Translator translator = new Translator();

            string morseInput = ".-";

            char alphaConversion = translator.ConvertMorseToAlpha(morseInput);

            Assert.AreEqual('a', alphaConversion);

        }

        
    }
}
