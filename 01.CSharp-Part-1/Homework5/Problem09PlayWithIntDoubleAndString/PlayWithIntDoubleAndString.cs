//Problem 9. Play with Int, Double and String
//• Write a program that, depending on the user’s choice, inputs an  int ,  double  or  string  variable. ◦ If the variable is  int  or  double , the program increases it by one.
//◦ If the variable is a  string , the program appends  *  at the end.
//• Print the result at the console. Use switch statement.

using System;

namespace Problem09PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type:\n 1 --> int\n 2 --> double \n 3 --> string \n");
            ConsoleKeyInfo k = Console.ReadKey();

            if (k.KeyChar == '1')
            {
                Console.WriteLine("\nPlease enter int: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}",a+1);
            }
            else if (k.KeyChar == '2')
            {
                Console.WriteLine("\nPlease enter double: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", a + 1);
            }
            else if (k.KeyChar == '3')
            {
                Console.WriteLine("\nPlease enter a string: ");
                string a = Console.ReadLine();
                Console.WriteLine("Result: {0}*", a);
            }
            else
            {
                Console.WriteLine("\nInvalid key pressed!");
            }

        }
    }
}
