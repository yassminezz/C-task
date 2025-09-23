using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day7
{
    public static class Operations
    {
        public static int count(this string s)
        {
            int count = 0;
            bool inWord = false;

            foreach (var c in s)
            {
                if (char.IsWhiteSpace(c))
                {
                    if (inWord)
                    {
                        count++;
                        inWord = false;
                    }
                }
                else
                {
                    inWord = true;
                }
            }

            if (inWord) count++; 

            return count;
        }
        public static bool evenOdd(this int num)
        {
            if((num % 2) == 0)
                return true;
            return false;
        }
        public static int DetAge(this DateTime dt)
        {
            var today = DateTime.Today;
            int age = today.Year - dt.Year;

            if (today.Month < dt.Month || (today.Month == dt.Month && today.Day < dt.Day))
            {
                age--;
            }

            return age;
        }

        public static string reverse(this string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var c in s)
            {
                stack.Push(c);
            }

            string reversed = "";
            while (stack.Count != 0)
            {
                reversed += stack.Pop();
            }

            return reversed;
        }
    }

}

