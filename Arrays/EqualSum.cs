namespace Tech
{
    using System;
    using System.Numerics;
    using System.Text;

    public class EqualSum
    {
        public static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] tokens = numbers.Split(' ');
            int a = 0;
            int leftSum = 0;
            int rightSum = 0;
            bool yes = false;
            
            for (int i = a; i < tokens.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;

                if (tokens.Length <= 1) { Console.WriteLine("0"); break; }

                for (int j = 0; j < a; j++)
                {
                    string token = tokens[j];
                    leftSum += int.Parse(token);
                }
                
                for (int j = a + 1; j < tokens.Length; j++)
                {
                    string token = tokens[j];
                    rightSum += int.Parse(token);
                }

                if (leftSum == rightSum) {
                    Console.WriteLine(a);
                    yes = true;
                    break;
                }
                
                a++;
            }

            if (!yes && tokens.Length > 1) { Console.WriteLine("no"); }
        }
    }
}
