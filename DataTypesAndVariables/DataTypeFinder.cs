namespace Tech
{
    using System;
    using System.Numerics;
    using System.Text;

    public class DataTypeFinder
    {
        public static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END") { break; }
                int intInput;
                double doubleInput;
                char charInput;
                bool boolInput;

                if (int.TryParse(input, out intInput)) { sb.AppendLine($"{input} is integer type"); }
                else if (double.TryParse(input, out doubleInput)) { sb.AppendLine($"{input} is floating point type"); }
                else if (char.TryParse(input, out charInput)) { sb.AppendLine($"{input} is character type"); }
                else if (bool.TryParse(input, out boolInput)) { sb.AppendLine($"{input} is boolean type"); }
                else { sb.AppendLine($"{input} is string type"); }
            }
            
            Console.Write(sb);
        }
    }
}
