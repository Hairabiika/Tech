namespace Tech
{
    using System;
    public class PrintAndSum
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumer = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = firstNumber; i <= secondNumer; i++)
            {
                sum += i;
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
