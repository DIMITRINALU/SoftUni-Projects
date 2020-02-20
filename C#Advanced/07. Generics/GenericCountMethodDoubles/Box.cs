using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDoubles
{
    public class Box<T> where T: IComparable
    {
        public Box(List<T> value)
        {
            this.Values = value;
        }

        public List<T> Values { get; set; }

        public void Swap(int firstIndex, int secondIndex)
        {
            bool isInRange = firstIndex >= 0 && firstIndex < this.Values.Count &&
                secondIndex >= 0 && secondIndex < this.Values.Count;

            if (!isInRange)
            {
                throw new InvalidOperationException("Values are not in range!");
            }

            T tempValue = this.Values[firstIndex];
            this.Values[firstIndex] = this.Values[secondIndex];
            this.Values[secondIndex] = tempValue;
        }

        public int CountGreaterElements(List<T> elements, T elementToCompare) 
        {
            int counter = 0;

            foreach (var element in elements)
            {
                if (elementToCompare.CompareTo(element) < 0)
                {
                    counter++;
                }                
            }

            return counter;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (var item in this.Values)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            string result = sb.ToString().TrimEnd();

            return result;
        }
    }
}