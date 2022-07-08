using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_DataStructures
{
    internal class choice
    {
        public static void CHOICE(int ch)
        {
            if (ch == 1)                    //Binary search
            {
                String s = Console.ReadLine();
                Console.WriteLine("Enter the word you want to search");
                String search = Console.ReadLine();
                String[] words = s.Split(' ');          //storing the string in an array of strings
                binarySearch<string> obj = new binarySearch<string>();
                obj.sortAndCall(words, search);
            }
            else if (ch == 2)                           //Bubble Sort
            {
                Console.WriteLine("Enter the array length");        //Enter the length of the array first
                int Length = Convert.ToInt16(Console.ReadLine());
                int[] Array = new int[Length];
                for (int i = 0; i < Length; i++)
                {
                    Console.WriteLine("Enter integer element " + (i + 1));              //Enter all the elements of the array
                    Array[i] = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine("Old Array -");
                for (int i = 0; i < Array.Length; i++)
                {
                    Console.Write(Array[i] + " ");
                }
                Console.WriteLine();
                int[] newArray = bubbleSort<int>.bubbleSORT(Array);             //BubbleSorting using generics
                Console.WriteLine("New Array -");
                for (int i = 0; i < newArray.Length; i++)
                {
                    Console.Write(newArray[i] + " ");
                }
            }
            else if (ch == 3)                      //Insertion Sort
            {
                Console.WriteLine("Enter a sentence");
                String S = Console.ReadLine();
                String[] sentence = S.Split(' ');
                InsertionSort<string>.insertionSort(sentence);
            }
            else if (ch == 4)                      //Merge Sort
            {
                Console.WriteLine("Enter a sentence");
                String sen = Console.ReadLine();
                String[] array = sen.Split(' ');
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
                string[] SortedArray = MergeSort<string>.mergeSort(array, 0, array.Length - 1);
                Console.WriteLine("New Array -");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(SortedArray[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }
    }
}
