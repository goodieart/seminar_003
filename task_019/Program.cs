using static System.Console;
Clear();
Write("Введите пятизначное число: ");
int num = int.Parse(ReadLine()!);
int new_num = 0;

for(int i = num; i > 0; i /= 10) new_num = new_num * 10 + i % 10;

Write($"Это число - {(num == new_num?"":"не ")}палиндром");