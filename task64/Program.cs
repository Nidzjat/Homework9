using System;
using static System.Console;
Clear();
WriteLine("Введите M:");
int m = int.Parse(ReadLine()!);
WriteLine("Введите N:");
int n = int.Parse(ReadLine()!);

WriteLine(PrintNumbers(m, n));
string PrintNumbers(int m, int n)
{
    if (n == m || n == 1)
    {
        return n.ToString();
    }
    string s = PrintNumbers(m, n - 1) + ", " + n.ToString();
    return s;
}

