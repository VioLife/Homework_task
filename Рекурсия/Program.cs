//Задача 64. Задать значения M и N. Написать программу, которая выведет нат значения в промежутке от M до N (M=1,N=5 -> 5,4,3,2,1)

void Func(int m, int n)
{
    if(m == n)
    {
        Console.Write(n);
        return;
    }
    
    else if (m < n)
    {
        Console.Write(m + " ");
        Func(m + 1, n);
    }
    else
    {
        Console.Write(m + " ");
        Func(m - 1, n);
    }
    Console.WriteLine();
}
// Console.WriteLine("Введите число а: ");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите число b: ");
// int b = int.Parse(Console.ReadLine());
Func(4, 8);
Console.WriteLine();
Func(8,4);

// Задача 68. Даны два неотрицательных числа M и N. Написать программу вычисления аккермана с помощью рекурсии.

int A (int m, int n)

{
    if(n < 0 || m < 0) 
    {
        Console.Write("выходит за рамки значения");
    }
    
    if(m == 0)
    {
        return n +1;
    }
    else if (n == 0 & m > 0)
    {
        return A(m -1,1);
    }
    else
    {
        return A(m-1, A(m,n-1)); 
    }
}
Console.WriteLine(A(3,2));

// Задача 66. Задайте значения M и N. Найдите сумму натуральных элементов в промежутке от M до N.

int Sum(int min, int max)
{
    Console.Write("min = ");
    min = int.Parse(Console.ReadLine());
    Console.Write("max = ");
    max = int.Parse(Console.ReadLine());
    int sum = 0;
    for(int i = min; i <= max;i++)
    {
        sum += i;
        Console.Write(sum + " ");
    }
    return 0;
}
Sum(2,15);