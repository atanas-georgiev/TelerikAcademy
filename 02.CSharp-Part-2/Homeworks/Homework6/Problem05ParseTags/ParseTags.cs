//Problem 5. Parse tags

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a yellow submarine. We don't have anything else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Text;

namespace Problem05ParseTags
{
    class ParseTags
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            bool bOpenBracket = false;
            bool bCloseBracket = false;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                switch (ch)
                {
                    case '>':
                        if (true == bCloseBracket)
                        {
                            bCloseBracket = false;
                            bOpenBracket = false;
                        }
                        else
                        {
                            bOpenBracket = true;
                        }
                        output.Append(ch);
                        break;
                    case '<':
                        if (input[i + 1] == '/') bCloseBracket = true;
                        output.Append(ch);
                        break;
                    default:
                        if (true == bOpenBracket)
                        {
                            output.Append(ch.ToString().ToUpper());
                        }
                        else
                        {
                            output.Append(ch);
                        }
                        break;
                }
            }

            Console.WriteLine(output);
        }
    }
}
