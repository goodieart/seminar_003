using static System.Console;
float temp = 0, sum = 0;

Clear();
WriteLine("Введите координаты точек A,B: ");

for(char i = 'x'; i <= 'z'; i++)
{    
    temp = 0;
    for(int j = 1; j > -2; j -= 2)
    {
        Write($"{i}_{(j == 1?"A":"B")}: ");
        temp += float.Parse(ReadLine()!) * j;
    }
    sum += temp * temp;
}

WriteLine($"{Math.Sqrt(sum):f2}");