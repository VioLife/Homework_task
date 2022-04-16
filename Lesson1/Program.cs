// Задача1. Вторая цифра трехзначного 
Console.Clear ();
Console.WriteLine ("Введите трезначное число: ");

int num = int.Parse(Console.ReadLine());

num = num%100;
num = num/10;

Console.WriteLine($"Вторая цифра:{num}" );

// Задача2. Удаление второй цифры в трехзначном числе
Console.Clear();

int a = new Random().Next(100,999);
int b = a/100;
int c = a%10;

Console.WriteLine($"Случайное число: {a}");
Console.WriteLine($"Исключили вторую цифру: {b}{c}");

// Задача3. Выводим третью цифру заданного числа
Console.Clear();

Console.WriteLine("Введите любое число...");

int a = Int32.Parse(Console.ReadLine());

int b = a%10;

if(a/100 == 0)
{
    Console.WriteLine($"Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра: {b}");
}

// Задач4. Значение проверяет дни недели
Console.Clear();

Console.WriteLine("Введите число от 1 до 7" );

int num = int.Parse(Console.ReadLine());

if(num < 6)
{
    Console.WriteLine("нет, будние дни");
}
else
if(num > 5)
{
    Console.WriteLine("да, выходные");
}
