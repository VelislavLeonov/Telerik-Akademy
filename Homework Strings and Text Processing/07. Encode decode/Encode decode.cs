using System;
using System.Text;
/*Problem 7. Encode/decode

Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first 
 letter of the string with the first of the key, the second – with the second, 
etc. When the last key character is reached, the next is the first.*/
namespace _07.Encode_decode
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            Console.WriteLine("Enter key");
            string key = Console.ReadLine();
            StringBuilder encodedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                encodedText.Append((char)(text[i] ^ key[i % key.Length]));
            }
            Console.WriteLine("Encoded text: {0}", encodedText);
            StringBuilder decodedText = new StringBuilder();
            for (int i = 0; i < encodedText.Length; i++)
            {
                decodedText.Append((char)(encodedText[i] ^ key[i % key.Length]));
            }
            Console.WriteLine("Decoded text: {0}", decodedText);
        }
    }
}
