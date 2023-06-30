int SumOfDigits (int num)
{
    int sum = 0;
    while (num >=10)
    {
        sum = sum + (num % 10);
        num /= 10;
    }
    sum = sum + num;
    return sum;
}
Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = number * (-1);
Console.WriteLine($"Sum of digits in your number is {SumOfDigits(number)}");