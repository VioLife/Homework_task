int a = 10;
int b = 5;

int max = a;
int min = b;

if(a > max) max = a;
if(b > max) max = b;
{
    Console.Write("max= ");
    Console.WriteLine(max);
}
if(a < min) min = a;
if(b < min) min = b;
{
    Console.Write("min= ");
    Console.WriteLine(min);
}

