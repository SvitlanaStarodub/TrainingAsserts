namespace Calculator
{
    using System;

    /// <summary>
    /// Provides constants and static methods for common mathematical functions.
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Represents the largest possible value of operand in Calculator object. This field is constant.
        /// </summary>
        public const int MaxValue = 100000000;

        /// <summary>
        /// Represents the smallest possible value of operend in Calculator object. This field is constant.
        /// </summary>
        public const int MinValue = -100000000;

        public static int Addition(int x, int y)
        {
            VerifyOperands(x, y);
            int result = x + y;
            return result;
        }

        public static int Subtraction(int x, int y)
        {
            VerifyOperands(x, y);
            int result = x - y;
            return result;
        }

        public static long Multiplication(int x, int y)
        {
            VerifyOperands(x, y);
            long result = x * y;
            return result;
        }

        public static int Division(int x, int y)
        {
            VerifyOperands(x, y);
            int result = x / y;
            return result;
        }

        private static void VerifyOperands(int x, int y)
        {
            if (x > MaxValue || x < MinValue)
            {
                throw new ArgumentException($"Operand X is invalid. Acceptable range from {MinValue} to {MaxValue}!");
            }

            if (y > MaxValue || y < MinValue)
            {
                throw new ArgumentException($"Operand Y is invalid. Acceptable range from {MinValue} to {MaxValue}!");
            }
        }
    }
}
 