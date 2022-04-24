//Задача 25.Возводит заданное число в заданную степень

Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите любое число: ");
int e = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{Math.Pow(num,e)}");



//Задача 27. Нахождение суммы цифр в числе
int n = 134;
int sum = 0;

while (n >0)
{
    sum += n%10;
    n /= 10;
}
Console.WriteLine(sum);

//Задача 29. Принимаем на вход числа и выводим их в качестве массива

int [] array = new int [8];
void FillMass(int[] mass) 
{
    int length = mass.Length;
    int index = 0;
    while(index < length)
    {
        mass[index] = new Random().Next(1,8);
        index++;
    }
}
void PrintMass(int[] mass)  
{
    int count = mass.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(mass[position]);
        position++;
    }  
}
FillMass(array);
PrintMass(array);