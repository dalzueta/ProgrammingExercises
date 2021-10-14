namespace ProgramingKatasCSharp
{
    public class Recursivity
    {
        public string ReturnStringOfNNumbers(int low, int up) => (low >= up) ? low.ToString() : low + " - " + ReturnStringOfNNumbers(++low, up);

        public int CalcularSum(int val, int n) => (n == val) ? n : n + CalcularSum(val, ++n);

        public int CalcularSumOfNNumbers(int n) => (n < 1) ? n : n + CalcularSumOfNNumbers(--n);

        public int FactorialOf(int number) => (number <= 1) ? number : number * FactorialOf(--number);

        public string FibonacciOf(int number)
        {
            int i = 0, c;
            string result = "";

            for (c = 1; c <= number; c++)
            {
                result += Fibonacci(i);
                i++;
            }
            return result;
        }

        int Fibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return (Fibonacci(n - 1) + Fibonacci(n - 2));
        }


    }
}
