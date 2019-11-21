namespace Tech
{
    using System;
    using System.Numerics;
    using System.Text;

    public class ZigZag
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string first = string.Empty;
            string second = string.Empty;

            for (int i = 0; i < lines; i++)
            {
                string number = Console.ReadLine();
                string[] tokens = number.Split(' ');

                if (i % 2 == 0) { first += tokens[0] + " "; second += tokens[1] + " "; }
                else { first += tokens[1] + " "; second += tokens[0] + " "; }
            }

            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
