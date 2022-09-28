using static System.Console;

Write("Введите число N: ");
int n = int.Parse(ReadLine()!);

for(int i = 1; i <= n; i++)
{
    Write($"{Math.Pow(i, 3)},");
}
Write("\b ");