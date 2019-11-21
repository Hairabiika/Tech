namespace Tech
{
    using System;
    using System.Numerics;
    using System.Text;

    public class Train
    {
        public static void Main(string[] args)
        {
            string firstArray = Console.ReadLine();
            string secondArray = Console.ReadLine();
            string newArray = string.Empty;

            string[] firstTokens = firstArray.Split(' ');
            string[] secondTokens = secondArray.Split(' ');

            for (int i = 0; i < secondTokens.Length; i++)
            {
                for (int j = 0; j < firstTokens.Length; j++)
                {
                    if (firstTokens[j] == secondTokens[i])
                    {
                        newArray += firstTokens[j] + " ";
                    }
                }
            }

            Console.WriteLine(newArray);
        }
    }
}
