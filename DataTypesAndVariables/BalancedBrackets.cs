namespace Tech
{
    using System;
    using System.Numerics;
    using System.Text;

    public class BalancedBrackets
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                if (input == "(") { sum++; }
                if (input == ")") 
                {
                    sum--;
                    if (sum > 0 || sum < 0) { break; }
                }
            }

            if (sum == 0) { Console.WriteLine("BALANCED"); }
            else { Console.WriteLine("UNBALANCED"); }
        }
    }
}
