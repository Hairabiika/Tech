namespace Tech
{
    using System;
    using System.Text;

    public class StrongNumber
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int current = 0;
            int sum = 1;
            int sameNumber = number;
            int totalSum = 0;

            while (sameNumber > 0)
            {
                current = sameNumber % 10;
                sameNumber /= 10;
                sum = 1;

                for (int i = 1; i <= current; i++) { sum *= i;  }
                totalSum += sum;
            }

            if (totalSum == number) { Console.WriteLine("yes"); }
            else { Console.WriteLine("no"); }
        }
    }
}
