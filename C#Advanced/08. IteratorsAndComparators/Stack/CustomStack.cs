namespace Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomStack<T> : IEnumerable<T>
    {
        private readonly List<T> elements;

        public CustomStack(params T[] elements)
        {
            this.elements = elements.ToList();
        }

        public void Push(params T[] elementsToAdd)         
        {
            this.elements.AddRange(elementsToAdd);
        }

        public T Pop()        
        {
            if (this.elements.Count == 0)
            {
                throw new ArgumentException("No elements");
            }

            T element = this.elements[this.elements.Count - 1];
            this.elements.RemoveAt(this.elements.Count - 1);

            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.elements.Count - 1; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}