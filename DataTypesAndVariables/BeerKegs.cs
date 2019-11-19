namespace Tech
{
    using System;
    using System.Text;

    public class BeerKegs
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string model = Console.ReadLine(); ;
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volume = radius * radius * height;
            string keg = model;

            for (int i = 1; i < lines; i++)
            {
                model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());

                if (radius * radius * height > volume) { keg = model; volume = radius * radius * height; }
            }

            Console.WriteLine(keg);
        }
    }
}
