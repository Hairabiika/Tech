namespace Tech
{
    using System;
    using System.Linq;

    public class AddAndSubtract
    {
        public static int add (int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }

        public static int substract (int firstNumber, int secondNumber, int thirdNumber)
        {
            int sum = add(firstNumber, secondNumber);
            sum -= thirdNumber;
            return sum;
        }

        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(substract(firstNumber, secondNumber, thirdNumber));
        }
    }
}
