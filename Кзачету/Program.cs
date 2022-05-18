//Задание 60. Задайте трехмерный массив из неповторяющихся двухначных чисел
//Написать программу, которая будет построчно выводить массив, добавляя индексы каждого элемента


Console.Clear();
Console.Write("Введите число блоков: ");
int c = int.Parse(Console.ReadLine());
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,,] mass = new int[c, m, n];

void PrintArray (int[,,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
    // Console.WriteLine("Блок №" (i + 1));
       for (int j = 0; j < mass.GetLength(1); j++)
       {
           for (int k = 0; k < mass.GetLength(2); k++)
            {
                 Console.Write($"{mass[i,j,k]} - {i},{j},{k}");
                 Console.WriteLine();
            }
            Console.WriteLine();
        } 
        Console.WriteLine();  
    }
    Console.WriteLine();
}

void FillArray  (int[,,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                mass[i,j,k] = new Random().Next(10,100);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

PrintArray(mass);
FillArray(mass);
Console.WriteLine();
PrintArray(mass);

// Задача54. Задать  двумерный массив
// Программа, которая упорядочит по убыванию элементы каждой строки двумерного массива

Console.Clear();
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 9);
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("сортируем по убыванию элементы");

for (int i = 0; i < mass.GetLength(0); i++)
  {
    int temp = 0;
    for (int j = 0; j < mass.GetLength(1); j++)
    {
       for (int k = 0; k < mass.GetLength(1); k++)
    

      if(mass[i,j] < mass[i,k])
      {
        temp = mass[i,j];
        mass[i,j] = mass[i,k];
        mass[i,k] = temp;
      }
    }
  }
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}

// Задача 56.Задать прямоугольный двумерный массив
// Найти строку с наименьшей суммой элементов

Console.Clear();
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine());

int[,] mass = new int[m, n];


for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 9);
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int sum = mass[0,0];
int iGet = 0;

for (int i = 0; i < mass.GetLength(0); i++)
{
    int result = 0;

    for (int j = 0; j < mass.GetLength(1); j++) 
        {
            result += mass[i, j];
        }
        if(sum < result)
        {
            sum = result;
            iGet = i;
        }  
        Console.Write(result + " ");    
}
Console.Write($"Номер строки с минимальной суммой элементов: {iGet}"); 


 