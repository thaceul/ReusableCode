using System;

namespace AdvancedMath3448
{
    public class Calculator
    {

        public static int Factorial(int input)
        {
            int result;
            if (input <= 1)
                return 1;
             result = input * Factorial(input - 1);
            return result;
        }
    }
}
