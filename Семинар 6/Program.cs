// Пользователь вводит с клавиатуры М чисел
//Посчитать, сколько чисел будет больше 0 в заданной, введенной числовой строке
Console.Clear();
Console.WriteLine("Введите числа через запятую: ");
string M = Console.ReadLine();
string[] arr = M.Split(",");
for(int i = 0; i < arr.Length; i++)
{
    int some = int.Parse(arr[i]);
    Console.Write(arr[i]+ " "); 
    int count = arr.Length;
    Console.Write(count);
}
Console.WriteLine();


// Написать программу, которая найдет точку пересечения двух прямых, заданных уравнениями у1 = k1*x1+b1; y2 = k2*x2+b2.
//Пользователь вводит значения
int b1 = 2;
int k1 = 5;
int b2 = 4;
int k2 = 9;
int A = (b2 - b1)/(k1-k2);
int B = (k2 * A + b2);

bool e = false;
if(k1 != k2) e = true;
if(e == true)
Console.WriteLine($"Точки пересечения {A} и {B}");
else 
{
    Console.WriteLine("Прямые не пересекаются");
}


    