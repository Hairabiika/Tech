namespace Tech
{
    using System;
    using System.Numerics;
    using System.Text;

    public class TopIntegers
    {
        public static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] tokens = numbers.Split(' ');
            int counter = 0;
            
            for (int i = 0; i < tokens.Length; i++)
            {
                counter = 0;

                for (int j = i + 1; j < tokens.Length; j++)
                {
                    string firstToken = tokens[i];
                    int left = int.Parse(firstToken);

                    string secondToken = tokens[j];
                    int right = int.Parse(secondToken);

                    if (left > right) { counter++; }
                    else { break; }

                    if (counter == tokens.Length - i - 1)
                    {
                        Console.Write(left + " ");
                    }
                }
            }

            Console.WriteLine(tokens[tokens.Length-1]);
        }
    }
}
