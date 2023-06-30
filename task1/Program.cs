int Stepen (int numA, int numB)
{
    int result = 1;
    for (int i=0; i<numB; i++)
    {
        result = result * numA;
    }
    return result;
}
Console.Write ("Enter number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Enter number B: ");
int b = Convert.ToInt32(Console.ReadLine());
while (b<0)
{
    Console.Write("Enter number B again: ");
    b = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"A in degree B is {Stepen(a, b)}");