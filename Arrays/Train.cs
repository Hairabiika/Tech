namespace Tech
{
    using System;
    using System.Numerics;
    using System.Text;

    public class Train
    {
        public static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int sum = 0;

            for (int i = 0; i < wagons; i++)
            {
                int people = int.Parse(Console.ReadLine());
                sb.Append(people + " ");
                sum += people;
            }

            sb.AppendLine();
            sb.Append($"{sum}");
            Console.Write(sb);
        }
    }
}
