namespace Tech
{
    using System;
    using System.Text;

    public class RageExpenses
    {
        public static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int brokenHeadsets = gamesLost / 2;
            int brokenMouses = gamesLost / 3;
            int brokenKeyboards = gamesLost / 6;
            int brokenDisplays = brokenKeyboards / 2;

            double expenses = brokenHeadsets * headsetPrice + brokenMouses * mousePrice + brokenKeyboards * keyboardPrice + brokenDisplays * displayPrice;
            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
