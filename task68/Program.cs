using System;
using static System.Console;
Clear();
WriteLine("Введите N:");
int n = int.Parse(ReadLine()!);
WriteLine("Введите M:");
int m = int.Parse(ReadLine()!);

WriteLine(ack(n, m));
int ack(int n, int m)
{
    while ( n != 0)
    {
        if (m == 0) m = 1;
        else m = ack(n, m - 1);
        n = n - 1; 
    }
    return m + 1;
}
