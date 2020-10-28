using System;

namespace Caesar_Cipher
{
    class Program
    {
        /*
            Caesar cipher is a an old way of transfering secret information back in medieval times.
            
            The way it works is:
            You have a text such as this: "ABC" and the cipher has a shift, for example +2.
            
            Encrypted text will become: "CDE"
            
            If we decrypt, we get the same text as original - "ABC"

            Implement Caesar cipher (both encrypt and decrypt).
            Prove that your code works.
        */

        static void Main(string[] args)
        {
            int sumOfTheAlphabet = 26;                          /* an integer of the sum of letters in the english alphabet (26) */

            Console.WriteLine("Please enter a text to encrypt: ");
            string textToEncrypt = Console.ReadLine();

            Console.Write("Please enter an integer as cipher shift: ");
            int shift = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");


            string cipherText = Encrypt(textToEncrypt, shift, sumOfTheAlphabet);
            Console.WriteLine("This is a encrypted data of the entered text: {0} ", cipherText);

            Console.WriteLine("\n");

            string decryptedText = Decrypt(cipherText, shift, sumOfTheAlphabet);
            Console.WriteLine("This is a decrypted text (original): {0} ", decryptedText);

            Console.WriteLine("\n");
        }

        /// <summary>
        /// a method to encrypt data
        /// </summary>
        /// <param name = "textToEncrypt"> the text to be encrypted </param>
        /// <param name = "shift"> an integer which is used to shift letters </param>
        /// <param name = "sumOfTheAlphabet"> an integer of the sum of letters in the english alphabet (26) </param>
        /// <returns> this method returns an encrypted text </returns>

        public static string Encrypt(string textToEncrypt, int shift, int sumOfTheAlphabet)
        {
            string encryptedText = string.Empty;                        /* represents the empty string */

            foreach (char ch in textToEncrypt)
            {
                encryptedText += cipher(ch, shift, sumOfTheAlphabet);   /* encrypts every character (letter) using the cipher method */
            }

            return encryptedText;                                       /* returns the encrypted text */
        }

        /// <summary>
        /// a method to decrypt data
        /// </summary>
        /// <param name = "textToDecrypt"> an encrypted text provided for decryption </param>
        /// <param name = "shift"> an integer which is used to shift letters </param>
        /// <param name = "sumOfTheAlphabet"> an integer of the sum of letters in the english alphabet (26) </param>
        /// <returns> this method returns a decrypted text </returns>

        public static string Decrypt(string textToDecrypt, int shift, int sumOfTheAlphabet)
        {
            return Encrypt(textToDecrypt, sumOfTheAlphabet - shift, sumOfTheAlphabet);
        }

        /// <summary>
        /// a method to shift the characters according to the specified parameters
        /// </summary>
        /// <param name = "character"> a provided character to be checked and shifted </param>
        /// <param name = "shift"></param>
        /// <param name = "sumOfTheAlphabet"> an integer of the sum of letters in the english alphabet (26) </param>
        /// <returns> this method returns a shifted character </returns>

        public static char cipher(char character, int shift, int sumOfTheAlphabet)
        {
            if (!char.IsLetter(character))
            {                                                                          /* checking if a character is a letter */
                return character;
            }

            char ch = char.IsUpper(character) ? 'A' : 'a';                             /* checking if a letter is uppercase or not */

            return (char)((((character + shift) - ch) % sumOfTheAlphabet) + ch);       /* Individual characters are usually represented by numbers according to the ASCII code,
                                                                                        * so adding a number to a character can shift the character down.
                                                                                        * We need to limit the index to be within the valid range by using the modulo operator. */
        }
    }
}
