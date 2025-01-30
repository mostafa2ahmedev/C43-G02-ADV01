using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Range<T>
    {


        public T minValue { get; set; }
        public T maxValue { get; set; }



        public Range(T min, T max)
        {
            this.minValue = min;
            this.maxValue = max;
        }


    }
}
