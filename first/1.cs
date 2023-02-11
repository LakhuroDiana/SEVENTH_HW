// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 

System.Console.WriteLine("Введите размер массива");
string number1 = Console.ReadLine();
int n = Convert.ToInt32(number1);
string number2 = Console.ReadLine();
int m = Convert.ToInt32(number2);
float[,] array = new float[n,m];

for (int i=0; i<n; ++i)
{
    for (int j=0; j<m; ++j)
    {
        array[i,j]=new Random().Next(-10, 10);
    }
}

for (int i=0; i<n; ++i)
{
    for (int j=0; j<m; ++j)
    {
        System.Console.Write(array[i,j]+"\t");
    }
    System.Console.Write("\n");
}
