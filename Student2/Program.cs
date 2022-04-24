// Задача 34. Одномерный массив, заполненный случайными положительными трехзначными числами
// Программа показывает количестве четных чисел в массиве

int[] mass = new int [5];

int count = 0;

for(int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random ().Next(100,999);

    if(mass[i]%2 == 0)
    {
        count = count + 0;
        count++;
    }
    Console.Write(mass[i] + " ");
}
Console.WriteLine($"Количество всех четных чисел в массиве: {count}");

//Задача 38. Задать массив вещественных чисел
//Найти максимальное значение в массиве
//Найти минимальное значение в массиве
//Найти разницу между максимальным и минимальным значениями

int[] Array = new int [5];

void PrintArray (int[] array)
 
{
    for(int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] +" ");
    }
}

for(int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(1,25);
}

int max = Array[0];
int min = Array[0];
int res = 0;

for(int i = 0; i < Array.Length; i++)
{
    if(Array[i] > max) 
    max = Array[i];

    if(Array[i] < min) 
    min = Array[i];

    res = max - min;
}
Console.WriteLine($"Максимальное значени в массиве: {max}  ");
Console.WriteLine($"Минимальное значени в массиве: {min}  ");
Console.WriteLine($"Разница между максимальным и минимальным значением {res} ");

PrintArray(Array);

// Задача 36. Одномерный массив, заполненный случайными числами
// Показывает сумму всех нечетных числе в массиве

int[] mass = new int [6];

int sum = 0;

for(int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random ().Next(0,8);

    if(mass[i]%2 != 0)
    {
        sum = sum + mass[i];
    }
    Console.Write(mass[i] + " ");
}
Console.WriteLine($"Сумма всех нечетных чисел: {sum}");