using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStructures
{
    internal class question
    {
        public static bool prime(int num)
        {
            int Count = 0;                              //counter for number of factors
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    Count++;
                    break;
                }
            }
            if (Count == 0)
            {
                return true; //Console.WriteLine(num + " ");
            }
            return false;
        }
        public static bool palindrome(int num)
        {
            int temp = num;
            int reverse = 0;
            while(temp !=0)
            {
                reverse = reverse*10 + temp % 10; ;
                temp /= 10;
            }
            if(reverse == num)
            {
                return true;
            }
            return false;
        }
        public static void anagram(String fix, String s)
        {
            int l = s.Length;
            if (l == 1)
            {
                Console.WriteLine(fix + s);
            }
            else
            {
                for (int i = 0; i < l; i++)
                {
                    char[] mychar = s.ToCharArray();
                    char c = mychar[i];
                    String st = s.Substring(0, i) + s.Substring(i + 1);
                    anagram(fix + c, st);
                }
            }
        }
    }
}
