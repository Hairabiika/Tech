namespace Tech
{
    using System;
    using System.Text;

    public class VendingMachine
    {
        public static void Main(string[] args)
        {
            double sum = 0;
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Start") { break; }

                double coins = double.Parse(input);

                if (coins != 0.1 && coins != 0.2 && coins != 0.5 && coins != 1 && coins != 2) { sb.AppendLine($"Cannot accept {coins}"); }
                else { sum += coins; }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") { break; }

                if (input == "Nuts")
                {
                    if (sum >= 2) { sum -= 2; sb.AppendLine("Purchased nuts"); }
                    else { sb.AppendLine("Sorry, not enough money"); }
                }

                else if (input == "Water")
                {
                    if (sum >= 0.7) { sum -= 0.7; sb.AppendLine("Purchased water"); }
                    else { sb.AppendLine("Sorry, not enough money"); }
                }

                else if (input == "Crisps")
                {
                    if (sum >= 1.5) { sum -= 1.5; sb.AppendLine("Purchased crisps"); }
                    else { sb.AppendLine("Sorry, not enough money"); }
                }

                else if (input == "Soda")
                {
                    if (sum >= 0.8) { sum -= 0.8; sb.AppendLine("Purchased soda"); }
                    else { sb.AppendLine("Sorry, not enough money"); }
                }

                else if (input == "Coke")
                {
                    if (sum >= 1) { sum -= 1; sb.AppendLine("Purchased coke"); }
                    else { sb.AppendLine("Sorry, not enough money"); }
                }

                else
                {
                    sb.AppendLine("Invalid product");
                }
            }

            sb.AppendLine($"Change: {sum:F2}");
            Console.Write(sb);
        }
    }
}
