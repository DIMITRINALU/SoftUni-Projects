﻿namespace GenericBoxOfString
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();

                Box<string> box = new Box<string>(value);
                Console.WriteLine(box);
            }            
        }
    }
}