//Problem 10. Odd and Even Product
//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

namespace Problem10OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.WriteLine("Enter numbers separated with space");
            string str = Console.ReadLine();
            string[] numbers = str.Split(new Char[] { ' ' });
            int i = 0;
            int oddProduct = 1;
            int evenProduct = 1;

            foreach (string n in numbers)
            {
                if (i % 2 == 1)
                {
                    evenProduct *= int.Parse(n);
                }
                else
                {
                    oddProduct *= int.Parse(n);
                }
                i++;
            }

            if (evenProduct == oddProduct)
            {
                Console.WriteLine("result: yes, product = {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("result: no, odd_product = {0}, even_product = {1}", oddProduct, evenProduct);
            }
        }
    }
}
