// Problem 1. Declare Variables
// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, 
// ushort, int, uint, long, ulong  to represent the following values:  52130, -115, 4825932, 97, -10000 .
// Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

//Submit the source code of your Visual Studio project as part of your homework submission.

namespace Problem01DeclareVariables
{
    class DeclareVariables
    {
        static void Main()
        {
            ushort variable1 = 52130; 
            sbyte variable2 = -115; 
            uint variable3 = 4825932u; 
            byte variable4 = 97;
            short variable5 = -10000; 
        }
    }
}
