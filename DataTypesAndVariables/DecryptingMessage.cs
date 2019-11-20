namespace Tech
{
    using System;
    using System.Numerics;
    using System.Text;

    public class DecryptingMessage
    {
        public static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < lines; i++)
            {

                char digit = char.Parse(Console.ReadLine());
                sb.Append((char)(digit + key));
            }

            Console.WriteLine(sb);
        }
    }
}
