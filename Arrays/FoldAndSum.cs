namespace Tech
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int length = numbers.Length;
            int parts = length / 4;
            int[] firstRow = new int[parts];
            int[] secondRow = new int[parts * 2];
            int[] thirdRow = new int[parts];

            int firstRowCounter = 0;
            int secondRowCounter = 0;
            int thirdRowCounter = 0;

            for (int i = 0; i < length; i++)
            {
                if (i < parts)
                {
                    firstRow[firstRowCounter] = numbers[i];
                    firstRowCounter++;
                }

                else if (i >= 3 * parts)
                {
                    thirdRow[thirdRowCounter] = numbers[i];
                    thirdRowCounter++;
                }

                else
                {
                    secondRow[secondRowCounter] = numbers[i];
                    secondRowCounter++;
                }
            }
            
            for (int i = 0; i < parts / 2; i++)
            {
                int temp = firstRow[i];
                firstRow[i] = firstRow[parts - 1 - i];
                firstRow[parts - 1 - i] = temp;

                int temp2 = thirdRow[i];
                thirdRow[i] = thirdRow[parts - 1 - i];
                thirdRow[parts - 1 - i] = temp2;

            }

            for (int i = 0; i < parts; i++)
            {
                Console.Write((firstRow[i] + secondRow[i]) + " ");
            }

            for (int i = 0; i < parts; i++)
            {
                Console.Write((thirdRow[i] + secondRow[i + parts]) + " ");
            }
        }
    }
}