using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStructures
{
    internal class question
    {
        public static void insertionSort(String SENTENCE)
        {
            String[]sentence=SENTENCE.Split(' ');
            for (int x = 0; x < sentence.Length; x++)               //PRINTING THE PREVIOUS ARRAY OF STRINGS
            {
                Console.Write(sentence[x] + " ");
            }
            for (int x = 1; x < (sentence.Length)-1; x++)
            {
                int i = x;
                String t = sentence[x];
                while (sentence[i - 1].CompareTo(t)>0)
                {
                    sentence[i] = sentence[i - 1];
                    i--;
                    if (i == 0)
                    {
                        break;
                    }
                }
                sentence[i] = t;
            }
            Console.WriteLine();
            for(int x=0; x < sentence.Length; x++)              //PRINTING THE NEW ARRAY OF STRINGS
            {
                Console.Write(sentence[x]+" ");
            }

        }
    }
}
