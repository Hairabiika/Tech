namespace Tech
{
    using System;
    using System.Numerics;
    using System.Text;

    public class ArrayRotation
    {
        public static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] tokens = numbers.Split(' ');
            int rotations = int.Parse(Console.ReadLine());
            string[] sameTokens = new string[1000];

            for (int i = 0; i < tokens.Length; i++)
            {
                sameTokens[i] = tokens[i];
            }

            for (int i = 0; i < tokens.Length; i++)
            {
                if (rotations >= tokens.Length) { rotations -= tokens.Length; }

                int j = i + rotations;

                if (j >= tokens.Length)
                {
                    j -= tokens.Length;
                }

                sameTokens[i] = tokens[j];
            }

            for (int i = 0; i < tokens.Length; i++)
            {
                Console.Write(sameTokens[i] + " ");
            }
        }
    }
}
