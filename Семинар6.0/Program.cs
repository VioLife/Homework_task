//Задача 43. Написать программу, которая найдет точку пересечения двух прямых, заданных уравнениями у = k1*x+b1; y = k2*x+b2.
//Пользователь вводит значения
double b1 = 2;
double k1 = 5;
double b2 = 4;
double k2 = 9;
double A = (b2-b1)/(k1-k2);
double B = (A-b1)/k1;

bool e = false;
if(k1 != k2) e = true;
if(e == true)
Console.WriteLine($"Точки пересечения {A} и {B}");
else 
{
    Console.WriteLine("Прямые не пересекаются");
}

// Задача 41. Пользователь вводит с клавиатуры М чисел
//Посчитать, сколько чисел будет больше 0 в заданной, введенной числовой строке
Console.Clear();
Console.WriteLine("Введите числа через запятую: ");
string s = Console.ReadLine();
string[] arr = s.Split(',');
int[] mass = new int[arr.Length];
int count = 0;
for(int i = 0; i < arr.Length; i++)
{
    mass[i] = Convert.ToInt32(arr[i]);
    Console.Write(mass[i]+ " ");
}
for (int j = 0; j < mass.Length; j++)

{
    if(mass[j] > 0)
    count++;
}
    Console.WriteLine(count);