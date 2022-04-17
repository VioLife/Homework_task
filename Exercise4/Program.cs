//Задача19. Нахождение палиндрома

Console.WriteLine("Введите любое пятизначное число: ");
string num = Console.ReadLine();

int len = num.Length;
bool x = true;
for (int i = 0; i < len/2; i++)
{
    if (num[i] != num[len - (i + 1)])
    {
         x = false;
         break;
    }
}
        if (x)
        {
            Console.WriteLine($"{num} является палиндромом" );
        }
        else
        {
            Console.WriteLine($"{num} не является палиндромом" );
        }

// Задача21. Нахождение расстояния между двумя точками в 3D-пространстве;

int x = 7;
int x1 = -5;
int x2 = 0;
int y = 1;
int y1 = -1;
int y2 = 9;

double length = Math.Sqrt(Math.Pow(x-y,2)+ Math.Pow(x1-y1,2)+ Math.Pow(x2-y2,2));
Console.WriteLine(length);

//Задача23. Нахождение значения в кубе любого заданного числа;

Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;

while(i < num)
{
    Console.WriteLine($"{Math.Pow(i,3)}");
    i++;
}