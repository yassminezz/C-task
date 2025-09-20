using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Program
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public int[] BubbleSort(int[] nums)
        {
       
            for (int i = 0; i < nums.Length-1; i++)
            {
                bool swap = false;
                for (int j = 0; j < nums.Length-1-i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        Swap(ref nums[j], ref nums[j + 1]);
                        swap = true;
                    }
                      

                }
                if (!swap)
                    break;
            }
            return nums;
        }
        public ArrayList reverseList(ArrayList arr)
        {
            int j = arr.Count - 1;
            for (int i = 0;i<(arr.Count/2); i++)
            {
                object temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j--;
            }
            return arr;
        }
        public List<int> evens(List<int> nums)
        {
            List<int> evns = new List<int>();
            foreach(var nmbr in nums)
            {
                if (nmbr % 2 == 0)
                    evns.Add(nmbr);

            }
            return evns;
        }

        public  int unrepeated(string s)
        {
            if (string.IsNullOrEmpty(s))
                return -1;

            Dictionary<char, int> freq = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (freq.ContainsKey(c))
                    freq[c]++;
                else
                    freq[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (freq[s[i]] == 1)
                    return i;
            }

            return -1;
        }
        static void Main(string[] args)
        {
            //5 2 9 8 6 4 7
            //2 5 9 8 6 4 7
            //2  5 9 8 6 4 7
            //


        }
    }
}
