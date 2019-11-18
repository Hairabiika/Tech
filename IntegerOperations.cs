namespace Tech
{
    using System;
    using System.Text;

    public class IntegerOperations
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int total = ((firstNumber + secondNumber) / thirdNumber) * fourthNumber;
            Console.WriteLine(total);
        }
    }
}
