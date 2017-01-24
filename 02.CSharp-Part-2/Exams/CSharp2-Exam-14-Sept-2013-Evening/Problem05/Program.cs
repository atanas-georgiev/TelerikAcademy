using System;

class FeaturingWithGrisko
{
    static int resultCount = 0;
    static int[] isUsed;

    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        string inputString= "";

        for (int i = 0; i < input; i++) inputString += Console.ReadLine();
        isUsed = new int[26];

        for (int i = 0; i < inputString.Length; i++)
        {
            isUsed[inputString[i] - 'a']++;
        }

        if (!OnlyUniqueLetters())
        {
            char[] output = new char[inputString.Length];
            GetComb(output, 0);
            Console.WriteLine(resultCount);
        }
        else
        {
            Console.WriteLine(FactCalc(inputString.Length));
        }
    }

    static int FactCalc(int n)
    {
        int currFact = 1;
        for (int i = 2; i <= n; i++)
        {
            currFact = currFact * i;
        }

        return currFact;
    }
    static bool OnlyUniqueLetters()
    {
        for (int i = 0; i < isUsed.Length; i++)
        {
            if (isUsed[i] > 1)
            {
                return false;
            }
        }
        return true;
    }
    static void GetComb(char[] output, int index)
    {
        if (index == output.Length)
        {
            if (IsValidWord(output))
            {
                resultCount++;
            }
            return;
        }

        for (int i = 0; i < isUsed.Length; i++)
        {
            if (isUsed[i] > 0)
            {
                output[index] = (char)(i + 'a');
                isUsed[i]--;
                GetComb(output, index + 1); /* recursive call to generate the 
                rest of the permutations the rest of the words */
                isUsed[i]++;
                // after the recursion return the letter so it can be again
                // in the next permutation
            }
        }
    }

    static bool IsValidWord(char[] input)
    {
        // IsValidWord checks if the word has two neighbouring letters are the same
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input[i] == input[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}