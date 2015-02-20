using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem04
{

    class Program
    {
        static int GetCode(char ch)
        {
            ch = Char.ToUpper(ch);
            return ch - 'A';
        }
        static string Encrypt(string message, string crypter)
        {
            StringBuilder res = new StringBuilder();

            if (message.Length >= crypter.Length)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    int temp = (GetCode(message[i]) ^ GetCode(crypter[i % crypter.Length])) + 65;
                    res.Append((char)temp);
                }
            }
            else
            {
                for (int i = 0; i < message.Length; i++)
                {
                    int temp = (GetCode(message[i]) ^ GetCode(crypter[i])) + 65;

                    int n = 1;
                    while (i + (n * message.Length) < crypter.Length)
                    {
                        temp = (GetCode((char)temp) ^ GetCode(crypter[i + (n * message.Length)])) + 65;
                        n++;
                    }

                    res.Append((char)temp);
                }
            }

            return res.ToString();
        }

        static string Decrypt(string message, string crypter)
        {
            return Encrypt(message, crypter);
        }

        static string Encode(string message)
        {
            StringBuilder res = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                int n = 1;

                while ((i + 1 < message.Length) && message[i] == message[i + 1])
                {
                    n++;
                    i++;
                }

                if (n == 1)
                {
                    res.Append(message[i]);
                }
                else if (n == 2)
                {
                    res.Append(message[i]);
                    res.Append(message[i]);
                }
                else
                {
                    res.Append(n);
                    res.Append(message[i]);
                }

            }

            return res.ToString();
        }

        static string Decode(string message)
        {
            StringBuilder res = new StringBuilder();

            for (int i = 0; i < message.Length; i++)
            {
                int n = 0;
                int startPos = i;
                while (Char.IsDigit(message[i]))
                {
                    n++;
                    i++;
                }

                if ((!Char.IsDigit(message[i])) && (n == 0))
                {
                    res.Append(message[i]);
                }
                else if (n != 0)
                {
                    for (int j = 0; j < int.Parse(message.Substring(startPos, n)); j++)
                    {
                        res.Append(message[i]);
                    }
                }
            }

            return res.ToString();
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int i;

            for (i = input.Length - 1; i >= 0; i--)
            {
                if (!Char.IsDigit(input[i]))
                {
                    break;
                }
            }

            int cryptStrLen = input.Length - i - 1;
            int cryptLen = int.Parse(input.Substring((input.Length - cryptStrLen), cryptStrLen));
            input = input.Substring(0, input.Length - cryptStrLen);
            input = Decode(input);

            string crypter = input.Substring(input.Length - cryptLen, cryptLen);
            string crypedMes = input.Substring(0, input.Length - cryptLen);

            Console.WriteLine(Decrypt(crypedMes, crypter));
        }
    }

}
