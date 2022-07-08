using Algorithms_DataStructures;
Console.WriteLine("Hello, to the algorithm and data structure problems");
Console.WriteLine("Enter a sentence");
String s=Console.ReadLine();
String[] array = s.Split(' ');
for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+" ");
}
Console.WriteLine();
string[] newArray=question.MergeSort(array,0,array.Length-1);
Console.WriteLine("New Array -");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(newArray[i] + " ");
}