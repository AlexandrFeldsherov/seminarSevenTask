/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
double[,] MatrixArrRand(double[,] arr, int a, int b, int c)//заполняет созданный массив псевдослучайными вещественными числами числами в интервале от 'a' до 'b' c количеством знаков после запятой 'c'
{
    double[,] newArr = new double[arr.GetLength(0), arr.GetLength(1)];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int ind = 0; ind < arr.GetLength(1); ind++)
        {
            double value = Math.Round(rnd.NextDouble(), c) + rnd.Next(a, b);
            newArr[i, ind] = value;
        }
    }
    return newArr;
}
void MatrixPrintArray(double[,] array)// печать двумерного массива, в виде таблицы, для чисел длинной 4 знака
{

    for (int ind = 0; ind < array.GetLength(0); ind++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            if (i == array.GetLength(1) - 1) Console.WriteLine($" {array[ind, i],6}");
            else Console.Write($"{array[ind, i],6}");
        }

    }
}

Console.Write("Введите количество строк массива m : ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество сстолбцов массива n : ");
int column = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[line, column];
array = MatrixArrRand(array, -10, 10, 1);
Console.WriteLine($"m={line}, n={column}.");
MatrixPrintArray(array);
