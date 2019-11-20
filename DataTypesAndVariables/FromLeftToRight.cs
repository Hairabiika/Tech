namespace Tech
{
    using System;
    using System.Numerics;
    using System.Text;

    public class FromLeftToRight
    {
        public static void Main(string[] args)
        {
            long lines = long.Parse(Console.ReadLine());
            long sum = 0;
            bool bigger = false;
            long counter = 0;

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split(' ');
                string leftNumber = tokens[0];
                string rightNumber = tokens[1];
                sum = 0;
                bigger = false;
                counter = 0;

                if (leftNumber.Length > rightNumber.Length)
                {
                    if (leftNumber[0] == '-')
                    {
                        if (rightNumber[0] == '-')
                        {
                            //sum -= (int)(rightNumber[1] - '0');
                            for (int j = 1; j < rightNumber.Length; j++)
                            {
                                sum += (int)(rightNumber[j] - '0');
                            }
                        }

                        else
                        {
                            for (int j = 0; j < rightNumber.Length; j++)
                            {
                                sum += (int)(rightNumber[j] - '0');
                            }
                        }
                    }

                    else
                    {
                        for (int j = 0; j < leftNumber.Length; j++)
                        {
                            sum += (int)(leftNumber[j] - '0');
                        }
                    }

                    Console.WriteLine(sum);
                }

                else if (leftNumber.Length < rightNumber.Length)
                {
                    if (rightNumber[0] == '-')
                    {
                        if (leftNumber[0] == '-')
                        {
                            //sum -= (int)(leftNumber[1] - '0');
                            for (int j = 1; j < leftNumber.Length; j++)
                            {
                                sum += (int)(leftNumber[j] - '0');
                            }
                        }

                        else
                        {
                            for (int j = 0; j < leftNumber.Length; j++)
                            {
                                sum += (int)(leftNumber[j] - '0');
                            }
                        }
                    }

                    else
                    {
                        for (int j = 0; j < rightNumber.Length; j++)
                        {
                            sum += (int)(rightNumber[j] - '0');
                        }
                    }

                    Console.WriteLine(sum);
                }

                else // raven length
                {
                    if (leftNumber[0] == '-' && rightNumber[0] != '-')
                    {
                        for (int j = 0; j < rightNumber.Length; j++)
                        {
                            sum += (int)(rightNumber[j] - '0');
                        }

                        Console.WriteLine(sum);
                    }

                    else if (leftNumber[0] != '-' && rightNumber[0] == '-')
                    {
                        for (int j = 0; j < leftNumber.Length; j++)
                        {
                            sum += (int)(leftNumber[j] - '0');
                        }

                        Console.WriteLine(sum);
                    }

                    else if (leftNumber[0] != '-' && rightNumber[0] != '-')
                    {
                        for (int j = 0; j < leftNumber.Length; j++)
                        {
                            counter++;

                            if (leftNumber[j] > rightNumber[j])
                            {
                                for (int k = 0; k < leftNumber.Length; k++)
                                {
                                    sum += (int)(leftNumber[k] - '0');
                                    bigger = true;
                                }
                            }

                            if (leftNumber[j] < rightNumber[j])
                            {
                                for (int k = 0; k < rightNumber.Length; k++)
                                {
                                    sum += (int)(rightNumber[k] - '0');
                                    bigger = true;
                                }
                            }

                            if (counter == leftNumber.Length && sum == 0)
                            {
                                for (int k = 0; k < leftNumber.Length; k++)
                                {
                                    sum += (int)(leftNumber[k] - '0');
                                    bigger = true;
                                }
                            }

                            if (bigger)
                            {
                                Console.WriteLine(sum);
                                break;
                            }
                        }
                    }

                    else if (leftNumber[0] == '-' && rightNumber[0] == '-')
                    {
                        counter++;

                        if (leftNumber[1] > rightNumber[1])
                        {
                            //sum -= (int)(rightNumber[1] - '0');
                            for (int k = 1; k < rightNumber.Length; k++)
                            {
                                sum += (int)(rightNumber[k] - '0');
                            }

                            Console.WriteLine(sum);
                        }

                        else if (leftNumber[1] < rightNumber[1])
                        {
                            //sum -= (int)(leftNumber[1] - '0');
                            for (int k = 1; k < leftNumber.Length; k++)
                            {
                                sum += (int)(leftNumber[k] - '0');
                            }

                            Console.WriteLine(sum);
                        }

                        if (counter == leftNumber.Length)
                        {
                            for (int k = 1; k < leftNumber.Length; k++)
                            {
                                sum += (int)(leftNumber[k] - '0');
                            }

                            Console.WriteLine(sum);
                        }

                        else
                        {
                            //sum -= (int)(leftNumber[1] - '0');

                            for (int j = 1; j < leftNumber.Length; j++)
                            {
                                counter++;

                                if (leftNumber[j] > rightNumber[j])
                                {
                                    for (int k = 1; k < leftNumber.Length; k++)
                                    {
                                        sum += (int)(leftNumber[k] - '0');
                                        bigger = true;
                                    }
                                }

                                if (leftNumber[j] < rightNumber[j])
                                {
                                    for (int k = 1; k < leftNumber.Length; k++)
                                    {
                                        sum += (int)(leftNumber[k] - '0');
                                        bigger = true;
                                    }
                                }

                                if (counter == leftNumber.Length)
                                {
                                    for (int k = 1; k < leftNumber.Length; k++)
                                    {
                                        sum += (int)(leftNumber[k] - '0');
                                        bigger = true;
                                    }
                                }

                                if (bigger)
                                {
                                    Console.WriteLine(sum);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
