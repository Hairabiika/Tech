namespace Tech
{
    using System;
    using System.Linq;

    public class RecursiveFibonacci
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(recursiveFibonacci(n));
        }

        public static int recursiveFibonacci (int n)
        {
            if (n == 1) { return 1; }
            if (n == 2) { return 1; }
            int final = recursiveFibonacci(n - 1) + recursiveFibonacci(n - 2);
            return final;
        }
    }
}