namespace Tech
{
    using System;
    using System.Text;

    public class TriplesOfLetters
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    for (int k = 0; k < number; k++)
                    {
                        Console.Write((char)(i + 'a'));
                        Console.Write((char)(j + 'a'));
                        Console.Write((char)(k + 'a'));
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
