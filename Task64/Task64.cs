// Set the value to N. Write a program that outputs all
// natural numbers in the range from N to 1. Execute using recursion.

Console.Write("Enter the value of N: ");
int num = int.Parse(Console.ReadLine());

void ShowNumbersFromNToOne(int n)
{
    if (n == 1)
    {
        Console.Write($"{n} ");
        return;
    }
    else
    {
        Console.Write($"{n} ");
        ShowNumbersFromNToOne(n - 1);
    }
}

ShowNumbersFromNToOne(num);