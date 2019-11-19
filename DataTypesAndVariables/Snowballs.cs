namespace Tech
{
    using System;
    using System.Numerics;
    using System.Text;

    public class Snowballs
    {
        public static void Main(string[] args)
        {
            ulong snowballs = ulong.Parse(Console.ReadLine());
            ulong bestSnow = 0;
            ulong bestTime = 1;
            ulong bestQuality = 0;
            BigInteger bestValue = 0;

            if (snowballs != 0)
            {
                ulong snowballSnow = ulong.Parse(Console.ReadLine());
                ulong snowballTime = ulong.Parse(Console.ReadLine());
                ulong snowballQuality = ulong.Parse(Console.ReadLine());
                
                if (snowballTime != 0)
                {
                    BigInteger snowballValue = snowballSnow / snowballTime;

                    bestSnow = snowballSnow;
                    bestTime = snowballTime;
                    bestQuality = snowballQuality;

                    for (ulong i = 1; i < snowballQuality; i++)
                    {
                        snowballValue *= (snowballSnow / snowballTime);
                    }

                    if (snowballQuality == 0) { snowballValue = 1; }

                    bestValue = snowballValue;
                }

                for (ulong i = 1; i < snowballs; i++)
                {
                    snowballSnow = ulong.Parse(Console.ReadLine());
                    snowballTime = ulong.Parse(Console.ReadLine());
                    snowballQuality = ulong.Parse(Console.ReadLine());

                    if (snowballTime != 0)
                    {
                        BigInteger snowballValue = snowballSnow / snowballTime;

                        for (ulong j = 1; j < snowballQuality; j++)
                        {
                            snowballValue *= (snowballSnow / snowballTime);
                        }

                        if (snowballQuality == 0) { snowballValue = 1; }

                        if (bestValue <= snowballValue)
                        {
                            bestSnow = snowballSnow;
                            bestTime = snowballTime;
                            bestQuality = snowballQuality;
                            bestValue = snowballValue;
                        }
                    }
                }
            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}
