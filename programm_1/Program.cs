// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"


void  PrintNumbers(int m , int n)
{
    
    if (m < n)
    {
    Console.WriteLine(m);
    PrintNumbers(m + 1, n);
    }
    else Console.WriteLine(m);

}
PrintNumbers(1,5);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int  SumNumbers(int m , int n)
{
    
    if (m < n)
    {
     return SumNumbers(m, n-1) + n;
         
    }
    else
    return(n);
    ;
}
Console.WriteLine(SumNumbers(1,5));


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int Ackermann(int m, int n)
{
    while (m != 0)
    {
        if (n == 0)
        {
            n = 1;
        }
        else
        {
            n = Ackermann(m, n - 1);
        }
        m -= 1;
    }
    return n + 1;
}

Console.WriteLine(Ackermann(2, 3));