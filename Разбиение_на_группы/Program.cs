// Есть число N. Сколько групп M, можно получить при разбиении всех
// чисел на группы, так чтобы в одной группе все числа были взаимно просты (все
// числа в группе друг на друга не делятся)? Найдите M при заданном N и получите
// одно из разбиений на группы N ≤ 10²⁰.
// Например, для N = 50, M получается 6

// Группа 1: 1
// Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// Группа 5: 7 16 24 36 40
// Группа 6: 5 32 48

void PrintNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0) Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
bool exit = false;
int[] row = new int[n + 2];
row[0] = 1;
for (int i = 1; i < n; i++)
{
    row[i] = row[i - 1] + 1;
}
Console.WriteLine();

int[,] group = new int[n + 1, n + 1];
int c = 1;
group[0, 0] = 1;

for (int i = 1; i <= n; i++)
{
    if (row[c] == 0) break;
    else
    {
        group[i, 0] = row[c];
        
        for (int j = 1; j < n; j++)
        {
        
            for (int m = 0; m < j; m++)
            {
                
                if (row[c + 1] % group[i, m] == 0)
                {
                    exit = true;
                    j = n; 
                    c = c + 1; break;
                }
                else exit = false;
            }
            if (exit == false)
            {
                group[i, j] = row[c + 1];
                c = c + 1;
            }
        }
    }
}


PrintNumbers(group);