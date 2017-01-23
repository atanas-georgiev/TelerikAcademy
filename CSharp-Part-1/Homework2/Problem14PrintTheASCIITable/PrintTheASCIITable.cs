using System;

namespace Problem14PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.ASCII;
            
            for (char c = (char)0; c <= (char)255; c++)
            {
                Console.WriteLine(c);
            }
        }
    }
}
