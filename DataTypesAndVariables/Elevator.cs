﻿namespace Tech
{
    using System;
    using System.Text;

    public class Elevator
    {
        public static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            if (people % capacity == 0) { Console.WriteLine(people / capacity); }
            else { Console.WriteLine((people / capacity) + 1); }
        }
    }
}
