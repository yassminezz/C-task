using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class FixedSizeList<T>
    {
        private static int allowedSize =0 ;
        List<T> list;
        int size { set; get; }
        public FixedSizeList(int size)
        {
            this.size = size; 
            allowedSize=size;
            list = new List<T>(size);   
        }
        public void add(T item) {
            if (allowedSize < size)
                list.Add(item);
            else
                throw new Exception("sorry you've exceeded the allowed size");

        }
        public T get(int index)
        {
            if (index > allowedSize)
                throw new Exception("sorry you've entered invalid index !");
            return list[index];
        }
    }
}
