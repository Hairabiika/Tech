namespace Tech
{
    using System;
    using System.Text;

    public class WaterOverflow
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < lines; i++)
            {
                int water = int.Parse(Console.ReadLine());
                sum += water;
                if (sum > 255) { Console.WriteLine("Insufficient capacity!");  sum -= water; }
            }

            Console.WriteLine(sum);
        }
    }
}
