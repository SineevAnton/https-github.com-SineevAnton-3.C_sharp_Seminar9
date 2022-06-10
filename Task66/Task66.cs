// Set the values of M and N. Write a program that finds the sum
// of natural elements in the range from M to N. Execute using recursion.

Console.Write("Enter the value of N: ");
int numN = int.Parse(Console.ReadLine());
Console.Write("Enter the value of M: ");
int numM = int.Parse(Console.ReadLine());

int GetSumFromMToN(int m, int n)
{
    if (m > n)
    {
        int temp = m;
        m = n;
        n = temp;
    }
    //int sum = 0;
    if (n == m)
    {
        return n;
    }
    else
    {
        return n + GetSumFromMToN(m, n - 1);
    }
}

Console.WriteLine(GetSumFromMToN(numM, numN));