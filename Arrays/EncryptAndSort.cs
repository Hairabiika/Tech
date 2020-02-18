namespace Tech
{
    using System;
    using System.Linq;

    public class EncryptAndSort
    {
        public static void Main(string[] args)
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            int[] numbers = new int[numberOfStrings];

            for (int i = 0; i < numberOfStrings; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;

                foreach (var symbol in input)
                {
                    if (symbol == 'a' || symbol == 'e' || symbol == 'o' || symbol == 'i'
                        || symbol == 'u' || symbol == 'A' || symbol == 'E'
                        || symbol == 'O' || symbol == 'I' || symbol == 'U')
                    {
                        sum += (symbol * input.Length);
                    }

                    else
                    {
                        sum += (symbol / input.Length);
                    }
                }

                numbers[i] = sum;
            }

            for (int i = 0; i < numberOfStrings; i++)
            {
                for (int j = 0; j < numberOfStrings; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            for (int i = 0; i < numberOfStrings; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}