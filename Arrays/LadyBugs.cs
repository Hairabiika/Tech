namespace Tech
{
    using System;
    using System.Linq;

    public class LadyBugs
    {
        public static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugs = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] array = new int[fieldSize];

            for (int i = 0; i < ladyBugs.Length; i++)
            {
                if (ladyBugs[i] < array.Length && ladyBugs[i] >= 0)
                {
                    array[ladyBugs[i]] = 1;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end") { break; }

                string[] tokens = input.Split(' ');

                int position = int.Parse(tokens[0]);
                string command = tokens[1];
                int added = int.Parse(tokens[2]);

                if (position >= 0 && position < fieldSize && array[position] == 1 && added != 0)
                {
                    if (command == "right")
                    {
                        array[position] = 0;
                        int sum = position + added;

                        while (sum >= 0 && sum < fieldSize && array[sum] == 1)
                        {
                            sum += added;
                        }

                        if (sum >= 0 && sum < fieldSize && array[sum] == 0)
                        {
                            array[sum] = 1;
                        }
                    }

                    else if (command == "left")
                    {
                        array[position] = 0;
                        int sum = position - added;

                        while (sum >= 0 && sum < fieldSize && array[sum] == 1)
                        {
                            sum -= added;
                        }

                        if (sum >= 0 && sum < fieldSize && array[sum] == 0)
                        {
                            array[sum] = 1;
                        }
                    }
                }
            }

            for (int i = 0; i < fieldSize; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}