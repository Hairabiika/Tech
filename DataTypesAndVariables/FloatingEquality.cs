namespace Tech
{
    using System;
    using System.Numerics;
    using System.Text;

    public class FloatingEquality
    {
        public static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            double sum = 0;
            int first;
            int second;

            string[] firstTokens = firstNumber.Split('.');
            string[] secondTokens = secondNumber.Split('.');
            string firstFirst = firstTokens[0];
            string firstSecond = firstTokens[1];
            string secondFirst = secondTokens[0];
            string secondSecond = secondTokens[1];
            bool tryIt = false;

            if (firstTokens[0] != secondTokens[0] && firstFirst[0] != '-' && secondFirst[0] != '-')
            {
                Console.WriteLine("False");
                return;
            }

            else if (firstTokens[0] != secondTokens[0] && firstFirst[0] == '-' && secondFirst[0] == '-')
            {
                Console.WriteLine("False");
                return;
            }

            else if (firstTokens[0] != secondTokens[0] && firstFirst[0] == '-' && secondFirst[0] != '-')
            {
                if ((firstFirst[1] - '0') == 0 && (secondFirst[0] - '0') == 0) { tryIt = true; }

                else
                {
                    Console.WriteLine("False");
                    return;
                }
            }

            else if (firstTokens[0] != secondTokens[0] && firstFirst[0] != '-' && secondFirst[0] == '-')
            {
                if (firstFirst[0] - '0' == 0 && secondFirst[1] - '0' == 0) { tryIt = true; }
                else
                {
                    Console.WriteLine("False");
                    return;
                }
            }

            if (firstTokens[0] == secondTokens[0] || tryIt)
            {
                if (firstSecond.Length < 7 && secondSecond.Length < 7)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        first = firstSecond[i] - '0';
                        second = secondSecond[i] - '0';

                        sum += (first - second) * Math.Pow(10, -i);
                    }
                }

                else if (firstSecond.Length == secondSecond.Length && firstSecond.Length > 7 && secondSecond.Length > 7)
                {
                    for (int i = 0; i < firstSecond.Length; i++)
                    {
                        first = firstSecond[i] - '0';
                        second = secondSecond[i] - '0';

                        sum += (first - second) * Math.Pow(10, -i);
                    }
                }

                else if (firstSecond.Length > secondSecond.Length && firstSecond.Length > 7 && secondSecond.Length > 7)
                {
                    for (int i = 0; i < secondSecond.Length; i++)
                    {
                        first = firstSecond[i] - '0';
                        second = secondSecond[i] - '0';

                        sum += (first - second) * Math.Pow(10, -i);
                    }

                    for (int i = secondSecond.Length; i < firstSecond.Length; i++)
                    {
                        first = firstSecond[i] - '0';
                        second = 0;

                        sum += (first - second) * Math.Pow(10, -i);
                    }
                }

                else if (firstSecond.Length < secondSecond.Length && firstSecond.Length > 7 && secondSecond.Length > 7)
                {
                    for (int i = 0; i < firstSecond.Length; i++)
                    {
                        first = firstSecond[i] - '0';
                        second = secondSecond[i] - '0';

                        sum += (first - second) * Math.Pow(10, -i);
                        Console.WriteLine(first - second);
                    }

                    for (int i = firstSecond.Length; i < secondSecond.Length; i++)
                    {
                        first = 0;
                        second = secondSecond[i] - '0';
                        sum += (first - second) * Math.Pow(10, -i);
                    }
                }
            }

            if (sum >= 0.000001) { Console.WriteLine("False"); }
            else { Console.WriteLine("True"); }
        }
    }
}
