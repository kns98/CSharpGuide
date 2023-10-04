using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGuide
{
    using System;

    class XORKeyClass
    {
        // Define XOR key as a static readonly character array
        static readonly char[] XORKey = { 'F', 'P', 'k', 'k', 'Y', 'P', 'l', 'p', 'V', 'P', 'L', 'z' };

        static void Main16()
        {
            // Define the sample string containing the message to be encrypted and decrypted
            string sampleString = " This contains highly sensitive message\n" +
                                  " coordinates : 23.445, 34.443\n" +
                                  " All further messages MUST be sent via\n" +
                                  " XOR encryption only - D Day to be announced soon!!\n";

            // Encrypt the sample string and print the encrypted string
            Console.WriteLine("\nEncrypted String:\n");
            var encryptedString = EncryptDecrypt(sampleString);
            Console.WriteLine(encryptedString);

            // Decrypt the encrypted string and print the decrypted string
            Console.WriteLine("\nDecrypted String:\n");
            var decryptedString = EncryptDecrypt(encryptedString);
            Console.WriteLine(decryptedString);
        }

        // Define a method to perform XOR encryption or decryption on the input string
        static string EncryptDecrypt(string inputString)
        {
            // Convert the input string to a character array
            char[] inputChars = inputString.ToCharArray();

            // Perform XOR operation on each character in the array
            for (int i = 0; i < inputChars.Length; i++)
            {
                // XOR each character in the input string with the corresponding character in the XOR key
                // If the input string is longer than the XOR key, the key is repeated
                inputChars[i] = (char)(inputChars[i] ^ XORKey[i % XORKey.Length]);
            }

            // Convert the character array back to a string and return it
            return new string(inputChars);
        }
    }

}
