using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Domino
{
    public class Domino : IComparable<Domino>
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }

        public int[] GetValues()
        {
            return Values;
        }
        public int CompareTo([AllowNull] Domino other)
        {
            return this.Values[0] == other.Values[0] ?
                this.Values[1].CompareTo(other.Values[1]):
                this.Values[0].CompareTo(other.Values[0]);
        }
    }
}
