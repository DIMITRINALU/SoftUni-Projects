namespace P01.Socks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] leftSocksInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] rightSocksInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var leftSocks = new Stack<int>(leftSocksInput);
            var rightSocks = new Queue<int>(rightSocksInput);

            var sets = new List<int>();

            while (leftSocks.Any() && rightSocks.Any())
            {
                int leftSock = leftSocks.Peek();
                int rightSock = rightSocks.Peek();

                if (leftSock > rightSock)
                {
                    int setValue = leftSock + rightSock;
                    sets.Add(setValue);
                    leftSocks.Pop();
                    rightSocks.Dequeue();
                }
                else if (rightSock > leftSock)
                {
                    leftSocks.Pop();
                }
                else
                {
                    rightSocks.Dequeue();
                    int leftSockIncrement = leftSocks.Pop() + 1;
                    leftSocks.Push(leftSockIncrement);
                }
            }

            Console.WriteLine(sets.Max());
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}