namespace Tech
{
    using System;
    using System.Text;

    public class SortNumbers
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            if (firstNumber == secondNumber && secondNumber == thirdNumber) { Console.WriteLine(firstNumber); Console.WriteLine(secondNumber); Console.WriteLine(thirdNumber); }
            else if (firstNumber >= secondNumber && secondNumber >= thirdNumber) { Console.WriteLine(firstNumber); Console.WriteLine(secondNumber); Console.WriteLine(thirdNumber); }
            else if (firstNumber >= thirdNumber && thirdNumber >= secondNumber) { Console.WriteLine(firstNumber); Console.WriteLine(thirdNumber); Console.WriteLine(secondNumber); }
            else if (secondNumber >= firstNumber && firstNumber >= thirdNumber) { Console.WriteLine(secondNumber); Console.WriteLine(firstNumber); Console.WriteLine(thirdNumber); }
            else if (secondNumber >= thirdNumber && thirdNumber >= firstNumber) { Console.WriteLine(secondNumber); Console.WriteLine(thirdNumber); Console.WriteLine(firstNumber); }
            else if (thirdNumber >= firstNumber && firstNumber >= secondNumber) { Console.WriteLine(thirdNumber); Console.WriteLine(firstNumber); Console.WriteLine(secondNumber); }
            else if (thirdNumber >= secondNumber && secondNumber >= firstNumber) { Console.WriteLine(thirdNumber); Console.WriteLine(secondNumber); Console.WriteLine(firstNumber); }
        }
    }
}
