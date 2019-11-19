namespace Tech
{
    using System;
    using System.Text;

    public class SpiceMustFlow
    {
        public static void Main(string[] args)
        {
            int spice = int.Parse(Console.ReadLine());
            int days = 0;
            int yield = spice;
            int total = 0;

            if (yield >= 100)
            {
                while (yield >= 100)
                {
                    total += yield - 26;
                    spice -= 26;
                    days++;
                    yield -= 10;
                }

                total -= 26;
                Console.WriteLine(days);
                Console.WriteLine(total);
            }

            else { Console.WriteLine(0); Console.WriteLine(0); }
        }
    }
}
