namespace Tech
{
    using System;
    using System.Text;

    public class Pokemon
    {
        public static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int counter = 0;
            int newPower = power;
            bool less = false;

            while (newPower >= distance)
            {
                if (power == 2 * newPower && newPower > exhaustion && exhaustion != 0)
                {
                    newPower /= exhaustion;
                    if (newPower < distance) {less = true; break; }
                }

                if (less) { break; }
                newPower -= distance;
                counter++;
            }

            Console.WriteLine(newPower);
            Console.WriteLine(counter);
        }
    }
}
