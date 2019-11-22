namespace Tech
{
    using System;
    using System.Numerics;
    using System.Text;

    public class MaxSequence
    {
        public static void Main(string[] args)
        {
            string array = Console.ReadLine();
            string[] tokens = array.Split(' ');
            int number = 0;
            int sum = 0;
            int currentSum = 1;

            for (int i = 0; i < tokens.Length; i++)
            {
                currentSum = 1;
                
                if (i + 1 != tokens.Length && tokens[i] == tokens[i + 1])
                {
                    while (tokens[i] == tokens[i + 1])
                    {
                        currentSum++;
                        i++;
                        if (i + 1 == tokens.Length) { break; }
                    }
                }

                if (currentSum > sum)
                {
                    sum = currentSum;
                    number = int.Parse(tokens[i]);
                }
            }

            for (int i = 0; i < sum; i++)
            {
                Console.Write($"{number}" + " ");
            }
        }
    }
}
