namespace Tech
{
    using System;
    public class Vacation
    {
        public static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string typePeople = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            
            if (typePeople == "Students" && day == "Friday") { price = 8.45 * group; }
            if (typePeople == "Students" && day == "Saturday") { price = 9.8 * group; }
            if (typePeople == "Students" && day == "Sunday") { price = 10.46 * group; }
            if (typePeople == "Business" && day == "Friday") { price = 10.9 * group; }
            if (typePeople == "Business" && day == "Saturday") { price = 15.6 * group; }
            if (typePeople == "Business" && day == "Sunday") { price = 16 * group; }
            if (typePeople == "Regular" && day == "Friday") { price = 15 * group; }
            if (typePeople == "Regular" && day == "Saturday") { price = 20 * group; }
            if (typePeople == "Regular" && day == "Sunday") { price = 22.5 * group; }

            if (typePeople == "Students" && group >= 30) { price *= 0.85; }
            if (typePeople == "Business" && group >= 100 && day == "Friday") { price -= 10 * 10.9; }
            if (typePeople == "Business" && group >= 100 && day == "Saturday") { price -= 10 * 15.6; }
            if (typePeople == "Business" && group >= 100 && day == "Sunday") { price -= 10 * 16; }
            if (typePeople == "Regular" && group >= 10 && group <= 20) { price *= 0.95; }

            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
