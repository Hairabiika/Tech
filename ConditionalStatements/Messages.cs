namespace Tech
{
    using System;
    using System.Text;

    public class Messages
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < number; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers == 2) { sb.Append('a'); }
                if (numbers == 22) { sb.Append('b'); }
                if (numbers == 222) { sb.Append('c'); }
                if (numbers == 3) { sb.Append('d'); }
                if (numbers == 33) { sb.Append('e'); }
                if (numbers == 333) { sb.Append('f'); }
                if (numbers == 4) { sb.Append('g'); }
                if (numbers == 44) { sb.Append('h'); }
                if (numbers == 444) { sb.Append('i'); }
                if (numbers == 5) { sb.Append('j'); }
                if (numbers == 55) { sb.Append('k'); }
                if (numbers == 555) { sb.Append('l'); }
                if (numbers == 6) { sb.Append('m'); }
                if (numbers == 66) { sb.Append('n'); }
                if (numbers == 666) { sb.Append('o'); }
                if (numbers == 7) { sb.Append('p'); }
                if (numbers == 77) { sb.Append('q'); }
                if (numbers == 777) { sb.Append('r'); }
                if (numbers == 7777) { sb.Append('s'); }
                if (numbers == 8) { sb.Append('t'); }
                if (numbers == 88) { sb.Append('u'); }
                if (numbers == 888) { sb.Append('v'); }
                if (numbers == 9) { sb.Append('w'); }
                if (numbers == 99) { sb.Append('x'); }
                if (numbers == 999) { sb.Append('y'); }
                if (numbers == 9999) { sb.Append('z'); }
                if (numbers == 0) { sb.Append(' '); }
            }

            Console.WriteLine(sb);
        }
    }
}
