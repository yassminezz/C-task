using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Range<T> where T:IComparable<T>
    {
        public T Min { get; }
        public T Max { get; }
        public Range(T Min,T Max)
        {
            this.Min=Min;
            this.Max=Max;
            
        }
    
        public bool IsInRange(T val)
        {
             if (val.CompareTo(Min) >=0 && val.CompareTo(Max) <= 0) return true;
             return false;
        }
        public double Length()
        {
            try
            {
                dynamic minVal = Min;
                dynamic maxVal = Max;
                return (double)maxVal - minVal;
            }
            catch
            {
                throw new InvalidOperationException("Length is only supported for numeric types.");
            }
        }

    }
}
