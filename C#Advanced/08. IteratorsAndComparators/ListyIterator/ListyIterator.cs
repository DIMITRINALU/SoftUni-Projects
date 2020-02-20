namespace ListyIterator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListyIterator<T>
    {
        private readonly List<T> elements;
        private int index;

        public ListyIterator(List<T> elements)
        {
            this.elements = elements;
            this.index = 0;
        }

        public bool Move() 
        {
            bool hasNext = this.HasNext();

            if (hasNext)
            {
                this.index++;               
            }

            return hasNext;
        }

        public void Print() 
        {
            if (!this.elements.Any())
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(this.elements[this.index]);
        }

        public bool HasNext()        
        {
            if (this.index < this.elements.Count - 1)
            {                
                return true;
            }

            return false;
        }
    }
}