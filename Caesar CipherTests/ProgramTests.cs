using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caesar_Cipher;
using System;
using System.Collections.Generic;
using System.Text;

namespace Caesar_Cipher.Tests
{
    [TestClass()]
    public class ProgramTests
    {

        [TestMethod()]
        public void EncryptTest()
        {
            string textToEncrypt = "ABC";
            int shift = 2;
            int sumOfTheAlphabet = 26;

            string expectedResult = "CDE";

            string cipherText = Program.Encrypt(textToEncrypt, shift, sumOfTheAlphabet);

            Assert.AreEqual(cipherText, expectedResult);
        }

        [TestMethod()]
        public void DecryptTest()
        {
            string textToDecrypt = "CDE";
            int shift = 2;
            int sumOfTheAlphabet = 26;

            string expectedResult = "ABC";

            string cipherText = Program.Decrypt(textToDecrypt, shift, sumOfTheAlphabet);

            Assert.AreEqual(cipherText, expectedResult);
        }

        [TestMethod()]
        public void CipherTest()
        {
            char character = 'A';
            int shift = 2;
            int sumOfTheAlphabet = 26;

            char expectedResult = 'C';

            char cipherText = Program.Cipher(character, shift, sumOfTheAlphabet);

            Assert.AreEqual(cipherText, expectedResult);
        }
    }
}