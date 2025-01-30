using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Range<T> where T : IComparable<T>, ISubtractionOperators<T, T, T>
    {


        public T minValue { get; set; }
        public T maxValue { get; set; }



        public Range(T min, T max)
        {
            this.minValue = min;
            this.maxValue = max;
        }
        public bool IsInRange(T value)
        {

            if (value.CompareTo(minValue) == 1 && value.CompareTo(maxValue) == -1)
            {
                return true;

            }
            return false;

        }
        public T Length()
        {

            return this.maxValue - this.minValue;
        }
    }

}
}
