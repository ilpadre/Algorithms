namespace Factorial
{
    public static class Fact
    {
        public static long Factorial(long n)
        {
            if (n > 0)
            {
                return n * Factorial(n - 1);
            }
            return 1;
        }
    }
}
