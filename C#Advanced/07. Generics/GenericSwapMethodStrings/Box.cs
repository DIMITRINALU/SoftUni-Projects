namespace GenericSwapMethodStrings
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box<T>
    {
        public Box()
        {
            this.Values = new List<T>();
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