// Write a program for calculating the Ackerman function using
// recursion. Two non-negative numbers m and n are given.
// Learn more about the Ackerman function: https://progler.ru/blog/funkciya-akkermana

Console.Write("Enter the value of M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Enter the value of N: ");
int numN = int.Parse(Console.ReadLine());

int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return Ackerman(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return Ackerman(m - 1, Ackerman(m, n - 1));
    }
    else
    {
        return n + 1;
    }
}

Console.WriteLine(Ackerman(numM, numN));