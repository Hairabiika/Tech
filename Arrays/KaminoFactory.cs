namespace Tech
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class KaminoFactory
    {
        public static void Main(string[] args)
        {
            int sequences = int.Parse(Console.ReadLine());
            int sum = 0;
            int index = 0;
            int currentSum = 0;
            int currentIndex = 0;
            int subsequences = 0;
            int currentSubsequences = 0;
            int sample = 1;
            int currentSample = 1;
            int[] array = new int[sequences];

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!") { break; }

                currentSum = 0;
                currentIndex = 0;
                currentSubsequences = 0;

                if (input == "Clone them!")
                {
                    break;
                }

                int[] tokens = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int i = sequences - 1; i >= 0; i--)
                {
                    if (tokens[i] == 1)
                    {
                        currentSum++;
                    }

                    if (i - 1 >= 0 && tokens[i] == tokens[i - 1] && tokens[i] == 1)
                    {
                        while (i - 1 >= 0 && tokens[i] == tokens[i - 1])
                        {
                            currentIndex = i - 1;
                            currentSubsequences++;
                            i--;
                            currentSum++;
                        }
                    }
                }


                if (currentSubsequences == subsequences)
                {
                    if ((currentIndex == index && sum < currentSum) || (currentIndex < index))
                    {
                        for (int i = 0; i < sequences; i++)
                        {
                            array[i] = tokens[i];
                        }
                        subsequences = currentSubsequences;
                        sum = currentSum;
                        sample = currentSample;
                        index = currentIndex;
                    }
                }

                if (currentSubsequences > subsequences)
                {
                    for (int i = 0; i < sequences; i++)
                    {
                        array[i] = tokens[i];
                    }

                    subsequences = currentSubsequences;
                    sum = currentSum;
                    sample = currentSample;
                    index = currentIndex;
                }

                currentSample++;
            }

            Console.WriteLine($"Best DNA sample {sample} with sum: {sum}.");

            for (int i = 0; i < sequences; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
