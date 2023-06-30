int [] NewArray (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
        array [i] = new Random().Next(0, 1000);
    return array;
}
void PrintArray (int [] arrayToPrint)
{
    Console.WriteLine ("Your array: ");
    for (int i = 0; i < arrayToPrint.Length; i++)
        Console.Write (arrayToPrint [i] +", ");
    Console.WriteLine("\b\b.");
}
Console.Write("Enter the size of array: ");
int sizeArray = Convert.ToInt32 (Console.ReadLine());
int [] firstArray = NewArray(sizeArray);
PrintArray (firstArray);