using System;
using static System.Console;
Clear();
WriteLine("Введите D:");
int d = int.Parse(ReadLine()!);
WriteLine("Введите C:");
int c = int.Parse(ReadLine()!);

WriteLine(PrintNumbers(d, c));
int PrintNumbers(int d, int c)
{
    if (c == d || c == 1)
    {
        return 1;
    }
    int s = PrintNumbers(d, c - 1) + c;
    return s;
}