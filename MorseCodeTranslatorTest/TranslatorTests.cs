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

            string alphaInput = "a";

            string morseConversion = translator.ConvertALphaToMorse(alphaInput);

            Assert.AreEqual(".-",morseConversion);

        }

        [TestMethod]
        public void MorseToAlpha()
        {
            Translator translator = new Translator();

            string morseInput = ".-";

            char alphaConversion = translator.ConvertMorseToAlpha(morseInput);

            Assert.AreEqual('a', alphaConversion);

        }

        [TestMethod]
        public void AlphaToMorseOutput()
        {
            OutPut outPut = new OutPut();

            string userinput = "a";

           string result = outPut.AlphaToMorseOutPut(userinput);

           Assert.AreEqual(".-", result);       

        }

        [TestMethod]
        public void MorseToAlphaOutput()
        {
            OutPut outPut = new OutPut();

            string userinput = ".-";

            char result = outPut.MorseToAlphaOutPut(userinput);

            Assert.AreEqual('a', result);

        }
    }
}
