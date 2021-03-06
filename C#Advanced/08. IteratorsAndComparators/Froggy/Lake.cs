﻿namespace Froggy
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Lake : IEnumerable<int>
    {
        private readonly List<int> stones;

        public Lake(params int[] stoneValues)
        {
            this.stones = stoneValues.ToList();            
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i += 2)
            {
                yield return this.stones[i];
            }

            int startIndex = this.stones.Count % 2 == 0
                ? this.stones.Count - 1
                : this.stones.Count - 2;

            for (int i = startIndex; i >= 0; i -= 2)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => this.GetEnumerator();
    }
}