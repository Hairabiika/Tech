namespace Tech
{
    using System;
    using System.Text;

    public class NameOfDigit
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int digit = number % 10;

            if (digit == 0) { Console.WriteLine("zero"); }
            if (digit == 1) { Console.WriteLine("one"); }
            if (digit == 2) { Console.WriteLine("two"); }
            if (digit == 3) { Console.WriteLine("three"); }
            if (digit == 4) { Console.WriteLine("four"); }
            if (digit == 5) { Console.WriteLine("five"); }
            if (digit == 6) { Console.WriteLine("six"); }
            if (digit == 7) { Console.WriteLine("seven"); }
            if (digit == 8) { Console.WriteLine("eight"); }
            if (digit == 9) { Console.WriteLine("nine"); }
        }
    }
}
