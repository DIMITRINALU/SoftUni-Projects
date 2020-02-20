using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        public static void Main()
        {
            var list = new DoublyLinkedList<int>();            

            for (int i = 0; i < 5; i++)
            {
                list.AddFirst(i);                
            }
            //Add 5
            list.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();

            list.AddFirst(3);
            list.AddFirst(4);
            //Add 2
            list.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();

            Console.WriteLine("Count = {0}", list.Count);

            for (int i = 0; i < 3; i++)
            {
                list.AddLast(i);                
            }
            //Add 3
            list.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();

            list.AddLast(5);
            list.AddLast(10);
            //Add 2
            list.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();

            Console.WriteLine("Count = {0}", list.Count);
            Console.WriteLine(list[0]);
            
            list.RemoveFirst();
            list.RemoveLast();
            //Remove 2
            Console.WriteLine("Count = {0}", list.Count);

            list.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();

            for (int i = 1; i < 5; i++)
            {
                list.RemoveFirst();                
            }
            //Remove 4
            list.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();

            Console.WriteLine("Count = {0}", list.Count);                       

            for (int i = 1; i < 4; i++)
            {
                list.RemoveLast();                
            }
            //Remove 3
            list.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();

            Console.WriteLine("Count = {0}", list.Count);         
            
            int[] array = list.ToArray();

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Count = {0}", list.Count);

            
            Console.WriteLine(list[-1]);                  
        }
    }
}