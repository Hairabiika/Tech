namespace Tech
{
    using System;
    using System.Text;

    public class GamingStore
    {
        public static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double spending = 0;
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Game Time") { break; }

                bool game = false;
                if (input == "OutFall 4")
                {
                    game = true;

                    if (balance - 39.99 >= 0)
                    {
                        sb.AppendLine($"Bought {input}");
                        balance -= 39.99;
                        game = true;
                        spending += 39.99;
                    }

                    else { sb.AppendLine("Too Expensive"); }
                }
                if (input == "CS: OG")
                {
                    game = true;

                    if (balance - 15.99 >= 0)
                    {
                        sb.AppendLine($"Bought {input}");
                        balance -= 15.99;
                        game = true;
                        spending += 15.99;
                    }

                    else { sb.AppendLine("Too Expensive"); }
                }
                if (input == "Zplinter Zell")
                {
                    game = true;

                    if (balance - 19.99 >= 0)
                    {
                        sb.AppendLine($"Bought {input}");
                        balance -= 19.99;
                        game = true;
                        spending += 19.99;
                    }

                    else { sb.AppendLine("Too Expensive"); }
                }
                if (input == "Honored 2")
                {
                    game = true;

                    if (balance - 59.99 >= 0)
                    {
                        sb.AppendLine($"Bought {input}");
                        balance -= 59.99;
                        game = true;
                        spending += 59.99;
                    }

                    else { sb.AppendLine("Too Expensive"); }
                }
                if (input == "RoverWatch")
                {
                    game = true;

                    if (balance - 29.99 >= 0)
                    {
                        sb.AppendLine($"Bought {input}");
                        balance -= 29.99;
                        game = true;
                        spending += 29.99;
                    }

                    else { sb.AppendLine("Too Expensive"); }
                }
                if (input == "RoverWatch Origins Edition")
                {
                    game = true;

                    if (balance - 39.99 >= 0)
                    {
                        sb.AppendLine($"Bought {input}");
                        balance -= 39.99;
                        spending += 39.99;
                    }

                    else { sb.AppendLine("Too Expensive"); }
                }

                if (!game) { sb.AppendLine("Not found"); }
                if (balance == 0) { sb.AppendLine("Out of money!"); break; }
            }

            if (balance != 0) { sb.AppendLine($"Total spent: ${spending:F2}. Remaining: ${balance:F2}"); }
            Console.Write(sb);
        }
    }
}
