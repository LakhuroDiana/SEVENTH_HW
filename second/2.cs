// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет
// 1, 1 -> 1

System.Console.WriteLine("Введите размер массива");
string number1 = Console.ReadLine();
int n = Convert.ToInt32(number1);
string number2 = Console.ReadLine();
int m = Convert.ToInt32(number2);
float[,] array = new float[n, m];

for (int i = 0; i < n; ++i)
{
    for (int j = 0; j < m; ++j)
    {
        array[i, j] = new Random().Next(-10, 10);
    }
}

for (int i = 0; i < n; ++i)
{
    for (int j = 0; j < m; ++j)
    {
        System.Console.Write(array[i, j] + "\t");
    }
    System.Console.Write("\n");
}
int N, M;
System.Console.WriteLine("Введите номер строки");
string number3 = Console.ReadLine();
N = Convert.ToInt32(number3);
System.Console.WriteLine("Введите номер столбца");
string number4 = Console.ReadLine();
M = Convert.ToInt32(number4);

if (0 < N && N <= n && 0 < M && M <= m)
{
    System.Console.WriteLine(array[N - 1, M - 1]);
}
else
{
    System.Console.WriteLine("Нет такого элемента");
}