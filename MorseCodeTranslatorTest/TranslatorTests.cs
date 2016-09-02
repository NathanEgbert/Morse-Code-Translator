using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorseCodeTranslator.Library;
using System.Text.RegularExpressions;


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

            string alphaConversion = translator.ConvertMorseToAlpha(morseInput);

            Assert.AreEqual("a", alphaConversion);

        }

        [TestMethod]
        public void ConversionInputMorse()
        {
            Translator translator = new Translator();

            string inputMorse = "...";
            
            string outPutMorse = translator.ConvertInput(inputMorse);
            
            Assert.AreEqual("s", outPutMorse);
            
        }

        [TestMethod]
        public void ConversionInputAlpha()
        {
            Translator translator = new Translator();

            string inputAlpha = "s";

            string outPutAlpha = translator.ConvertInput(inputAlpha);

            Assert.AreEqual("...", outPutAlpha);

        }

        [TestMethod]
        public void ConversionInputMorseMapNotFound()
        {
            Translator translator = new Translator();

            string morseInput = "..........";

            string result = translator.ConvertInput(morseInput);

            Assert.AreEqual("No match found.",result);
        }

        [TestMethod]
        public void ConversionInputInvalidInput()
        {
            Translator translator = new Translator();

            string invalidInput = "!@#";

            string result = translator.ConvertInput(invalidInput);

            Assert.AreEqual("Invalid input", result);
        }
    }
}
