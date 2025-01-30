using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class BubbleSort <T> where T : IComparable<T>
    {


        public static void Swap(ref T x ,ref T y) {
           T temp = x;
            x = y;
            y = temp;
        
        }

        public static void BubbleSortMethod(ref T[] arr) {
            bool swapped=false;
            // Making a flag true if after 1 complete iteration no swap happens  this means that the array already sorted so the time complexity would be O(n)
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) == 1) {

                        Swap(ref arr[j], ref arr[j + 1]);
                        swapped = true;
                    }

                }
                if (!swapped)
                    break;
            }
           


        }


    }
}
