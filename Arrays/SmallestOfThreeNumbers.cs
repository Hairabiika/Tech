namespace Tech
{
    using System;
    using System.Linq;

    public class SmallestOfThreeNumbers
    {
        public static int smallest (int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber <= secondNumber && firstNumber <= thirdNumber) return firstNumber;
            if (secondNumber <= firstNumber && secondNumber <= thirdNumber) return secondNumber;
            else return thirdNumber;
        }
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(smallest(firstNumber,secondNumber,thirdNumber));
        }
    }
}
