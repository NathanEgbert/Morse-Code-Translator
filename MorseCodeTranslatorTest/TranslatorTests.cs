using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorseCodeTranslator.Library;


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
        public void ChooseConversionTypeMorseInput()
        {
            Translator translator = new Translator();

            string inputMorse = "...";
            
            string outPutMorse = translator.ChooseConversionType(inputMorse);
            
            Assert.AreEqual("s", outPutMorse);
            
        }
        
        [TestMethod]
        public void ChooseConversionTypeAlpaInput()
        {
            Translator translator = new Translator();

            string inputAlpha = "sos";

            string outPutAlpha = translator.ChooseConversionType(inputAlpha);

            Assert.AreEqual("...---...", outPutAlpha);

        }

    

        
    }
}
