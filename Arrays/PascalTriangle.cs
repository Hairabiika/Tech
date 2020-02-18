namespace Tech
{
    using System;
    using System.Linq;

    public class EncryptAndSort
    {
        public static void Main(string[] args)
        {
            int[] secondRow = { 1, 1 };
            int[] thirdRow = { 1, 2, 1 };

            int n = int.Parse(Console.ReadLine());
            int[] nRow = new int[n];

            if (n == 1) { Console.WriteLine(1); }
            if (n == 2) 
            { 
                Console.WriteLine(1);
                Console.WriteLine(1 + " " + 1);
            }

            if (n == 3)
            {
                Console.WriteLine(1);
                Console.WriteLine(1 + " " + 1);
                Console.WriteLine(1 + " " + 2 + " " + 1);
            }

            if (n > 3) 
            {
                Console.WriteLine(1);
                Console.WriteLine(1 + " " + 1);
                Console.WriteLine(1 + " " + 2 + " " + 1);

                nRow[0] = 1;
                nRow[1] = 2;
                nRow[2] = 1;

                int[] sameRow = new int[n];

                sameRow[0] = 1;
                sameRow[1] = 2;
                sameRow[2] = 1;

                for (int i = 3; i < n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        nRow[j] = sameRow[j - 1] + sameRow[j];
                    }

                    for (int j = 0; j <= i; j++)
                    {
                        sameRow[j] = nRow[j];
                        Console.Write(nRow[j] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}