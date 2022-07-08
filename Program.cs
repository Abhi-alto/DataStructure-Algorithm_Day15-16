using Algorithms_DataStructures;
Console.WriteLine("Hello, to the algorithm and data structure problems");
Console.WriteLine("Enter the array length");
int Length=Convert.ToInt16(Console.ReadLine());
int[] Array = new int[Length];
for(int i = 0; i < Length; i++)
{
    Console.WriteLine("Enter element "+(i+1));
    Array[i]= Convert.ToInt16(Console.ReadLine());
}
Console.WriteLine("Old Array -");
for (int i = 0; i < Array.Length; i++)
{
    Console.Write(Array[i] + " ");
}
Console.WriteLine();
int[] newArray=question.bubbleSort(Array);
Console.WriteLine("New Array -");
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}