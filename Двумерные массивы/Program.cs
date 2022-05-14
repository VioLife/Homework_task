// Задача 47.Задать двумерный массив размером m x n, заполненный вещественными числами
int m = 3, n = 4;

double max = 10;
double min = -10;
double [,] mass  = new double [m,n];

Random random = new Random();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for(int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = (max+1 - min) * random.NextDouble() + min;
        Console.Write(mass[i,j] + " ");
    } 
Console.WriteLine();
}

//Задача 50. Написать программу, которая на вход принимает позиции элемента в дувумерном массиве
//И возвращает значение этого элемента или указание, что такого элемента нет

int m = 5;
int n = 3;
int find = 17;
int position = 0;
int[,] mass = new int[m,n];
for(int i = 0; i < mass.GetLength(0); i++)
{
    for(int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(-10, 50);
        Console.Write(mass[i,j] + " ");
    }
    Console.WriteLine();
}

for(int i = 0; i < mass.GetLength(0); i++)
{
    for(int j = 0; j < mass.GetLength(1); j++)
    {
        if(mass[i,j] == find)
        {
            position = mass[i,j];
            Console.Write($"Искомое значение {position} найдено");
        }
        else
        Console.Write($"{position} значения не найдено");  
    }
    Console.WriteLine();
}

// Задача 52. Задайте двумерный массив целых чисел
//Найдите среднее арифметическое в каждом столбце

Console.Clear();
int m = 3, n = 3;
int[,] col = new int[m,n];
double []sum = new double [n];
for (int i = 0; i < col.GetLength(0); i++)
{
    for (int j = 0; j < col.GetLength(1); j++)
    {
        col[i,j] = new Random().Next(0,10);
        Console.Write(col[i,j] + " ");
    }
    Console.WriteLine();
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        sum[j] += col[i,j];
    }
    Console.WriteLine();
}

for (int j = 0; j < m; j++)
{
    Console.Write(sum[j]/m + " ");
}



