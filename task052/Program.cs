/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] NewMatrixArrRand(int a, int b)//создает массив заполнненный псевдослучайными вещественными числами числами в интервале от 'a' до 'b'
{
    Random rnd = new Random();
    int line = rnd.Next(1, 5);
    int column = rnd.Next(1, 5);
    int[,] newArr = new int[line, column];

    for (int i = 0; i < line; i++)
    {
        for (int ind = 0; ind < column; ind++)
        {
            int value = rnd.Next(a, b);
            newArr[i, ind] = value;
        }
    }
    return newArr;
}
void LinesMatrixArithmeticMean(int[,] array)
{

    for (int ind = 0; ind < array.GetLength(1); ind++)
    {
        if (ind == 0) Console.Write("Среднее арифметическое каждого столбца: ");
        double mean;
        mean = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            mean = mean + array[i, ind];
        }
        mean = mean / array.GetLength(0);
        if (ind == (array.GetLength(1) - 1)) Console.Write(Math.Round(mean, 1));
        else Console.Write($"{Math.Round(mean, 1)};");
    }
}
void MatrixPrintArray(int[,] array)// печать двумерного массива int, в виде таблицы
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

int[,] array = NewMatrixArrRand(1, 4);
LinesMatrixArithmeticMean(array);
Console.WriteLine();
MatrixPrintArray(array);