namespace Tech
{
    using System;
    using System.Numerics;
    using System.Text;

    public class MagicSum
    {
        public static void Main(string[] args)
        {
            string array = Console.ReadLine();
            string[] tokens = array.Split(' ');
            int sum = int.Parse(Console.ReadLine());
            string newArray = string.Empty;

            for (int i = 0; i < tokens.Length; i++)
            {
                for (int j = i; j < tokens.Length; j++)
                {
                    if (int.Parse(tokens[i]) + int.Parse(tokens[j]) == sum && i != j)
                    {
                        Console.WriteLine(tokens[i] + " " + tokens[j]);
                        break;
                    }
                }
            }
        }
    }
}
