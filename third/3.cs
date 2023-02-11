// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

System.Console.WriteLine("Введите размер массива");
string number1 = Console.ReadLine();
int n = Convert.ToInt32(number1);
string number2 = Console.ReadLine();
int m = Convert.ToInt32(number2);
int[,] array = new int[n,m];

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

for (int j=0; j<m; ++j)
{ float mid=0;
    for (int i=0; i<n; ++i)
    {
      mid=mid+array[i,j];
    }
    System.Console.Write(Math.Round((mid/n),2)+"\t");
}
