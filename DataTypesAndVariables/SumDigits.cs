namespace Tech
{
    using System;
    using System.Text;

    public class SumDigits
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sameNumber = number;
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine(sum);
        }
    }
}
