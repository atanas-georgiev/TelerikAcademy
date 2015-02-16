//Problem 7. Encode/decode

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. 
//When the last key character is reached, the next is the first.

using System;
using System.Text;

namespace Problem07EncodeDecode
{
    class EncodeDecode
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter code: ");
            string code = Console.ReadLine();

            StringBuilder encripted = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                encripted.Append((char)(input[i] ^ code[i % code.Length]));
            }

            Console.WriteLine("Encripted: " + encripted);

            StringBuilder decript = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                decript.Append((char)(encripted[i] ^ code[i % code.Length]));
            }

            Console.WriteLine("Decripted: " + decript);
        }
    }
}
